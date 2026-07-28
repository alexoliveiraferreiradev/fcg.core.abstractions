using Fcg.Core.Abstractions.Common.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Fcg.Core.WebApi.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;
        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var traceId = Activity.Current?.Id ?? context.TraceIdentifier;
            context.Response.ContentType = "application/json";

            ProblemDetails problemDetails = exception switch
            {
                
                DomainException domainEx=> new ProblemDetails
                {
                    Title = "Regra de negócio violada.",
                    Detail = domainEx.Message,
                    Status = StatusCodes.Status400BadRequest,
                    Type = "https://tools.ietf.org/html/rfc7231#section-6.5.1",
                    Instance = context.Request.Path,
                    Extensions = new Dictionary<string, object?>
                    {
                        { "traceId", traceId }
                    }
                },

                KeyNotFoundException => new ProblemDetails
                {
                    Title = "Recurso não encontrado.",
                    Status = StatusCodes.Status404NotFound,
                    Type = "https://tools.ietf.org/html/rfc7231#section-6.5.4",
                    Instance = context.Request.Path,
                    Extensions = new Dictionary<string, object?>
                    {
                        { "traceId", traceId }
                    }
                },

                _=> new ProblemDetails
                {
                    Title = "Ocorreu um erro interno no servidor.",
                    Status = StatusCodes.Status500InternalServerError,
                    Type = "https://tools.ietf.org/html/rfc7231#section-6.6.1",
                    Instance = context.Request.Path,
                    Extensions = new Dictionary<string, object?>
                    {
                        { "traceId",traceId }
                    }
                }
            };

            if(problemDetails.Status == StatusCodes.Status500InternalServerError)
            {
                _logger.LogError(exception, $"Ocorreu um erro. Informe o código {traceId} ao suporte");
            }
            else
            {
                _logger.LogWarning("Erro de negócio/validação: {Message}", exception.Message);
            }
            context.Response.StatusCode = problemDetails.Status!.Value;
            await context.Response.WriteAsJsonAsync(problemDetails);
        }
    }
}

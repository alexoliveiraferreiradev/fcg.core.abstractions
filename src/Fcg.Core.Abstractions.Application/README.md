# Fcg.Core.Abstractions.Application

Pacote com as abstrações da **camada de aplicação** compartilhadas entre os microsserviços do ecossistema **Fiap Cloud Games (FCG)**.

## 🎯 Objetivo

Padronizar comportamentos transversais (cross-cutting concerns) do pipeline de aplicação, evitando que cada microsserviço reimplemente a mesma lógica. Hoje o foco é a **validação automática de requests do MediatR** antes que eles cheguem aos handlers.

## 📦 Conteúdo do Pacote

| Tipo | Descrição |
| --- | --- |
| `ValidationBehavior<TRequest, TResponse>` | `IPipelineBehavior` do MediatR que executa todos os `IValidator<TRequest>` registrados no contêiner de DI e lança `ValidationException` (FluentValidation) quando há falhas. |

Namespace: `Fcg.Core.Abstractions.Application`

### Como funciona

1. O behavior recebe, via DI, todos os `IValidator<TRequest>` registrados para o request.
2. Se não houver nenhum validator, o pipeline segue direto para o handler.
3. Havendo validators, todos são executados **em paralelo** (`Task.WhenAll`).
4. As falhas de todos os validators são agregadas em uma única `ValidationException`.
5. Sem falhas, o handler é invocado normalmente.

Combinado com o `ExceptionMiddleware` do pacote `Fcg.Core.WebApi`, essa exceção é traduzida automaticamente em uma resposta `400 Bad Request` no formato `ValidationProblemDetails`, com os erros agrupados por propriedade e um `traceId` na extensão.

## 🔗 Dependências

- **.NET 9.0**
- [MediatR](https://www.nuget.org/packages/MediatR) `14.2.0`
- `Fcg.Core.WebApi` (que traz `FluentValidation` e, transitivamente, `Fcg.Core.Abstractions`)

## 🚀 Como Instalar

### .NET CLI
```bash
dotnet add package Fcg.Core.Abstractions.Application
```

### Package Manager
```powershell
Install-Package Fcg.Core.Abstractions.Application
```

## 💻 Exemplo de Uso

### 1. Registrar o behavior no pipeline do MediatR

```csharp
using Fcg.Core.Abstractions.Application;
using FluentValidation;
using MediatR;

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(typeof(CriarJogoCommand).Assembly);
    cfg.AddOpenBehavior(typeof(ValidationBehavior<,>));
});

// Registra todos os validators do assembly
builder.Services.AddValidatorsFromAssembly(typeof(CriarJogoCommandValidator).Assembly);
```

> A ordem importa: o `ValidationBehavior` roda na ordem em que os behaviors são adicionados ao pipeline.

### 2. Criar o command e seu validator

```csharp
public record CriarJogoCommand(string Nome, decimal Preco) : IRequest<Guid>;

public class CriarJogoCommandValidator : AbstractValidator<CriarJogoCommand>
{
    public CriarJogoCommandValidator()
    {
        RuleFor(x => x.Nome).NotEmpty().MaximumLength(100);
        RuleFor(x => x.Preco).GreaterThan(0);
    }
}
```

### 3. Resultado

O handler só é executado com um request válido. Caso contrário, a API responde:

```json
{
  "title": "Um ou mais erros de validação ocorreram.",
  "status": 400,
  "type": "https://tools.ietf.org/html/rfc7231#section-6.5.1",
  "instance": "/api/jogos",
  "traceId": "00-...",
  "errors": {
    "Nome": ["'Nome' não pode ser vazio."],
    "Preco": ["'Preco' deve ser maior que 0."]
  }
}
```

## 📚 Pacotes Relacionados

- **Fcg.Core.Abstractions** — abstrações de domínio (`EntityBase`, `AggregateRoot`, `ValueObject`, `PagedResult`, exceções).
- **Fcg.Core.WebApi** — extensões de Web API (JWT, `ExceptionMiddleware`, responses padronizadas).
- **Fcg.Core.SharedContracts** — contratos de eventos de integração entre os microsserviços.

## 🤝 Como Contribuir

Consulte as diretrizes de contribuição no repositório principal:
[Repositório no GitHub](https://github.com/alexoliveiraferreiradev/fcg.core.abstractions)

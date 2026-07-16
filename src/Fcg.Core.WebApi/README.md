# Fcg.Core.WebApi

Um pacote completo contendo extensões, configurações e middlewares fundamentais para turbinar as Web APIs do ecossistema **Fiap Cloud Games (FCG)**.

## 🎯 Objetivo

Reduzir o boilerplate na criação de novos microsserviços (APIs REST). Em vez de duplicar configurações de Segurança, JWT e Tratamento de Exceções em cada API, os microsserviços devem simplesmente importar este pacote e chamar os métodos de extensão.

## 📦 Conteúdo do Pacote

Este pacote estende funcionalidades do `Fcg.Core.Abstractions` fornecendo:
- **Extensions**: Métodos `.AddFcgJwtAuthentication()`, `.AddFcgServices()` para injeção de dependência rápida e limpa no `IServiceCollection`.
- **Middlewares**: Middleware de Tratamento Global de Exceções (`GlobalExceptionHandlerMiddleware`), traduzindo exceções de domínio em status code (400, 404, 500) padronizados.
- **Security**: Facilidades para lidar com claims do usuário autenticado na requisição atual.
- **Responses**: Classes genéricas para formatar respostas padrão de endpoints de API (Sucesso, Erro de Validação).

## 🚀 Como Instalar

Instale através do NuGet:

### .NET CLI
```bash
dotnet add package Fcg.Core.WebApi
```

### Package Manager
```powershell
Install-Package Fcg.Core.WebApi
```

## 🤝 Como Contribuir

[Repositório no GitHub](https://github.com/alexoliveiraferreiradev/fcg.core.abstractions)

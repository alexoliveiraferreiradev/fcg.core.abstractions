# Fcg.Core.Abstractions

O pacote principal que contém as abstrações fundamentais compartilhadas entre todos os microsserviços do ecosistema **Fiap Cloud Games (FCG)**.

## 🎯 Objetivo

O propósito central deste projeto é fornecer uma fundação sólida e padronizada para as aplicações da arquitetura, abstraindo interfaces comuns, contratos e exceções. Isso garante que todos os serviços se comuniquem da mesma forma e tratem erros de maneira uniforme.

## 📦 Conteúdo do Pacote

Este pacote foca em:
- **Interfaces**: Contratos (`IEntity`, `IRepository`, `IUnitOfWork`, etc) para padronizar o domínio e a camada de dados.
- **Enums**: Tipos enumerados de uso global.
- **Exceptions**: Exceções base (como `DomainException`, `NotFoundException`, etc) para padronizar os retornos de erro da API.
- **Common**: Tipos básicos e utilitários globais, como Paginação, Respostas genéricas, e objetos de valor comuns.

## 🚀 Como Instalar

Instale através do NuGet:

### .NET CLI
```bash
dotnet add package Fcg.Core.Abstractions
```

### Package Manager
```powershell
Install-Package Fcg.Core.Abstractions
```

## 💻 Exemplo de Uso

Ao referenciar no seu microsserviço, você deve herdar as abstrações disponíveis para criar entidades ou definir contratos de repositórios.

```csharp
using Fcg.Core.Abstractions.Interfaces;

public class Produto : IEntity
{
    public Guid Id { get; set; }
    // ...
}
```

## 🤝 Como Contribuir

Consulte as diretrizes de contribuição no repositório principal:
[Repositório no GitHub](https://github.com/alexoliveiraferreiradev/fcg.core.abstractions)

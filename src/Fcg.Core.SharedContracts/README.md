# Fcg.Core.SharedContracts

Este pacote contém todos os **Contratos de Mensagens** (Eventos e Comandos) compartilhados entre os microsserviços do **Fiap Cloud Games (FCG)**.

## 🎯 Objetivo

Garantir o alinhamento de comunicação em uma arquitetura distribuída e assíncrona. Quando um serviço precisa publicar ou consumir uma mensagem (via RabbitMQ, Azure Service Bus, Kafka, etc), ele utiliza os contratos fortemente tipados deste pacote.

## 📦 Conteúdo do Pacote

O pacote concentra:
- **Eventos de Integração (Integration Events)**: Eventos publicados em Message Brokers que indicam que algo aconteceu no sistema.
- **Comandos (Commands)**: Mensagens direcionadas a filas para execução de ações específicas.
- **Interfaces e Base Messages**: Estrutura base de propriedades (Id da Mensagem, Data de Criação) que todas as mensagens devem ter.

## 🚀 Como Instalar

Instale através do NuGet:

### .NET CLI
```bash
dotnet add package Fcg.Core.SharedContracts
```

### Package Manager
```powershell
Install-Package Fcg.Core.SharedContracts
```

## 💻 Exemplo de Uso

Referencie nos seus projetos de `Worker` ou `API` para publicar e consumir eventos padronizados.

```csharp
using Fcg.Core.SharedContracts.MessageContracts;

public class OrderEvent : IEvent
{
    public Guid PedidoId { get; set; }
    public decimal ValorTotal { get; set; }
}
```

## 🤝 Como Contribuir

[Repositório no GitHub](https://github.com/alexoliveiraferreiradev/fcg.core.abstractions)

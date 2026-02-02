# UtmBuilder

Projeto de exemplo do curso "Advanced .Net Developer" — utilitário para construir UTMs.

## Descrição

Pequeno projeto em .NET que contém classes de domínio para construir URLs com parâmetros UTM.

## Pré-requisitos

- [.NET SDK 10+](https://dotnet.microsoft.com/)
- Ferramenta de sua preferência: Visual Studio, VS Code, Rider

## Como compilar

Abra um terminal na raiz do repositório e execute:

```bash
dotnet build
```

Para compilar e executar um projeto específico dentro da solução (por exemplo `UtmBuilder.Core`):

```bash
dotnet build UtmBuilder.Core/UtmBuilder.Core.csproj
```

## Estrutura do repositório

- [UtmBuilder.slnx](UtmBuilder.slnx) — solução
- `UtmBuilder.Core/` — projeto principal com as classes de Value Objects e lógica
  - `ValueObjects/` — `Campaign.cs`, `Url.cs`, `ValueObject.cs`

## Observações

- Já adicionei um arquivo [.gitignore](.gitignore) com padrões para projetos .NET/Visual Studio.

## Contribuindo

Abra uma issue ou envie um pull request com melhorias.

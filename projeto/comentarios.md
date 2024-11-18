
---

# Comandos e Dicas para Projetos em C#

## Criar um Novo Projeto
Para criar um projeto C# do tipo console:
```bash
dotnet new console -o nomeProjeto
```

## Rodar o Projeto
Para iniciar/rodar o projeto:
```bash
dotnet run
```

---

## Restaurar Dependências
Para restaurar todas as dependências usadas no projeto (baseado no arquivo `.csproj`):
```bash
dotnet restore
```

> **Nota:** Isso é útil quando alguém baixa o projeto e precisa configurar o ambiente local. O comando restaura todas as dependências listadas no arquivo `.csproj`.

---

## Gerenciar Pacotes
### Exemplo de Instalação de Pacote
Para instalar pacotes, use o comando `dotnet add package`.  
Exemplo para instalar o pacote do **Postgres**:
```bash
dotnet add package Npgsql
```

### Alterações no Arquivo `.csproj`
Após instalar um pacote, o arquivo `.csproj` será atualizado automaticamente.  
Exemplo de como os pacotes aparecem no `.csproj`:
```xml
<ItemGroup>
    <PackageReference Include="Microsoft.Extensions.Configuration" Version="9.0.0" />
    <PackageReference Include="Microsoft.Extensions.Configuration.Json" Version="9.0.0" />
    <PackageReference Include="Npgsql" Version="8.0.5" />
</ItemGroup>
```
> O `.csproj` é semelhante ao `pom.xml` do Maven em Java.

---

## Pacotes para Configuração com JSON
Para utilizar o arquivo `appsettings.json` no projeto, você precisa instalar os seguintes pacotes:

1. **Instalar Pacotes:**
    ```bash
    dotnet add package Microsoft.Extensions.Configuration
    dotnet add package Microsoft.Extensions.Configuration.Json
    ```

2. **Sobre o `appsettings.json`:**
    - O arquivo `appsettings.json` pode conter informações como a rota de conexão com o banco de dados.
    - Esses pacotes permitem que o projeto interprete o arquivo JSON.

---

---

Sera que devo usar  `Inno Setup` ou `NSIS`  para criar instalador ?
Sera que devo usar  `Entity Framework Core (EF Core)`  para fazer ORM ?

---

- Models/          # Classes que representam as tabelas (NotaFiscal, Item)
- Controllers/     # Controladores (NotaFiscalController, ItemController)
- Services/        # Camada de serviços (NotaFiscalService, ItemService)
- Infrastructure/  # Código relacionado à infraestrutura (ConexaoBD, AppDbContext)
- Data/            # Código de acesso a dados (repositórios ou DbContext)

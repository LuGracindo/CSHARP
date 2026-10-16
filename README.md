# 🚀 CSHARP

Repositório com meus estudos e projetos em **C#** e **.NET**. Cada pasta é um projeto independente, com seu próprio `.csproj`, que pode ser aberto e executado separadamente.

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Git](https://img.shields.io/badge/Git-F05032?style=for-the-badge&logo=git&logoColor=white)

---

## 📂 Projetos

| Projeto | Tipo | Descrição |
|---------|------|-----------|
| [EncurtadorUrl](./EncurtadorUrl) | API web (Minimal API) | Encurtador de URLs com redirecionamento |
| [ConsoleApp1](./ConsoleApp1) | Aplicação de console | Projeto de console inicial |

---

## 🔗 EncurtadorUrl

API construída com **ASP.NET Core Minimal API** que recebe uma URL longa, gera um código curto e redireciona quem acessar esse código para o endereço original.

### Como funciona

1. Você envia uma URL para o endpoint `POST /encurtar`.
2. A API valida se é uma URL absoluta válida.
3. Um código aleatório de 6 caracteres (letras maiúsculas, minúsculas e números) é gerado, garantindo que não se repita.
4. Ao acessar `GET /{codigo}`, a API redireciona para a URL original.

Os links ficam armazenados **em memória** (`ConcurrentDictionary`), ou seja, são perdidos quando a aplicação é reiniciada.

### Endpoints

| Método | Rota | Descrição |
|--------|------|-----------|
| `POST` | `/encurtar` | Cria uma URL encurtada |
| `GET` | `/{codigo}` | Redireciona para a URL original |
| `GET` | `/listar` | Lista todas as URLs cadastradas |

### Exemplos

**Encurtar uma URL**

```bash
curl -X POST http://localhost:<porta>/encurtar \
  -H "Content-Type: application/json" \
  -d '{"url": "https://www.github.com"}'
```

Resposta:

```json
{
  "urlOriginal": "https://www.github.com",
  "urlEncurtada": "http://localhost:<porta>/aB3dE9",
  "codigo": "aB3dE9"
}
```

**Acessar a URL encurtada**

Abra `http://localhost:<porta>/aB3dE9` no navegador e você será redirecionado.

**Listar todas as URLs**

```bash
curl http://localhost:<porta>/listar
```

**Erros possíveis**

| Situação | Resposta |
|----------|----------|
| URL vazia ou inválida | `400 Bad Request` com `{ "erro": "URL inválida." }` |
| Código inexistente | `404 Not Found` com `{ "erro": "Código não encontrado." }` |

### Como executar

```bash
cd EncurtadorUrl
dotnet run
```

A porta em que a API sobe aparece no terminal ao iniciar e também pode ser consultada em `Properties/launchSettings.json`.

### Possíveis melhorias

- [ ] Persistir os dados em banco de dados (SQLite ou SQL Server)
- [ ] Restringir as URLs aceitas a `http` e `https`
- [ ] Contador de acessos por link
- [ ] Expiração de links
- [ ] Interface web para encurtar URLs
- [ ] Testes automatizados

---

## 💻 ConsoleApp1

Aplicação de console em C#, meu primeiro projeto neste repositório.

```bash
cd ConsoleApp1
dotnet run
```

---

## ✅ Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Git](https://git-scm.com/)
- Um editor, como [Visual Studio](https://visualstudio.microsoft.com/) ou [VS Code](https://code.visualstudio.com/)

Para conferir se o .NET está instalado:

```bash
dotnet --version
```

## ▶️ Clonando o repositório

```bash
git clone https://github.com/LuGracindo/CSHARP.git
cd CSHARP
```

---

## 🗂️ Estrutura

```
CSHARP/
├── ConsoleApp1/
│   ├── Program.cs
│   └── ConsoleApp1.csproj
├── EncurtadorUrl/
│   ├── Properties/
│   │   └── launchSettings.json
│   ├── appsettings.json
│   ├── appsettings.Development.json
│   ├── EncurtadorUrl.csproj
│   └── Program.cs
├── .gitignore
└── README.md
```

---

## 👤 Autor

**Lucas Gracindo**, [@LuGracindo](https://github.com/LuGracindo)

## 📄 Licença

Repositório com fins educacionais. Sinta-se à vontade para consultar e se inspirar no código.

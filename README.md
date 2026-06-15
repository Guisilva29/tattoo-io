<h1 align="center">
  tattoo.io
</h1>

<p align="center">
  <b>Smart Ink System</b> — Sistema de gerenciamento para estúdio de tatuagem
</p>

<p align="center">
  <img src="https://img.shields.io/badge/VB.NET-Windows%20Forms-purple?style=for-the-badge&logo=dotnet"/>
  <img src="https://img.shields.io/badge/SQL%20Server-LocalDB-red?style=for-the-badge&logo=microsoftsqlserver"/>
  <img src="https://img.shields.io/badge/IA-Pollinations.ai-black?style=for-the-badge"/>
</p>

---

## 📋 Sobre o Projeto

O **tattoo.io** é um sistema desktop desenvolvido em **VB.NET (Windows Forms)** com banco de dados **SQL Server**, criado para gerenciar as operações de um estúdio de tatuagem.

Desenvolvido como projeto acadêmico na **FATEC**, o sistema contempla controle de acesso por perfil, cadastros completos e geração de sugestões de tatuagem por inteligência artificial.

---

## ✨ Funcionalidades

- 🔐 **Login com controle de acesso** — perfis Administrador e Usuário
- 👥 **Cadastro de Clientes** — com CPF, telefone e data de nascimento
- 🎨 **Cadastro de Tatuadores** — com especialidade
- 📅 **Agendamentos** — criação, edição e exclusão com status
- 🤖 **Sugestão IA** — geração de imagens de tatuagens via Pollinations.ai
- 🛡️ **Painel Admin** — criação, bloqueio e exclusão de contas

---

## 🛠️ Tecnologias

| Tecnologia | Uso |
|---|---|
| VB.NET | Linguagem principal |
| Windows Forms | Interface gráfica |
| SQL Server LocalDB | Banco de dados local |
| Microsoft.Data.SqlClient | Conexão com o banco |
| Pollinations.ai | Geração de imagens por IA |

---

## 🤖 Geração de Imagens por IA

O sistema utiliza a API gratuita da **Pollinations.ai** para gerar sugestões visuais de tatuagens com base na descrição do cliente.

A requisição é feita via `HttpClient` com `User-Agent` configurado:

```vb
Dim client As New System.Net.Http.HttpClient()
client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0")
Dim url = $"https://image.pollinations.ai/prompt/{descricao}+tattoo+ink+art?nologo=true&seed={New Random().Next(1, 99999)}&width=512&height=512&enhance=true"
Dim bytes = client.GetByteArrayAsync(url).Result
Dim bmp As New System.Drawing.Bitmap(New System.IO.MemoryStream(bytes))
```

---

## 🚀 Como executar

### Pré-requisitos
- Visual Studio 2019+
- SQL Server LocalDB ou SQL Server Express
- .NET Framework 4.7.2

### Passo a passo

1. Clone o repositório:
```bash
git clone https://github.com/Guisilva29/tattoo-io.git
```

2. Abra o SQL Server Management Studio e execute o script:
```
Scripts/criar_banco.sql
```

3. Abra o projeto no Visual Studio e rode com **F5**

4. Login padrão:
```
Usuário: admin
Senha: admin
```

> ⚠️ Se estiver rodando em outro PC, ajuste a string de conexão em `DB/Conexao.vb` com o nome do servidor SQL local.

---

## 📁 Estrutura do Projeto

```
Tattoo_io/
├── DB/
│   └── Conexao.vb
├── Scripts/
│   └── criar_banco.sql
├── frmLogin.vb
├── frmMenu.vb
├── frmClientes.vb
├── frmAgendamentos.vb
├── frmTatuadores.vb
├── frmIA.vb
├── frmAdmin.vb
└── frmNovaConta.vb
```

---

## 🗄️ Banco de Dados

| Tabela | Descrição |
|---|---|
| Cliente | Dados dos clientes |
| Tatuador | Dados dos tatuadores |
| Especialidade | Especialidades por tatuador |
| Agendamento | Agendamentos do estúdio |
| Tatuagem | Registro de tatuagens |
| Usuario | Contas de acesso ao sistema |

---

## 👨‍💻 Autor

Desenvolvido por **Guilherme Oliveira** e **Angélia Assis** — FATEC SÃO CAETANO DO SUL ANTONIO RUSSO

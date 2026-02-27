<div align="center">
  <h1 align="center">📝 Text Editor CLI</h1>
  <p align="center">
    <strong>Um editor de texto leve e direto no terminal, construído em C#.</strong>
  </p>
  <p align="center">
    <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#" />
    <img src="https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET" />
    <img src="https://img.shields.io/badge/CLI-Terminal-black?style=for-the-badge&logo=windows-terminal&logoColor=white" alt="CLI" />
  </p>
</div>

<hr />

## 📖 Sobre o Projeto

O **Text Editor CLI** é uma aplicação de console minimalista e altamente focada, desenvolvida em **C#**. Ele apresenta as funcionalidades centrais de qualquer editor de texto através de uma interface de linha de comando (CLI): **criação, leitura, edição contínua e persistência de dados**.

O principal objetivo deste projeto é a manipulação direta do sistema de arquivos e a demonstração de conceitos basilares, porém cruciais, em Engenharia de Software e ecossistema .NET.

---

## 🚀 Funcionalidades

- **Abertura de Arquivos**: Leitura de qualquer documento de texto diretamente no *prompt* informando o seu caminho.
- **Modo de Edição Contínua**: O usuário pode redigir textos com múltiplas quebras de linhas sem interrupções. O modo de edição ouve continuamente até que a tecla `ESC` seja ativada, proporcionando fluidez no uso.
- **Gravação em Disco**: Os arquivos gerados são salvos diretamente na máquina com base no caminho especificado pelo usuário.
- **Sistema de Menus Interativo**: Navegação guiada pelas opções de sistema via console.

---

## 🛠️ Stack Tecnológica e Recursos

| Tecnologia | Descrição |
| :--- | :--- |
| **[C# (C-Sharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)** | Linguagem principal, fortemente tipada e orientada a objetos. |
| **[.NET](https://dotnet.microsoft.com/)** | O *framework* para inicializar o console e interpretar o app. |
| **System.IO** | Uso pesado de *Streams* com `StreamReader` e `StreamWriter`. |
| **System.Environment** | Aproveitamento de variáveis nativas como `Environment.NewLine` para garantir suporte multi-plataforma (Windows/Linux/Mac) nas quebras de linha. |

---

## 🏗️ Como Executar o Projeto Localmente

O projeto é muito leve e precisa apenas do kit de desenvolvimento .NET para ser compilado e executado em qualquer sistema operacional (cross-platform).

### Pré-requisitos
- [.NET SDK](https://dotnet.microsoft.com/download) instalado.

### Executando no Terminal

```bash
# 1. Acesse a pasta do projeto
cd TextEditor_CLI

# 2. Inicialize o software
dotnet run
```
Ao iniciar, basta escolher a opção no menu interativo digitando o número correspondente (1 para abrir, 2 para criar, 0 para sair).

---

## 👨‍💻 Para Tech Recruiters e Desenvolvedores

Ao avaliar a arquitetura do código neste repositório (`Program.cs`), você perceberá os seguintes conhecimentos essenciais de backend e fundamentação em C#:

1. **Gestão Adequada de Memória (Disposable Objects)**: As operações de I/O de disco (escrita e leitura) fazem uso dos blocos protetores **`using`**, o que garante a liberação correta de *handlers* não gerenciados assim que as operações finalizam. Evita-se, assim, vazamentos de memória (*memory leaks*) e arquivos corrompidos.
2. **Ciclo de Vida de Execução**: Entendimento maduro do ciclo de vida da aplicação com loops do tipo `do-while`, e escutas a nível de sistema (ex: `Console.ReadKey().Key != ConsoleKey.Escape`).
3. **Pilar de Clean Code**: Toda a regra de negócio (Abrir, Editar, Salvar, Menu) está desmembrada em métodos privados pontuais com o modificador genérico `static`, não misturando etapas na camada superior do método estático `Main`.
4. **Resiliência Multi-Plataforma**: Uso da variável `Environment.NewLine` no lugar de tradicionais hardcodes tipo `\n` ou `\r\n`. Isso permite que os arquivos de texto sejam criados e formatados devidamente independente se o script está rodando em Windows ou Linux.

Fique à vontade para observar o fluxo da aplicação dentro do projeto!

---
> Desenvolvido com ☕ e foco na manipulação de I/O em .NET.

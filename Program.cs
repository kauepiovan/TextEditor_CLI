using System.Runtime.CompilerServices;

namespace TextEditor;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("O que deseja fazer? ");
        Console.WriteLine("1 - Abrir arquivo.");
        Console.WriteLine("2 - Criar novo arquivo.");
        Console.WriteLine("0 - Sair.");

        short option = short.Parse(Console.ReadLine());

        switch (option)
        {
            case 0: System.Environment.Exit(0); break;
            case 1: Open(); break;
            case 2: Edit(); break;
            default: Menu(); break;
        }
    }

    static void Open()
    {
        Console.Clear();
        Console.WriteLine("Digite o caminho do arquivo.");
        string path = Console.ReadLine();

        using(var file = new StreamReader(path))
        {
            string text = file.ReadToEnd();
            Console.WriteLine(text);
        }

        Console.WriteLine("");
        Console.ReadLine();
        Menu();
    }

    static void Edit()
    {
        Console.Clear();
        Console.WriteLine("Digite seu texto abaixo (ESC para sair).");
        Console.WriteLine("------------------------------------");
        
        string text = "";

        do
        {
            text += Console.ReadLine() + System.Environment.NewLine;
        } while (Console.ReadKey().Key != ConsoleKey.Escape);

        Salvar(text);
    }

    static void Salvar(string text)
    {
        Console.Clear();
        Console.WriteLine("digite o caminho onde deseja salvar.");
        string path = Console.ReadLine();

        using (var file = new StreamWriter(path))
        {
            file.Write(text);
        }
        Console.WriteLine($"Arquivo {path} salvo com sucesso!");
        Menu();
    }
}

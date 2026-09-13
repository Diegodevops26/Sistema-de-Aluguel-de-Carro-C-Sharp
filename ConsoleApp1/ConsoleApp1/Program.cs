using System;
using System.Collections.Generic;

public class Carro
{
    public string Placa { get; set; }
    public string Modelo { get; set; }
    public bool Disponivel { get; set; } = true;
    public decimal ValorDiaria { get; set; }
}

public class Aluguel
{
    public string Cliente { get; set; }
    public Carro CarroAlugado { get; set; }
    public int Dias { get; set; }
    public decimal ValorTotal => CarroAlugado.ValorDiaria * Dias;
}

class Program
{
    static List<Carro> carros = new List<Carro>()
    {
        new Carro { Placa = "ABC1234", Modelo = "Onix LT", ValorDiaria = 100 },
        new Carro { Placa = "DEF5678", Modelo = "Renegade", ValorDiaria = 250 },
        new Carro { Placa = "GHI9012", Modelo = "HB20", ValorDiaria = 110 }
    };

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Sistema de Aluguel de Carros ===");
            Console.WriteLine("[1] - Listar Carros");
            Console.WriteLine("[2] - Alugar Carro");
            Console.WriteLine("[3] - Devolver Carro");
            Console.WriteLine("[0] - Sair");
            Console.Write("Escolha uma opção: ");
            var op = Console.ReadLine();

            if (op == "1")
                Listar();
            else if (op == "2")
                Alugar();
            else if (op == "3")
                Devolver();
            else if (op == "0")
                break;
            else
                Console.WriteLine("Opção inválida.");

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }

    static void Listar()
    {
        Console.Clear();
        Console.WriteLine("=== Carros ===");

        foreach (var carro in carros)
        {
            Console.WriteLine($"{carro.Placa} - {carro.Modelo} - Diária: {carro.ValorDiaria:C} - {(carro.Disponivel ? "Disponível" : "Alugado")}");
        }
    }

    static void Alugar()
    {
        Console.Write("Informe a placa do carro: ");
        var placa = Console.ReadLine();

        var carro = carros.Find(c => c.Placa == placa);
        if (carro == null)
        {
            Console.WriteLine("Carro não encontrado.");
            return;
        }

        if (!carro.Disponivel)
        {
            Console.WriteLine("Este carro já está alugado.");
            return;
        }

        Console.Write("Informe o nome do cliente: ");
        var cliente = Console.ReadLine();
        Console.Write("Quantidade de dias: ");
        var dias = int.Parse(Console.ReadLine());

        carro.Disponivel = false;
        Console.WriteLine($"Carro {carro.Modelo} alugado para {cliente} por {dias} dias.");
        Console.WriteLine($"Valor total: {(carro.ValorDiaria * dias):C}");
    }

    static void Devolver()
    {
        Console.Write("Informe a placa do carro a devolver: ");
        var placa = Console.ReadLine();

        var carro = carros.Find(c => c.Placa == placa);
        if (carro == null)
        {
            Console.WriteLine("Carro não encontrado.");
            return;
        }

        if (carro.Disponivel)
        {
            Console.WriteLine("Este carro não está alugado.");
            return;
        }

        carro.Disponivel = true;
        Console.WriteLine($"Carro {carro.Modelo} devolvido com sucesso.");
    }
}
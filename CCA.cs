using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static Random random = new Random();

    static string OrdenacaoPersonalizada(string texto)
    {
        var letras = texto.Where(char.IsLetter).OrderBy(c => c).ToList();
        var numeros = texto.Where(char.IsDigit).OrderBy(c => c).ToList();
        var simbolos = texto.Where(c => !char.IsLetterOrDigit(c)).OrderBy(c => c).ToList();

        return new string(letras.Concat(numeros).Concat(simbolos).ToArray());
    }

    static int FuncaoMatematica(int x)
    {
        int grau = random.Next(2, 5);

        if (grau == 2)
        {
            int a = random.Next(1, 6);
            int b = random.Next(1, 6);
            int c = random.Next(1, 6);
            return a * (int)Math.Pow(x, 2) + b * x + c;
        }
        else if (grau == 3)
        {
            int a = random.Next(1, 4);
            int b = random.Next(1, 4);
            int c = random.Next(1, 4);
            int d = random.Next(1, 4);
            return a * (int)Math.Pow(x, 3) + b * (int)Math.Pow(x, 2) + c * x + d;
        }
        else
        {
            int a = random.Next(1, 3);
            int b = random.Next(1, 3);
            int c = random.Next(1, 3);
            int d = random.Next(1, 3);
            int e = random.Next(1, 3);
            return a * (int)Math.Pow(x, 4) + b * (int)Math.Pow(x, 3) + c * (int)Math.Pow(x, 2) + d * x + e;
        }
    }

    static List<int> AplicarFuncoesMatematicas(string texto)
    {
        return texto.Select(c => FuncaoMatematica((int)c)).ToList();
    }

    static int SomaDosDigitos(int n)
    {
        return Math.Abs(n).ToString().Sum(d => int.Parse(d.ToString()));
    }

    static List<int> ReordenarPorSoma(List<int> lista)
    {
        return lista.OrderBy(SomaDosDigitos).ToList();
    }

    static List<int> OrdenacaoCircular(List<int> lista)
    {
        List<int> resultado = new List<int>();
        int[] saltos = { 2, 3, 1, 4 };
        int indice = 0;

        for (int i = 0; i < lista.Count; i++)
        {
            resultado.Add(lista[indice]);
            indice = (indice + saltos[i % saltos.Length]) % lista.Count;
        }

        return resultado;
    }

    static string Criptografar(string texto)
    {
        string etapa1 = OrdenacaoPersonalizada(texto);
        List<int> etapa2 = AplicarFuncoesMatematicas(etapa1);
        List<int> etapa3 = ReordenarPorSoma(etapa2);
        List<int> etapa4 = OrdenacaoCircular(etapa3);

        return string.Join("-", etapa4);
    }

    static void Main()
    {
        string textoOriginal = "B4a#9d!";
        string criptografado = Criptografar(textoOriginal);

        Console.WriteLine($"Texto original: {textoOriginal}");
        Console.WriteLine($"Texto criptografado: {criptografado}");
    }
}
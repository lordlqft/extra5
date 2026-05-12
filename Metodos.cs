using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sessao5
{
    public static class Metodos
    {
        public static void ExibirMenu()
        {
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Mostrar saudação");
        }

        public static int Somar(int a, int b)
        {
            return a + b;
        }

        public static void Saudacao(string nome)
        {
            Console.WriteLine($"Olá, {nome}");
        }

        public static void Main()
        {
            ExibirMenu();

            int resultado = Somar(4, 6);
            Console.WriteLine($"Resultado da soma: {resultado}");

            Saudacao("Ana");
        }
    }
}
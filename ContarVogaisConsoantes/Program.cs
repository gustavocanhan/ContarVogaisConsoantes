using System;
using System.Linq;

namespace ContarVogaisConsoantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digita uma frase: ");
            string frase = Console.ReadLine();

            int contadorVogais = 0;
            int contadorConsoantes = 0;
            int contadorNumeros = 0;
            int contadorEspacos = 0;
            int contadorEspeciais = 0;

            string todasVogais = "aeiouáàâãéêíóôõú";
            string especiais = "!@#$%^&*()_+-={}[]\\|:;\"'<>,.?/`~";

            frase = frase.ToLower();


            for (int i = 0; i < frase.Length; i++)
            {
                char caractere = frase[i];
                
                if (todasVogais.Contains(caractere))
                {
                    contadorVogais++;
                } else if(char.IsLetter(caractere))
                {
                    contadorConsoantes++;
                } else if (especiais.Contains(caractere))
                {
                    contadorEspeciais++;
                } else if(caractere == ' ')
                {
                    contadorEspacos++;
                } else if (char.IsDigit(caractere))
                {
                    contadorNumeros++;
                }
            }

            Console.WriteLine("\n=== Saída ===");
            Console.WriteLine($"Vogais: {contadorVogais}");
            Console.WriteLine($"Consoantes: {contadorConsoantes}");
            Console.WriteLine($"Especiais: {contadorEspeciais}");
            Console.WriteLine($"Espaco: {contadorEspacos}");
            Console.WriteLine($"Números: {contadorNumeros}");
        }
    }
}

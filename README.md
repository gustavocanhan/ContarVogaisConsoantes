# Contador de Vogais, Consoantes, Números, Espaços e Caracteres Especiais

Este projeto em C# foi criado para treinar **manipulação de strings**,
classificando cada caractere digitado pelo usuário em diferentes
categorias:

-   Vogais
-   Consoantes
-   Números
-   Espaços
-   Caracteres especiais

O objetivo é reforçar o uso de estruturas de repetição, condições,
métodos da classe `char` e lógica básica de análise de texto.

## Como o programa funciona

1.  O usuário digita uma frase.
2.  A frase é convertida para minúsculas para facilitar a comparação.
3.  O programa percorre cada caractere usando um `for`.
4.  Para cada caractere, o programa verifica:
    -   Se é vogal
    -   Se é letra (consoante)
    -   Se é número
    -   Se é espaço
    -   Se é caractere especial
5.  Cada categoria é contabilizada em seu respectivo contador.
6.  Ao final, todos os resultados são exibidos no console.

## Lógica usada no programa

### Vogais

    aeiouáàâãéêíóôõú

### Especiais

    !@#$%^&*()_+-={}[]\|:;"'<>,.?/`~

### Métodos importantes utilizados

-   `char.IsLetter()` -- identifica letras
-   `char.IsDigit()` -- identifica números
-   `.Contains()` -- verifica se um caractere está em uma lista
-   `.ToLower()` -- deixa tudo minúsculo

## Código do projeto

``` csharp
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
            string especiais = "!@#$%^&*()_+-={}[]\|:;"'<>,.?/`~";

            frase = frase.ToLower();

            for (int i = 0; i < frase.Length; i++)
            {
                char caractere = frase[i];

                if (todasVogais.Contains(caractere))
                {
                    contadorVogais++;
                }
                else if (char.IsLetter(caractere))
                {
                    contadorConsoantes++;
                }
                else if (especiais.Contains(caractere))
                {
                    contadorEspeciais++;
                }
                else if (caractere == ' ')
                {
                    contadorEspacos++;
                }
                else if (char.IsDigit(caractere))
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
```

## Objetivo de aprendizado

Este projeto foi criado para treinar:

-   Estruturas de repetição
-   Condições
-   Manipulação de strings
-   Identificação de tipos de caracteres
-   Lógica de classificação

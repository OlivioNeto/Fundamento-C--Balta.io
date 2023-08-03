using System;
using System.Globalization;

namespace Moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 10536.25m;

            Console.WriteLine(Math.Round(valor));
            Console.WriteLine(Math.Ceiling(valor));
            Console.WriteLine(Math.Floor(valor));
            
            
            
            // Formatação
            // Console.WriteLine(
            //     valor.ToString(
            //         "C",
            //             CultureInfo.CreateSpecificCulture("pt-BR")));
        }
    }
}

// C mostra de acordo com a cultura especificada

// E04 é o formato de calculadora 

// G como se se fosse string

// N formata para número mas sem a cultura

// P formata com porcentagem

// Round arredondar

// Ceiling arredondar para cima 

// Floor arredondar para baixo
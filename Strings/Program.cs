using System;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
           //InterString();
           //CompText();
           //SeWitch();  
           //Equals();
           //Indice();
           //MetodosAdicionais();
           //ManString();
           //StrBuilder();
        }

        static void AulaGuid()
        {
            //gerando um guid
            var id = Guid.NewGuid();
            id.ToString();

            id = new Guid("78ff8031-a187-42d2-adc1-c2f6b6570714");
            //convertendo para subString, para pegar apenas os
            // 8 primeiros caracteres do hash
            //id.ToString().Substring(0, 8);
            if(id == Guid.NewGuid())
            Console.WriteLine(id.ToString().Substring(0, 8));
        }
    
        static void InterString()
        {
            var price = 10.2;
            //var text = "O preço do produto é: " + price + " apenas na promoção" ;
            
            // var text = string.Format(
            //     "O preço do produto é {0} apenas na promoção {1}",
            //      price, true);

            var text = $"O preço do produto é {price} apenas na promoção";
           // o @ serve para fazer a quebra de linha caso esteja 
           //escrevendo um texto muito grande
            Console.WriteLine(text);
        }

        static void CompText()
        {
            //var text = "Testando"; 
            //Console.WriteLine(text.CompareTo("Testando"));
            // caso os textos sejam diferentes, o resultado do console
            // sera diferente de 0, sendo 1 ou -1. 

            var text = "Esse texto é um teste";
            //Contains verifica se na variavel text, contem a palavra 
            // esccrita entre as aspas, retorna um booleano
            Console.WriteLine(text.Contains("teste"));
            
            // StringComparison.OrdinalIgnoreCase ignora o case sensitive
            // ou seja, a busca ignora as letras maiusculas e minusculas
            // na hora de encontrar a palavra
            Console.WriteLine(text.Contains("Teste", StringComparison.OrdinalIgnoreCase));
        

        }
    
        static void SeWitch()
        {
            var text = "Este texto é um teste";
            
            // StartsWith verifica se o texto começa com a palavra ou letra 
            // escrita nas aspas, com case sensitive, retorna booleano.
            Console.WriteLine(text.StartsWith("Este"));
            Console.WriteLine(text.StartsWith("este", StringComparison.OrdinalIgnoreCase)); //ignorando case senstive
            Console.WriteLine(text.StartsWith("este")); //com case senstive
            Console.WriteLine(text.StartsWith("texto"));

            Console.WriteLine("-----------------------------------------------------------------------------");

            // EndsWith verifica se o texto termina com a palavra ou letra
            // escrita nas aspas, com case sensitive, retorna booleano.
            Console.WriteLine(text.EndsWith("teste"));    
            Console.WriteLine(text.EndsWith("Teste", StringComparison.OrdinalIgnoreCase)); //ignora o case sensitive
            Console.WriteLine(text.EndsWith("Teste")); //com o case sensitive
            Console.WriteLine(text.EndsWith("xpro"));



        }

        static void Equals()
        {
            var text = "Este texto é um teste";
            Console.WriteLine(text.Equals("Esse texto é um teste"));
            Console.WriteLine(text.Equals("esse texto é um teste"));
            Console.WriteLine(text.Equals("Esse texto é um teste", StringComparison.OrdinalIgnoreCase));
        } 
    
        static void Indice()
        {
            var text = "Este texto é um teste";
            //IndexOf sempre vai pegar sempre os mesmos tipos de dados
            //IndexOf vai pegar a posição do caractere na frase
            Console.WriteLine(text.IndexOf("é"));
            Console.WriteLine(text.IndexOf("um"));

            //LastIndexOf pega a ultima letra que ele encontra na frase
            Console.WriteLine(text.LastIndexOf("s"));            
        }
    
        static void MetodosAdicionais()
        {
            var text = "Este texto é um teste";

            //converter todo o texto para minusculo.
            Console.WriteLine(text.ToLower());

            //converter todo o texto para maiusculo.
            Console.WriteLine(text.ToUpper());

            // inserir na quinta posição o texto nas aspas.
            Console.WriteLine(text.Insert(5,"AQUI"));

            //a partir dos Quinto caractere remover os proximos             
            Console.WriteLine(text.Remove(5,5));

            //quantidade de caracteres que uma string tem
            Console.WriteLine(text.Length);

        }
    
        static void ManString()
        {
            var text = "Este texto é um teste";

            //troca uma palavra por outra, com case sensitive
            Console.WriteLine(text.Replace("Este", "isto"));
            
            //troca todo o e minusculo por X maiusculo
            Console.WriteLine(text.Replace("e", "X"));

            //divide o texto
            var divisao = text.Split("");
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);

            // a partir do quinto caractere pegar os proximos 5 caracteres
            var resultado = text.Substring(5, 5);
            Console.WriteLine(resultado);

            // a partir do quinto caractere pegar até a letra desejada
            //var resultado = text.Substring(5, text.LastIndexOf("o"));
            //Console.WriteLine(resultado);

            //remove todos os espaços do começo e do final da string
            Console.WriteLine(text.Trim());
        }
    
        static void StrBuilder()
        {
            //construindo uma string
            var text = new StringBuilder();

            //anexar um item ao texto
            text.Append("Este texto é um teste");
            text.Append("Este texto é um teste");
            text.Append("Este texto é um teste");
            text.Append("Este texto é um teste");
            text.Append("Este texto é um teste");

            Console.WriteLine(text);            
        }
    }
}
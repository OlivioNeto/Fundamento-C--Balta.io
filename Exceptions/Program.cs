using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //OcorrendoException();
            //TryCatch();
            //TratandoException();
            //DisparandoException();
            //CustomException();
            //Finally();
        }

        static void OcorrendoException()
        {
             Console.Clear();
             var array = new int [3];

            for (var index = 0; index < 10; index++)
            {
                //System.IndexOutOfRangeException 
                //erro que aparece no terminal que precisa ser tratado
                Console.WriteLine(array[index]);
            }
        }

        static void TryCatch()
        {
            Console.Clear();
            var array = new int [3];

            try
            {
                for (var index = 0; index < 10; index++)
                {
                //System.IndexOutOfRangeException 
                //erro que aparece no terminal que precisa ser tratado
                Console.WriteLine(array[index]);
                }
            } 
                catch(Exception ex)
                {
                    //mostrando o pq do erro estar acontecendo
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);

                    //exibindo uma mensagem de erro
                    Console.WriteLine("Ops, algo deu errado");
                }
           
        }

        static void TratandoException()
        {
            Console.Clear();
            var array = new int [3];

            try
            {
                for (var index = 0; index < 10; index++)
                {
                //System.IndexOutOfRangeException 
                //erro que aparece no terminal que precisa ser tratado
                Console.WriteLine(array[index]);
                }
            } 
               //tratar erros sempre do mais especifico com o mais generico

                catch(System.IndexOutOfRangeException ex)
                {
                    //mostrando o pq do erro estar acontecendo
                    //essa tratativa mostra o erro dos indices
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Não encontrei o índice na lista");
                }
                
                catch(Exception ex)
                {
                    //mostrando o pq do erro estar acontecendo
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);

                    //exibindo uma mensagem de erro
                    Console.WriteLine("Ops, algo deu errado");
                }
        }

        static void DisparandoException()
        {
             Console.Clear();
            var array = new int [3];

            try
            {
                // for (var index = 0; index < 10; index++)
                // {
                // //System.IndexOutOfRangeException 
                // //erro que aparece no terminal que precisa ser tratado
                // Console.WriteLine(array[index]);
                // }

                Cadastrar("");
            } 
               //tratar erros sempre do mais especifico com o mais generico
               
                catch(System.IndexOutOfRangeException ex)
                {
                    //mostrando o pq do erro estar acontecendo
                    //essa tratativa mostra o erro dos indices
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Não encontrei o índice na lista");
                }
                
                catch(ArgumentNullException ex)
                {
                    //mostrando o pq do erro estar acontecendo
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);

                    //exibindo uma mensagem de erro
                    Console.WriteLine("Falha ao cadastrar o texto");
                }
                catch(Exception ex)
                {
                    //mostrando o pq do erro estar acontecendo
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);

                    //exibindo uma mensagem de erro
                    Console.WriteLine("Ops, algo deu errado");
                }
        }
    
        static void CustomException()
        {
             Console.Clear();
            var array = new int [3];

            try
            {
                // for (var index = 0; index < 10; index++)
                // {
                // //System.IndexOutOfRangeException 
                // //erro que aparece no terminal que precisa ser tratado
                // Console.WriteLine(array[index]);
                // }

                Cadastrar("");
            } 
               //tratar erros sempre do mais especifico com o mais generico
               
                catch(System.IndexOutOfRangeException ex)
                {
                    //mostrando o pq do erro estar acontecendo
                    //essa tratativa mostra o erro dos indices
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Não encontrei o índice na lista");
                }
                
                catch(ArgumentNullException ex)
                {
                    //mostrando o pq do erro estar acontecendo
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);

                    //exibindo uma mensagem de erro
                    Console.WriteLine("Falha ao cadastrar o texto");
                }

                catch(MinhaException ex)
                {
                    //mostrando o pq do erro estar acontecendo
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.QuandoAconteceu);

                    //exibindo uma mensagem de erro
                    Console.WriteLine("Excessão customizada");
                }

                catch(Exception ex)
                {
                    //mostrando o pq do erro estar acontecendo
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);

                    //exibindo uma mensagem de erro
                    Console.WriteLine("Ops, algo deu errado");
                }
        }

        static void Finally()
        {
            Console.Clear();
            var array = new int [3];

            try
            {
                // for (var index = 0; index < 10; index++)
                // {
                // //System.IndexOutOfRangeException 
                // //erro que aparece no terminal que precisa ser tratado
                // Console.WriteLine(array[index]);
                // }

                Cadastrar("grtgtfetr");
            } 
               //tratar erros sempre do mais especifico com o mais generico
               
                catch(System.IndexOutOfRangeException ex)
                {
                    //mostrando o pq do erro estar acontecendo
                    //essa tratativa mostra o erro dos indices
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Não encontrei o índice na lista");
                }
                
                catch(ArgumentNullException ex)
                {
                    //mostrando o pq do erro estar acontecendo
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);

                    //exibindo uma mensagem de erro
                    Console.WriteLine("Falha ao cadastrar o texto");
                }

                catch(MinhaException ex)
                {
                    //mostrando o pq do erro estar acontecendo
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.QuandoAconteceu);

                    //exibindo uma mensagem de erro
                    Console.WriteLine("Excessão customizada");
                }

                catch(Exception ex)
                {
                    //mostrando o pq do erro estar acontecendo
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);

                    //exibindo uma mensagem de erro
                    Console.WriteLine("Ops, algo deu errado");
                }
                finally //fecha as conexões abertas
                {
                    Console.WriteLine("Chegou ao fim");
                }
        }

        private static void Cadastrar(string texto)
        {
            if(string.IsNullOrEmpty(texto))
            throw new MinhaException(DateTime.Now);
        }
    
        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }
            public DateTime QuandoAconteceu{get;set;}
        }
    }
}

using System;
using System.Reflection.PortableExecutable;
using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black; 
            
            Console.Clear();
            
            Console.WriteLine("Modo Editor");
            Console.WriteLine("------------------");
            
            Start();
        }

        public static void Start()
        {
           var file = new StringBuilder();

           do {
             file.Append(Console.ReadLine());
             file.Append(Environment.NewLine);
             
           } while(Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("------------------");
            Console.WriteLine(" Deseja salvar o Arquivo?");

            Viewer.Show(file.ToString());

            
        }
    }
}
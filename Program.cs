using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace readwriteapp
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter wr = new StreamWriter(@"D:\doc.txt", true);
            wr.WriteLine("Primeira linha");
            wr.WriteLine("Segunda linha");
            wr.Close();
            StreamReader rd = new StreamReader(@"D:\doc.txt");
            while (!rd.EndOfStream)
            {
                string linha = rd.ReadLine();
                Console.WriteLine(linha);
            }
            rd.Close();
            Console.Write("\n\n\nPressione qualquer tecla para sair...");
            Console.ReadKey(true);
        }
    }
}

using System;
using System.IO;
using System.Text;
using Komponent.IO;
namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {

            try
            {
                string aux = "";
                int i = 1;
                if (args.Length < 1)
                {
                    Console.WriteLine("Precisa de pelo menos 1 Argumento");
                    return;
                }

                var isExtract = args.Length > 1 && args[1] == "-x";
                if (args.Length > 1 && args[1] != "-x")
                {
                    Console.WriteLine($"Opção desconhecida {args[1]}.");
                    return;
                }
                while (i == 1)
                {
                    BinaryWriterX BravelyFile;
                    //Verifica a existencia do arquivo no sistema
                    if (System.IO.File.Exists(@"C:\Users\vitor\Desktop\" + args[0]))
                    {
                        string fileName = @"C:\Users\vitor\Desktop\" + args[0];
                        FileStream writeStream = new FileStream(fileName, FileMode.Append);// Append -> Permite o Acréscimo de dados no arquivo
                        BravelyFile = new BinaryWriterX(writeStream, Encoding.Unicode);
                    }
                    else
                    {
                        string fileName = @"C:\Users\vitor\Desktop\" + args[0];
                        FileStream writeStream = new FileStream(fileName, FileMode.Create);//Criação do arquivo
                        BravelyFile = new BinaryWriterX(writeStream, Encoding.Unicode);
                    }

                    //Verifica se o texto possui \n ou não
                    Console.WriteLine("O texto a ser inserido possui \\n?");
                    aux = Console.ReadLine();
                    if (aux == "s")
                        BravelyWriteComLinhaN(args, BravelyFile);
                    else
                        BravelyWriteSemLinhaN(args, BravelyFile);

                    Console.WriteLine("Existem mais textos para colocar?");
                    aux = Console.ReadLine();
                    if (aux == "n")
                        i = 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void BravelyWriteComLinhaN(string[] args, BinaryWriterX BravelyFile)
        {
            try
            {
                string texto = "";

                //Laço para colocar os textos do jogo(Por enquanto,cada entrada deve ser colocada manualmente)

                while (!string.IsNullOrEmpty(texto = Console.ReadLine()))
                {
                    BravelyFile.WriteString(texto + '\n', Encoding.Unicode, false, false);//Comando para colocar o texto no arquivo e com byte 00 a cada letra,com \n ao fim da string
                }
                BravelyFile.WriteString("" + '\0', Encoding.Unicode, false, false);//Finaliza o arquivo colocando 00 00 nele --> Arrumar
                BravelyFile.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void BravelyWriteSemLinhaN(string[] args, BinaryWriterX BravelyFile)
        {
            try
            {
                string texto = "";

                while (!string.IsNullOrEmpty(texto = Console.ReadLine()))
                {
                    BravelyFile.WriteString(texto + '\0', Encoding.Unicode, false, false);//Comando para colocar o texto no arquivo e com byte 00 a cada letra,com \n ao fim da string
                }
                BravelyFile.WriteString("" + '\0', Encoding.Unicode, false, false);//Finaliza o arquivo colocando 00 00 nele --> Arrumar
                BravelyFile.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

using System;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
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
                int i = 1;
                if (args.Length < 1)
                {
                    Console.WriteLine("Precisa de pelo menos 1 Argumento");
                    return;
                }

                var isExtract = args.Length > 1 && args[0] == "-x";
                var filtro = args.Length > 1 && args[0] == "-f";
                if ((args.Length > 1 && args[0] != "-x") && (args.Length > 1 && args[0] != "-f"))
                {
                    Console.WriteLine($"Opção desconhecida {args[1]}.");
                    return;
                }
                if (isExtract)
                {
                    while (i == 1)
                    {
                        BinaryWriterX BravelyFile;
                        //Verifica a existencia do arquivo no sistema
                        if (System.IO.File.Exists(@"C:\Users\vitor\Desktop\" + args[1]))
                        {
                            string fileName = @"C:\Users\vitor\Desktop\" + args[1];
                            FileStream writeStream = new FileStream(fileName, FileMode.Append);// Append -> Permite o Acréscimo de dados no arquivo
                            BravelyFile = new BinaryWriterX(writeStream, Encoding.Unicode);
                        }
                        else
                        {
                            string fileName = @"C:\Users\vitor\Desktop\" + args[1];
                            FileStream writeStream = new FileStream(fileName, FileMode.Create);//Criação do arquivo
                            BravelyFile = new BinaryWriterX(writeStream, Encoding.Unicode);
                        }

                        string[] lines = System.IO.File.ReadAllLines(@"C:\Users\vitor\Desktop\" + args[2]);

                        for (int j = 0; j < lines.Length; j++)
                        {
                            if (lines[j] != "{END}")//Verifica se chegou ao fim de uma sub-string do arquivo
                            {
                                int cont = j;
                                if(cont+1>lines.Length)
                                {
                                    if (lines[j].Contains("/0A"))
                                    {
                                        lines[j] = lines[j].Replace("/0A", "\n");
                                    }
                                    BravelyFile.WriteString(lines[j] + '\0', Encoding.Unicode, false, false);//Comando para colocar o texto no arquivo e com byte 00 a cada letra,com \n ao fim da string
                                    Console.WriteLine("passou");
                                    return;
                                }
                                else if (lines[cont]!="" && cont+1<=lines.Length)//Verifica se a próxima linha tem textos,se tiver,quer dizer que é necessário quebra de linha
                                {
                                    if (lines[j].Contains("/0A"))
                                    {
                                        lines[j] = lines[j].Replace("/0A", "\n");
                                    }
                                    BravelyFile.WriteString(lines[j] + '\n', Encoding.Unicode, false, false);//Comando para colocar o texto no arquivo e com byte 00 a cada letra,com \n ao fim da string
                                }
                                else
                                {
                                    if (lines[j].Contains("/0A"))
                                    {
                                        lines[j] = lines[j].Replace("/0A", "\n");
                                    }
                                    BravelyFile.WriteString(lines[j] + '\0', Encoding.Unicode, false, false);//Comando para colocar o texto no arquivo e com byte 00 a cada letra,com \n ao fim da string
                                }                                                             
                            }
                            else
                                continue;
                        }
                        Console.WriteLine("Foi");
                        BravelyFile.WriteString("" + '\0', Encoding.Unicode, false, false);//Finaliza o arquivo colocando 00 00 nele --> Arrumar
                        BravelyFile.Close();
                        i = 0;
                    }
                }
                if(filtro)
                {
                    Console.WriteLine("foi");
                    string[] lines = System.IO.File.ReadAllLines(@"C:\Users\vitor\Desktop\" + args[1]);

                    int contEnd = 1;
                    for (int j = 0; j < lines.Length; j++)
                    {
                        
                        if(lines[j].StartsWith("{END}"))
                        {
                            contEnd++;
                        }
                            
                        if (lines[j].StartsWith("/00/00"))//Filtrando ponteiros corrompidos(padrão identificado)
                            Console.WriteLine("Posição do ponteiro corrompido: " + contEnd);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    }
       
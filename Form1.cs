using Komponent.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bravely_Default_Text_Injector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void contatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/MrVtR");
            Process.Start(sInfo);
        }

        private void repositórioDoCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/MrVtR/Bravely_Default_Text_Injector");
            Process.Start(sInfo);
        }

        private void btnTexto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Selecione o arquivo de texto com o formato de output do Kruptar7";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Arquivos de Texto|*.txt";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.RestoreDirectory = true;
            DialogResult drOpen = openFileDialog1.ShowDialog();

            saveFileDialog1.Title = "Selecione o nome do arquivo que será criado com o inject do Texto";
            saveFileDialog1.RestoreDirectory = true;
            DialogResult drSave = saveFileDialog1.ShowDialog();

            if (drOpen == DialogResult.OK && drSave == DialogResult.OK)
            {
                int i = 1;
                while (i == 1)
                {
                    BinaryWriterX BravelyFile;
                    //Verifica a existencia do arquivo no sistema
                    if (System.IO.File.Exists(saveFileDialog1.FileName))
                    {
                        string fileName = saveFileDialog1.FileName;
                        FileStream writeStream = new FileStream(fileName, FileMode.Append);// Append -> Permite o Acréscimo de dados no arquivo
                        BravelyFile = new BinaryWriterX(writeStream, Encoding.Unicode);
                    }
                    else
                    {
                        string fileName = saveFileDialog1.FileName;
                        FileStream writeStream = new FileStream(fileName, FileMode.Create);//Criação do arquivo
                        BravelyFile = new BinaryWriterX(writeStream, Encoding.Unicode);
                    }

                    string[] lines = System.IO.File.ReadAllLines(openFileDialog1.FileName);

                    for (int j = 0; j < lines.Length; j++)
                    {
                        if (lines[j] != "{END}")//Verifica se chegou ao fim de uma sub-string do arquivo
                        {
                            int cont = j;
                            if (cont + 1 > lines.Length)
                            {
                                if (lines[j].Contains("/0A"))
                                {
                                    lines[j] = lines[j].Replace("/0A", "\n");
                                }
                                BravelyFile.WriteString(lines[j] + '\0', Encoding.Unicode, false, false);//Comando para colocar o texto no arquivo e com byte 00 a cada letra,com \n ao fim da string
                                Console.WriteLine("passou");
                                return;
                            }
                            else if (lines[cont] != "" && cont + 1 <= lines.Length)//Verifica se a próxima linha tem textos,se tiver,quer dizer que é necessário quebra de linha
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
            MessageBox.Show(saveFileDialog1.FileName + "\nCriado com sucesso\nCom o Inject de: "+openFileDialog1.FileName, "Operação finalizada");
            var continuar = MessageBox.Show("Quer fazer outra operação?", "Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (continuar == DialogResult.No)
                Form1.ActiveForm.Close();

        }

        private void btnPonteiros_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Selecione o arquivo de texto com o formato de output do Kruptar7";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Arquivos de Texto|*.txt";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.RestoreDirectory = true;
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    Console.WriteLine("foi");
                    string[] lines = System.IO.File.ReadAllLines(openFileDialog1.FileName);

                    int contEnd = 1;
                    for (int j = 0; j < lines.Length; j++)
                    {

                        if (lines[j].StartsWith("{END}"))
                        {
                            contEnd++;
                        }

                        if (lines[j].StartsWith("/00/00"))//Filtrando ponteiros corrompidos(padrão identificado)
                        {
                            Console.WriteLine("Posição do ponteiro corrompido: " + (contEnd));
                            contEnd--;
                        }

                    }
                    MessageBox.Show(openFileDialog1.FileName+"\nFiltrado com sucesso", "Operação finalizada");
                    var continuar = MessageBox.Show("Quer fazer outra operação?", "Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (continuar == DialogResult.No)
                        Form1.ActiveForm.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void ComoFiltrarOsPonteirosCorrompidos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "Tutorial:\n\n" +
               "Escolha o arquivo de texto para ter seus ponteiros filtrados:\n\n" +

               "Os ponteiros com textos corrompidos iniciam com o texto \\00\\00\n\n" +
               "O arquivo de texto precisará ter as seguintes configurações:\n\n" +
               "Textos com mais de uma linha: Quebras de linha separadas por Enter\n" +
               "Entre o final de um texto e o ínicio de outro é obrigatório ter uma string \"{END}\", para que seja identificado quando um texto acaba e outro começa\n\n" +

               "Ao final, será retornado no console de debug as posições de onde estão os ponteiros corrompidos, para serem filtrados no programa\n",
               "Tutorial de uso da edição do Crowd.fs\n",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ComoUtilizarAInjeçãoDeTextos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Tutorial:\n\n" +
                "Escolha o arquivo de texto para ser injetado em um arquivo Binário Unicode e escolha o nome+extensão do novo arquivo:\n\n" +

                "O arquivo de texto precisará ter as seguintes configurações:\n\n" +
                "Textos com mais de uma linha:\nQuebras de linha separadas por Enter\n" +
                "Entre o final de um texto e o ínicio de outro é obrigatório ter uma linha vazia, para que seja identificado quando um texto acaba e outro começa\n\n" +

                "Ao final, será criado o arquivo binário com o texto em formato Unicode, ou seja, a cada letra,existirá um byte 00 em seguida",
                "Tutorial de uso da edição do Crowd.fs\n",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

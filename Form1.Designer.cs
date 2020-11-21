namespace Bravely_Default_Text_Injector
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnTexto = new System.Windows.Forms.Button();
            this.btnPonteiros = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoUtilizarAEdiçãoDoCrowdfsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoUtilizarAEdiçãoDoIndexfsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repositórioDoCódigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTexto
            // 
            this.btnTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTexto.Location = new System.Drawing.Point(162, 341);
            this.btnTexto.Name = "btnTexto";
            this.btnTexto.Size = new System.Drawing.Size(123, 37);
            this.btnTexto.TabIndex = 0;
            this.btnTexto.Text = "Injetar Texto";
            this.btnTexto.UseVisualStyleBackColor = true;
            this.btnTexto.Click += new System.EventHandler(this.btnTexto_Click);
            // 
            // btnPonteiros
            // 
            this.btnPonteiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPonteiros.Location = new System.Drawing.Point(444, 341);
            this.btnPonteiros.Name = "btnPonteiros";
            this.btnPonteiros.Size = new System.Drawing.Size(151, 37);
            this.btnPonteiros.TabIndex = 2;
            this.btnPonteiros.Text = "Filtrar Ponteiros";
            this.btnPonteiros.UseVisualStyleBackColor = true;
            this.btnPonteiros.Click += new System.EventHandler(this.btnPonteiros_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem,
            this.repositórioDoCódigoToolStripMenuItem,
            this.contatoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comoUtilizarAEdiçãoDoCrowdfsToolStripMenuItem,
            this.comoUtilizarAEdiçãoDoIndexfsToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // comoUtilizarAEdiçãoDoCrowdfsToolStripMenuItem
            // 
            this.comoUtilizarAEdiçãoDoCrowdfsToolStripMenuItem.Name = "comoUtilizarAEdiçãoDoCrowdfsToolStripMenuItem";
            this.comoUtilizarAEdiçãoDoCrowdfsToolStripMenuItem.Size = new System.Drawing.Size(315, 24);
            this.comoUtilizarAEdiçãoDoCrowdfsToolStripMenuItem.Text = "Como utilizar a edição do Crowd.fs";
            this.comoUtilizarAEdiçãoDoCrowdfsToolStripMenuItem.Click += new System.EventHandler(this.comoUtilizarAEdiçãoDoCrowdfsToolStripMenuItem_Click);
            // 
            // comoUtilizarAEdiçãoDoIndexfsToolStripMenuItem
            // 
            this.comoUtilizarAEdiçãoDoIndexfsToolStripMenuItem.Name = "comoUtilizarAEdiçãoDoIndexfsToolStripMenuItem";
            this.comoUtilizarAEdiçãoDoIndexfsToolStripMenuItem.Size = new System.Drawing.Size(315, 24);
            this.comoUtilizarAEdiçãoDoIndexfsToolStripMenuItem.Text = "Como utilizar a edição do Index.fs";
            this.comoUtilizarAEdiçãoDoIndexfsToolStripMenuItem.Click += new System.EventHandler(this.comoUtilizarAEdiçãoDoIndexfsToolStripMenuItem_Click);
            // 
            // repositórioDoCódigoToolStripMenuItem
            // 
            this.repositórioDoCódigoToolStripMenuItem.Name = "repositórioDoCódigoToolStripMenuItem";
            this.repositórioDoCódigoToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.repositórioDoCódigoToolStripMenuItem.Text = "Repositório do código";
            this.repositórioDoCódigoToolStripMenuItem.Click += new System.EventHandler(this.repositórioDoCódigoToolStripMenuItem_Click);
            // 
            // contatoToolStripMenuItem
            // 
            this.contatoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contatoToolStripMenuItem.Name = "contatoToolStripMenuItem";
            this.contatoToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.contatoToolStripMenuItem.Text = "Contato";
            this.contatoToolStripMenuItem.Click += new System.EventHandler(this.contatoToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(737, 914);
            this.Controls.Add(this.btnPonteiros);
            this.Controls.Add(this.btnTexto);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Bravely Default - Crowd.fs and Index.fs Injector";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTexto;
        private System.Windows.Forms.Button btnPonteiros;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repositórioDoCódigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comoUtilizarAEdiçãoDoCrowdfsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comoUtilizarAEdiçãoDoIndexfsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


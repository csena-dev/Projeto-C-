
namespace ProjetoSistema.Formularios
{
    partial class Form_Cadastro
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoHospedeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraIMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(592, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoUsuarioToolStripMenuItem,
            this.novoFuncionárioToolStripMenuItem,
            this.novoHospedeToolStripMenuItem,
            this.calculadoraIMCToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // novoUsuarioToolStripMenuItem
            // 
            this.novoUsuarioToolStripMenuItem.Name = "novoUsuarioToolStripMenuItem";
            this.novoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoUsuarioToolStripMenuItem.Text = "Novo Usuario";
            this.novoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.novoUsuarioToolStripMenuItem_Click);
            // 
            // novoFuncionárioToolStripMenuItem
            // 
            this.novoFuncionárioToolStripMenuItem.Name = "novoFuncionárioToolStripMenuItem";
            this.novoFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoFuncionárioToolStripMenuItem.Text = "Novo Funcionário";
            this.novoFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.novoFuncionárioToolStripMenuItem_Click);
            // 
            // novoHospedeToolStripMenuItem
            // 
            this.novoHospedeToolStripMenuItem.Name = "novoHospedeToolStripMenuItem";
            this.novoHospedeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoHospedeToolStripMenuItem.Text = "Novo Hospede";
            this.novoHospedeToolStripMenuItem.Click += new System.EventHandler(this.novoHospedeToolStripMenuItem_Click);
            // 
            // calculadoraIMCToolStripMenuItem
            // 
            this.calculadoraIMCToolStripMenuItem.Name = "calculadoraIMCToolStripMenuItem";
            this.calculadoraIMCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calculadoraIMCToolStripMenuItem.Text = "Calculadora IMC";
            this.calculadoraIMCToolStripMenuItem.Click += new System.EventHandler(this.calculadoraIMCToolStripMenuItem_Click);
            // 
            // Form_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 313);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Cadastro";
            this.Text = "Menu ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoHospedeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraIMCToolStripMenuItem;
    }
}
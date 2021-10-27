
namespace ProjetoSistema.Formularios
{
    partial class Form_Usuario
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
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblSenha = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.DtgUsuarios = new System.Windows.Forms.DataGridView();
            this.ComboStatus = new System.Windows.Forms.ComboBox();
            this.LblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(86, 88);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(132, 23);
            this.TxtUsuario.TabIndex = 0;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(86, 117);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(132, 23);
            this.TxtSenha.TabIndex = 1;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(22, 91);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(47, 15);
            this.LblUsuario.TabIndex = 2;
            this.LblUsuario.Text = "Usuario";
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Location = new System.Drawing.Point(22, 125);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(39, 15);
            this.LblSenha.TabIndex = 3;
            this.LblSenha.Text = "Senha";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTitulo.ForeColor = System.Drawing.Color.Black;
            this.LblTitulo.Location = new System.Drawing.Point(22, 25);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(202, 19);
            this.LblTitulo.TabIndex = 4;
            this.LblTitulo.Text = "Cadastrar Novo Usuário";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(454, 113);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(96, 29);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // DtgUsuarios
            // 
            this.DtgUsuarios.AllowUserToAddRows = false;
            this.DtgUsuarios.AllowUserToDeleteRows = false;
            this.DtgUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.DtgUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgUsuarios.GridColor = System.Drawing.Color.Gainsboro;
            this.DtgUsuarios.Location = new System.Drawing.Point(22, 172);
            this.DtgUsuarios.Name = "DtgUsuarios";
            this.DtgUsuarios.ReadOnly = true;
            this.DtgUsuarios.RowTemplate.Height = 25;
            this.DtgUsuarios.Size = new System.Drawing.Size(539, 166);
            this.DtgUsuarios.TabIndex = 18;
            // 
            // ComboStatus
            // 
            this.ComboStatus.FormattingEnabled = true;
            this.ComboStatus.Location = new System.Drawing.Point(301, 91);
            this.ComboStatus.Name = "ComboStatus";
            this.ComboStatus.Size = new System.Drawing.Size(121, 23);
            this.ComboStatus.TabIndex = 19;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(242, 96);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(42, 15);
            this.LblStatus.TabIndex = 20;
            this.LblStatus.Text = "Status:";
            // 
            // Form_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 370);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.ComboStatus);
            this.Controls.Add(this.DtgUsuarios);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.LblSenha);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtUsuario);
            this.Name = "Form_Usuario";
            this.Text = "Form_Usuario";
            this.Load += new System.EventHandler(this.Form_Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView DtgUsuarios;
        private System.Windows.Forms.ComboBox ComboStatus;
        private System.Windows.Forms.Label LblStatus;
    }
}
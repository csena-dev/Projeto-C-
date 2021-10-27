
namespace ProjetoSistema.Formularios
{
    partial class Form_Funcionarios
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblDataNascimento = new System.Windows.Forms.Label();
            this.LblDataContratado = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.ComboStatus = new System.Windows.Forms.ComboBox();
            this.DtgFuncionarios = new System.Windows.Forms.DataGridView();
            this.TxtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.TxtDataContratado = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTitulo.ForeColor = System.Drawing.Color.Black;
            this.LblTitulo.Location = new System.Drawing.Point(33, 41);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(233, 18);
            this.LblTitulo.TabIndex = 5;
            this.LblTitulo.Text = "Cadastrar Novo Funcionario";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(33, 94);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(43, 15);
            this.LblNome.TabIndex = 6;
            this.LblNome.Text = "Nome:";
            // 
            // LblDataNascimento
            // 
            this.LblDataNascimento.AutoSize = true;
            this.LblDataNascimento.Location = new System.Drawing.Point(258, 94);
            this.LblDataNascimento.Name = "LblDataNascimento";
            this.LblDataNascimento.Size = new System.Drawing.Size(117, 15);
            this.LblDataNascimento.TabIndex = 7;
            this.LblDataNascimento.Text = "Data de Nascimento:";
            // 
            // LblDataContratado
            // 
            this.LblDataContratado.AutoSize = true;
            this.LblDataContratado.Location = new System.Drawing.Point(254, 143);
            this.LblDataContratado.Name = "LblDataContratado";
            this.LblDataContratado.Size = new System.Drawing.Size(118, 15);
            this.LblDataContratado.TabIndex = 8;
            this.LblDataContratado.Text = "Data de Contratação:";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(33, 143);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(42, 15);
            this.LblStatus.TabIndex = 9;
            this.LblStatus.Text = "Status:";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(82, 91);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(100, 23);
            this.TxtNome.TabIndex = 10;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(477, 211);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(72, 23);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // ComboStatus
            // 
            this.ComboStatus.FormattingEnabled = true;
            this.ComboStatus.Location = new System.Drawing.Point(78, 140);
            this.ComboStatus.Name = "ComboStatus";
            this.ComboStatus.Size = new System.Drawing.Size(100, 23);
            this.ComboStatus.TabIndex = 15;
            this.ComboStatus.Text = "Selecione";
            // 
            // DtgFuncionarios
            // 
            this.DtgFuncionarios.AllowUserToAddRows = false;
            this.DtgFuncionarios.AllowUserToDeleteRows = false;
            this.DtgFuncionarios.BackgroundColor = System.Drawing.Color.White;
            this.DtgFuncionarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DtgFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgFuncionarios.GridColor = System.Drawing.Color.Gainsboro;
            this.DtgFuncionarios.Location = new System.Drawing.Point(33, 211);
            this.DtgFuncionarios.Name = "DtgFuncionarios";
            this.DtgFuncionarios.ReadOnly = true;
            this.DtgFuncionarios.RowTemplate.Height = 25;
            this.DtgFuncionarios.Size = new System.Drawing.Size(438, 217);
            this.DtgFuncionarios.TabIndex = 16;
            // 
            // TxtDataNascimento
            // 
            this.TxtDataNascimento.Location = new System.Drawing.Point(381, 91);
            this.TxtDataNascimento.Mask = "00/00/0000";
            this.TxtDataNascimento.Name = "TxtDataNascimento";
            this.TxtDataNascimento.Size = new System.Drawing.Size(82, 23);
            this.TxtDataNascimento.TabIndex = 17;
            this.TxtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // TxtDataContratado
            // 
            this.TxtDataContratado.Location = new System.Drawing.Point(381, 139);
            this.TxtDataContratado.Mask = "00/00/0000";
            this.TxtDataContratado.Name = "TxtDataContratado";
            this.TxtDataContratado.Size = new System.Drawing.Size(82, 23);
            this.TxtDataContratado.TabIndex = 18;
            this.TxtDataContratado.ValidatingType = typeof(System.DateTime);
            // 
            // Form_Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 440);
            this.Controls.Add(this.TxtDataContratado);
            this.Controls.Add(this.TxtDataNascimento);
            this.Controls.Add(this.DtgFuncionarios);
            this.Controls.Add(this.ComboStatus);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.LblDataContratado);
            this.Controls.Add(this.LblDataNascimento);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.LblTitulo);
            this.Name = "Form_Funcionarios";
            this.Text = "Cadastro de Funcionarios";
            this.Load += new System.EventHandler(this.Form_Funcionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblDataNascimento;
        private System.Windows.Forms.Label LblDataContratado;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox ComboStatus;
        private System.Windows.Forms.DataGridView DtgFuncionarios;
        private System.Windows.Forms.MaskedTextBox TxtDataNascimento;
        private System.Windows.Forms.MaskedTextBox TxtDataContratado;
    }
}
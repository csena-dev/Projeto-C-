
namespace ProjetoSistema.Formularios
{
    partial class Form_Hospede
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
            this.DatCheckin = new System.Windows.Forms.DateTimePicker();
            this.DatCheckout = new System.Windows.Forms.DateTimePicker();
            this.TxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.LblCpf = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.ComboQuarto = new System.Windows.Forms.ComboBox();
            this.LblQuarto = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblCheckin = new System.Windows.Forms.Label();
            this.LblCheckout = new System.Windows.Forms.Label();
            this.DtgHospedes = new System.Windows.Forms.DataGridView();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgHospedes)).BeginInit();
            this.SuspendLayout();
            // 
            // DatCheckin
            // 
            this.DatCheckin.Location = new System.Drawing.Point(318, 71);
            this.DatCheckin.Name = "DatCheckin";
            this.DatCheckin.Size = new System.Drawing.Size(252, 23);
            this.DatCheckin.TabIndex = 0;
            // 
            // DatCheckout
            // 
            this.DatCheckout.Location = new System.Drawing.Point(318, 103);
            this.DatCheckout.Name = "DatCheckout";
            this.DatCheckout.Size = new System.Drawing.Size(252, 23);
            this.DatCheckout.TabIndex = 1;
            // 
            // TxtCPF
            // 
            this.TxtCPF.Location = new System.Drawing.Point(81, 105);
            this.TxtCPF.Mask = "000.000.000-00";
            this.TxtCPF.Name = "TxtCPF";
            this.TxtCPF.Size = new System.Drawing.Size(100, 23);
            this.TxtCPF.TabIndex = 3;
            // 
            // LblCpf
            // 
            this.LblCpf.AutoSize = true;
            this.LblCpf.Location = new System.Drawing.Point(31, 109);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.Size = new System.Drawing.Size(31, 15);
            this.LblCpf.TabIndex = 4;
            this.LblCpf.Text = "CPF:";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(31, 79);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(43, 15);
            this.LblNome.TabIndex = 5;
            this.LblNome.Text = "Nome:";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(81, 74);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(100, 23);
            this.TxtNome.TabIndex = 6;
            // 
            // ComboQuarto
            // 
            this.ComboQuarto.FormattingEnabled = true;
            this.ComboQuarto.Location = new System.Drawing.Point(81, 134);
            this.ComboQuarto.Name = "ComboQuarto";
            this.ComboQuarto.Size = new System.Drawing.Size(100, 23);
            this.ComboQuarto.TabIndex = 7;
            // 
            // LblQuarto
            // 
            this.LblQuarto.AutoSize = true;
            this.LblQuarto.Location = new System.Drawing.Point(31, 137);
            this.LblQuarto.Name = "LblQuarto";
            this.LblQuarto.Size = new System.Drawing.Size(47, 15);
            this.LblQuarto.TabIndex = 8;
            this.LblQuarto.Text = "Quarto:";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTitulo.ForeColor = System.Drawing.Color.Black;
            this.LblTitulo.Location = new System.Drawing.Point(31, 25);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(181, 18);
            this.LblTitulo.TabIndex = 9;
            this.LblTitulo.Text = "Cadastro de Hospede";
            // 
            // LblCheckin
            // 
            this.LblCheckin.AutoSize = true;
            this.LblCheckin.Location = new System.Drawing.Point(257, 76);
            this.LblCheckin.Name = "LblCheckin";
            this.LblCheckin.Size = new System.Drawing.Size(55, 15);
            this.LblCheckin.TabIndex = 10;
            this.LblCheckin.Text = "Check-in";
            // 
            // LblCheckout
            // 
            this.LblCheckout.AutoSize = true;
            this.LblCheckout.Location = new System.Drawing.Point(249, 109);
            this.LblCheckout.Name = "LblCheckout";
            this.LblCheckout.Size = new System.Drawing.Size(63, 15);
            this.LblCheckout.TabIndex = 11;
            this.LblCheckout.Text = "Check-out";
            // 
            // DtgHospedes
            // 
            this.DtgHospedes.AllowUserToAddRows = false;
            this.DtgHospedes.AllowUserToDeleteRows = false;
            this.DtgHospedes.BackgroundColor = System.Drawing.Color.White;
            this.DtgHospedes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DtgHospedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgHospedes.GridColor = System.Drawing.Color.Gainsboro;
            this.DtgHospedes.Location = new System.Drawing.Point(31, 185);
            this.DtgHospedes.Name = "DtgHospedes";
            this.DtgHospedes.ReadOnly = true;
            this.DtgHospedes.RowTemplate.Height = 25;
            this.DtgHospedes.Size = new System.Drawing.Size(539, 166);
            this.DtgHospedes.TabIndex = 17;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(495, 137);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 18;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // Form_Hospede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 363);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.DtgHospedes);
            this.Controls.Add(this.LblCheckout);
            this.Controls.Add(this.LblCheckin);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.LblQuarto);
            this.Controls.Add(this.ComboQuarto);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.LblCpf);
            this.Controls.Add(this.TxtCPF);
            this.Controls.Add(this.DatCheckout);
            this.Controls.Add(this.DatCheckin);
            this.Name = "Form_Hospede";
            this.Text = "Cadastro de Hospede";
            this.Load += new System.EventHandler(this.Form_Hospede_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgHospedes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DatCheckin;
        private System.Windows.Forms.DateTimePicker DatCheckout;
        private System.Windows.Forms.MaskedTextBox TxtCPF;
        private System.Windows.Forms.Label LblCpf;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.ComboBox ComboQuarto;
        private System.Windows.Forms.Label LblQuarto;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblCheckin;
        private System.Windows.Forms.Label LblCheckout;
        private System.Windows.Forms.DataGridView DtgHospedes;
        private System.Windows.Forms.Button BtnCadastrar;
    }
}
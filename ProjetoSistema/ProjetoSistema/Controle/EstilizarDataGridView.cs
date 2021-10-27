using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ProjetoSistema.Controler
{
    class EstilizarDataGridView
    {
        public static void EstiloTituloColuna(DataGridView dtg, string[] nameHeader, bool[] colVisivel)
        {
            //Propriedades

            dtg.BorderStyle = BorderStyle.FixedSingle;
            //dtg.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtg.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            //dtg.DefaultCellStyle.SelectionBackColor = Color.DarkCyan;
           //dtg.BackgroundColor = Color.White;

            dtg.EnableHeadersVisualStyles = false;
            dtg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //dtg.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            //dtg.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //dtg.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 9, FontStyle.Bold);
            //dtg.DefaultCellStyle.Font = new Font("Poppins", 8);
            dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            // dtg.FirstDisplayedScrollingColumnIndex = dtg.RowCount - 1;

            //if (dtg.Name == "DtgUsuarios")
            //{
            //    dtg.Columns[0].Width = 45;  //ID
            //    dtg.Columns[1].Width = 150; // Nome
            //    dtg.Columns[2].Width = 80;  //Login
            //    dtg.Columns[3].Width = 100; //Area
            //    dtg.Columns[4].Width = 65;  //CPF
            //    dtg.Columns[5].Width = 120; //Email
            //}
            //else if (dtg.Name == "DtgHospede")
            //{
            //    dtg.Columns[0].Width = 45;  //ID Contrato
            //    dtg.Columns[1].Width = 150; // Nome
            //    dtg.Columns[2].Width = 65;  // CPF
            //    dtg.Columns[3].Width = 60;  // RG
            //    dtg.Columns[4].Width = 70;  //Cel 1
            //    dtg.Columns[5].Width = 70;  //Cel 2
            //    dtg.Columns[6].Width = 120; //Email

            //}

            dtg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg.MultiSelect = false;


            for (int i = 0; i < dtg.Columns.Count; i++)
            {
                dtg.Columns[i].HeaderText = nameHeader[i];// "Release Date";
                dtg.Columns[i].ReadOnly = true;
                dtg.Columns[i].Visible = colVisivel[i];


                // Alinha Celula
                if (i == 0)
                {
                    dtg.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dtg.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                else
                    dtg.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
        }
    }
}

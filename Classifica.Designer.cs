﻿
namespace Snake
{
    partial class Classifica
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbLevelSelected = new System.Windows.Forms.ComboBox();
            this.pnlSelezioneLivello = new System.Windows.Forms.Panel();
            this.lblSelezioneLivello = new System.Windows.Forms.Label();
            this.pnlPirntClassifica = new System.Windows.Forms.Panel();
            this.dataGridViewClassifica = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSelezioneLivello.SuspendLayout();
            this.pnlPirntClassifica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassifica)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbLevelSelected
            // 
            this.cmbLevelSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLevelSelected.FormattingEnabled = true;
            this.cmbLevelSelected.Location = new System.Drawing.Point(174, 38);
            this.cmbLevelSelected.Name = "cmbLevelSelected";
            this.cmbLevelSelected.Size = new System.Drawing.Size(121, 33);
            this.cmbLevelSelected.TabIndex = 0;
            this.cmbLevelSelected.SelectedIndexChanged += new System.EventHandler(this.cmbLevelSelected_SelectedIndexChanged);
            // 
            // pnlSelezioneLivello
            // 
            this.pnlSelezioneLivello.Controls.Add(this.lblSelezioneLivello);
            this.pnlSelezioneLivello.Controls.Add(this.cmbLevelSelected);
            this.pnlSelezioneLivello.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSelezioneLivello.Location = new System.Drawing.Point(0, 0);
            this.pnlSelezioneLivello.Name = "pnlSelezioneLivello";
            this.pnlSelezioneLivello.Size = new System.Drawing.Size(635, 100);
            this.pnlSelezioneLivello.TabIndex = 1;
            // 
            // lblSelezioneLivello
            // 
            this.lblSelezioneLivello.AutoSize = true;
            this.lblSelezioneLivello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelezioneLivello.Location = new System.Drawing.Point(34, 38);
            this.lblSelezioneLivello.Name = "lblSelezioneLivello";
            this.lblSelezioneLivello.Size = new System.Drawing.Size(134, 25);
            this.lblSelezioneLivello.TabIndex = 1;
            this.lblSelezioneLivello.Text = "Numero livello";
            // 
            // pnlPirntClassifica
            // 
            this.pnlPirntClassifica.Controls.Add(this.dataGridViewClassifica);
            this.pnlPirntClassifica.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPirntClassifica.Location = new System.Drawing.Point(0, 100);
            this.pnlPirntClassifica.Name = "pnlPirntClassifica";
            this.pnlPirntClassifica.Size = new System.Drawing.Size(635, 418);
            this.pnlPirntClassifica.TabIndex = 2;
            // 
            // dataGridViewClassifica
            // 
            this.dataGridViewClassifica.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewClassifica.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewClassifica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClassifica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewClassifica.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewClassifica.Name = "dataGridViewClassifica";
            this.dataGridViewClassifica.ReadOnly = true;
            this.dataGridViewClassifica.RowHeadersWidth = 51;
            this.dataGridViewClassifica.RowTemplate.Height = 24;
            this.dataGridViewClassifica.Size = new System.Drawing.Size(635, 415);
            this.dataGridViewClassifica.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Nickname";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 99;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Punteggio";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Classifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 516);
            this.Controls.Add(this.pnlPirntClassifica);
            this.Controls.Add(this.pnlSelezioneLivello);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Classifica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classifica";
            this.Load += new System.EventHandler(this.Classifica_Load);
            this.pnlSelezioneLivello.ResumeLayout(false);
            this.pnlSelezioneLivello.PerformLayout();
            this.pnlPirntClassifica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassifica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLevelSelected;
        private System.Windows.Forms.Panel pnlSelezioneLivello;
        private System.Windows.Forms.Label lblSelezioneLivello;
        private System.Windows.Forms.Panel pnlPirntClassifica;
        private System.Windows.Forms.DataGridView dataGridViewClassifica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
﻿
namespace Snake
{
    partial class frmMenu
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
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlDimensioneCampo = new System.Windows.Forms.Panel();
            this.lblDimensioneCampo = new System.Windows.Forms.Label();
            this.cmbDimensioneCampo = new System.Windows.Forms.ComboBox();
            this.pnlLivelli = new System.Windows.Forms.Panel();
            this.lblLivelli = new System.Windows.Forms.Label();
            this.lblPropreta = new System.Windows.Forms.Label();
            this.cmbVelocita = new System.Windows.Forms.ComboBox();
            this.pnlDimensioneCampo.SuspendLayout();
            this.pnlLivelli.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStart.Location = new System.Drawing.Point(0, 368);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(800, 82);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlDimensioneCampo
            // 
            this.pnlDimensioneCampo.Controls.Add(this.cmbVelocita);
            this.pnlDimensioneCampo.Controls.Add(this.lblPropreta);
            this.pnlDimensioneCampo.Controls.Add(this.lblDimensioneCampo);
            this.pnlDimensioneCampo.Controls.Add(this.cmbDimensioneCampo);
            this.pnlDimensioneCampo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDimensioneCampo.Location = new System.Drawing.Point(0, 0);
            this.pnlDimensioneCampo.Name = "pnlDimensioneCampo";
            this.pnlDimensioneCampo.Size = new System.Drawing.Size(206, 368);
            this.pnlDimensioneCampo.TabIndex = 1;
            // 
            // lblDimensioneCampo
            // 
            this.lblDimensioneCampo.AutoSize = true;
            this.lblDimensioneCampo.Location = new System.Drawing.Point(12, 9);
            this.lblDimensioneCampo.Name = "lblDimensioneCampo";
            this.lblDimensioneCampo.Size = new System.Drawing.Size(145, 20);
            this.lblDimensioneCampo.TabIndex = 2;
            this.lblDimensioneCampo.Text = "Dimensione campo";
            // 
            // cmbDimensioneCampo
            // 
            this.cmbDimensioneCampo.FormattingEnabled = true;
            this.cmbDimensioneCampo.Location = new System.Drawing.Point(16, 32);
            this.cmbDimensioneCampo.Name = "cmbDimensioneCampo";
            this.cmbDimensioneCampo.Size = new System.Drawing.Size(145, 28);
            this.cmbDimensioneCampo.TabIndex = 2;
            // 
            // pnlLivelli
            // 
            this.pnlLivelli.Controls.Add(this.lblLivelli);
            this.pnlLivelli.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLivelli.Location = new System.Drawing.Point(206, 0);
            this.pnlLivelli.Name = "pnlLivelli";
            this.pnlLivelli.Size = new System.Drawing.Size(200, 368);
            this.pnlLivelli.TabIndex = 2;
            // 
            // lblLivelli
            // 
            this.lblLivelli.AutoSize = true;
            this.lblLivelli.Location = new System.Drawing.Point(6, 9);
            this.lblLivelli.Name = "lblLivelli";
            this.lblLivelli.Size = new System.Drawing.Size(120, 20);
            this.lblLivelli.TabIndex = 3;
            this.lblLivelli.Text = "Selezione livello";
            // 
            // lblPropreta
            // 
            this.lblPropreta.AutoSize = true;
            this.lblPropreta.Location = new System.Drawing.Point(12, 73);
            this.lblPropreta.Name = "lblPropreta";
            this.lblPropreta.Size = new System.Drawing.Size(66, 20);
            this.lblPropreta.TabIndex = 3;
            this.lblPropreta.Text = "Velocità";
            // 
            // cmbVelocita
            // 
            this.cmbVelocita.FormattingEnabled = true;
            this.cmbVelocita.Location = new System.Drawing.Point(16, 96);
            this.cmbVelocita.Name = "cmbVelocita";
            this.cmbVelocita.Size = new System.Drawing.Size(145, 28);
            this.cmbVelocita.TabIndex = 4;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlLivelli);
            this.Controls.Add(this.pnlDimensioneCampo);
            this.Controls.Add(this.btnStart);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlDimensioneCampo.ResumeLayout(false);
            this.pnlDimensioneCampo.PerformLayout();
            this.pnlLivelli.ResumeLayout(false);
            this.pnlLivelli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlDimensioneCampo;
        private System.Windows.Forms.ComboBox cmbDimensioneCampo;
        private System.Windows.Forms.Label lblDimensioneCampo;
        private System.Windows.Forms.Panel pnlLivelli;
        private System.Windows.Forms.Label lblLivelli;
        private System.Windows.Forms.ComboBox cmbVelocita;
        private System.Windows.Forms.Label lblPropreta;
    }
}
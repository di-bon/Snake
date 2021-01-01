﻿
namespace Snake
{
    partial class Menu
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
            this.pnlVelocita = new System.Windows.Forms.Panel();
            this.trackBarVelocita = new System.Windows.Forms.TrackBar();
            this.lblVelocita = new System.Windows.Forms.Label();
            this.lblDimensioneCampo = new System.Windows.Forms.Label();
            this.pnlLivelli = new System.Windows.Forms.Panel();
            this.pnlNumeroGiocatori = new System.Windows.Forms.Panel();
            this.lblNumeroGiocatori = new System.Windows.Forms.Label();
            this.radioButtonMultiplayer = new System.Windows.Forms.RadioButton();
            this.radioButtonSinglePlayer = new System.Windows.Forms.RadioButton();
            this.pnlDimensioneCampo = new System.Windows.Forms.Panel();
            this.trackBarDimensioneCampo = new System.Windows.Forms.TrackBar();
            this.lblColorSnake = new System.Windows.Forms.Label();
            this.lblSelezionaLivello = new System.Windows.Forms.Label();
            this.pnlColors = new System.Windows.Forms.Panel();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.picRight1 = new System.Windows.Forms.PictureBox();
            this.picLeft1 = new System.Windows.Forms.PictureBox();
            this.picCenter = new System.Windows.Forms.PictureBox();
            this.pnlNickname = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.btnClassifica = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pnlVelocita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVelocita)).BeginInit();
            this.pnlLivelli.SuspendLayout();
            this.pnlNumeroGiocatori.SuspendLayout();
            this.pnlDimensioneCampo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDimensioneCampo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRight1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCenter)).BeginInit();
            this.pnlNickname.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(0, 962);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(982, 82);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlVelocita
            // 
            this.pnlVelocita.Controls.Add(this.trackBarVelocita);
            this.pnlVelocita.Controls.Add(this.lblVelocita);
            this.pnlVelocita.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlVelocita.Location = new System.Drawing.Point(0, 712);
            this.pnlVelocita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlVelocita.Name = "pnlVelocita";
            this.pnlVelocita.Size = new System.Drawing.Size(982, 125);
            this.pnlVelocita.TabIndex = 1;
            // 
            // trackBarVelocita
            // 
            this.trackBarVelocita.LargeChange = 1;
            this.trackBarVelocita.Location = new System.Drawing.Point(105, 55);
            this.trackBarVelocita.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.trackBarVelocita.Maximum = 2;
            this.trackBarVelocita.Name = "trackBarVelocita";
            this.trackBarVelocita.Size = new System.Drawing.Size(206, 69);
            this.trackBarVelocita.TabIndex = 1;
            this.trackBarVelocita.Value = 1;
            this.trackBarVelocita.Scroll += new System.EventHandler(this.trackBarVelocità_Scroll);
            // 
            // lblVelocita
            // 
            this.lblVelocita.AutoSize = true;
            this.lblVelocita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelocita.Location = new System.Drawing.Point(22, 72);
            this.lblVelocita.Name = "lblVelocita";
            this.lblVelocita.Size = new System.Drawing.Size(99, 29);
            this.lblVelocita.TabIndex = 3;
            this.lblVelocita.Text = "Velocità";
            // 
            // lblDimensioneCampo
            // 
            this.lblDimensioneCampo.AutoSize = true;
            this.lblDimensioneCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimensioneCampo.Location = new System.Drawing.Point(218, 45);
            this.lblDimensioneCampo.Name = "lblDimensioneCampo";
            this.lblDimensioneCampo.Size = new System.Drawing.Size(221, 29);
            this.lblDimensioneCampo.TabIndex = 2;
            this.lblDimensioneCampo.Text = "Dimensione campo";
            // 
            // pnlLivelli
            // 
            this.pnlLivelli.Controls.Add(this.pnlNumeroGiocatori);
            this.pnlLivelli.Controls.Add(this.pnlDimensioneCampo);
            this.pnlLivelli.Controls.Add(this.lblColorSnake);
            this.pnlLivelli.Controls.Add(this.lblSelezionaLivello);
            this.pnlLivelli.Controls.Add(this.pnlColors);
            this.pnlLivelli.Controls.Add(this.btnLeft);
            this.pnlLivelli.Controls.Add(this.btnRight);
            this.pnlLivelli.Controls.Add(this.pnlVelocita);
            this.pnlLivelli.Controls.Add(this.picRight1);
            this.pnlLivelli.Controls.Add(this.picLeft1);
            this.pnlLivelli.Controls.Add(this.picCenter);
            this.pnlLivelli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLivelli.Location = new System.Drawing.Point(0, 0);
            this.pnlLivelli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLivelli.Name = "pnlLivelli";
            this.pnlLivelli.Size = new System.Drawing.Size(982, 837);
            this.pnlLivelli.TabIndex = 2;
            // 
            // pnlNumeroGiocatori
            // 
            this.pnlNumeroGiocatori.Controls.Add(this.lblNumeroGiocatori);
            this.pnlNumeroGiocatori.Controls.Add(this.radioButtonMultiplayer);
            this.pnlNumeroGiocatori.Controls.Add(this.radioButtonSinglePlayer);
            this.pnlNumeroGiocatori.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNumeroGiocatori.Location = new System.Drawing.Point(0, 468);
            this.pnlNumeroGiocatori.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlNumeroGiocatori.Name = "pnlNumeroGiocatori";
            this.pnlNumeroGiocatori.Size = new System.Drawing.Size(982, 119);
            this.pnlNumeroGiocatori.TabIndex = 18;
            // 
            // lblNumeroGiocatori
            // 
            this.lblNumeroGiocatori.AutoSize = true;
            this.lblNumeroGiocatori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroGiocatori.Location = new System.Drawing.Point(90, 40);
            this.lblNumeroGiocatori.Name = "lblNumeroGiocatori";
            this.lblNumeroGiocatori.Size = new System.Drawing.Size(197, 29);
            this.lblNumeroGiocatori.TabIndex = 18;
            this.lblNumeroGiocatori.Text = "Modalità di gioco";
            // 
            // radioButtonMultiplayer
            // 
            this.radioButtonMultiplayer.AutoSize = true;
            this.radioButtonMultiplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMultiplayer.Location = new System.Drawing.Point(561, 54);
            this.radioButtonMultiplayer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.radioButtonMultiplayer.Name = "radioButtonMultiplayer";
            this.radioButtonMultiplayer.Size = new System.Drawing.Size(155, 33);
            this.radioButtonMultiplayer.TabIndex = 17;
            this.radioButtonMultiplayer.TabStop = true;
            this.radioButtonMultiplayer.Text = "Multiplayer";
            this.radioButtonMultiplayer.UseVisualStyleBackColor = true;
            // 
            // radioButtonSinglePlayer
            // 
            this.radioButtonSinglePlayer.AutoSize = true;
            this.radioButtonSinglePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSinglePlayer.Location = new System.Drawing.Point(372, 54);
            this.radioButtonSinglePlayer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.radioButtonSinglePlayer.Name = "radioButtonSinglePlayer";
            this.radioButtonSinglePlayer.Size = new System.Drawing.Size(173, 33);
            this.radioButtonSinglePlayer.TabIndex = 0;
            this.radioButtonSinglePlayer.TabStop = true;
            this.radioButtonSinglePlayer.Text = "Singleplayer";
            this.radioButtonSinglePlayer.UseVisualStyleBackColor = true;
            // 
            // pnlDimensioneCampo
            // 
            this.pnlDimensioneCampo.Controls.Add(this.trackBarDimensioneCampo);
            this.pnlDimensioneCampo.Controls.Add(this.lblDimensioneCampo);
            this.pnlDimensioneCampo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDimensioneCampo.Location = new System.Drawing.Point(0, 587);
            this.pnlDimensioneCampo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlDimensioneCampo.Name = "pnlDimensioneCampo";
            this.pnlDimensioneCampo.Size = new System.Drawing.Size(982, 125);
            this.pnlDimensioneCampo.TabIndex = 16;
            // 
            // trackBarDimensioneCampo
            // 
            this.trackBarDimensioneCampo.LargeChange = 1;
            this.trackBarDimensioneCampo.Location = new System.Drawing.Point(368, 29);
            this.trackBarDimensioneCampo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.trackBarDimensioneCampo.Maximum = 2;
            this.trackBarDimensioneCampo.Name = "trackBarDimensioneCampo";
            this.trackBarDimensioneCampo.Size = new System.Drawing.Size(236, 69);
            this.trackBarDimensioneCampo.TabIndex = 1;
            this.trackBarDimensioneCampo.Value = 1;
            this.trackBarDimensioneCampo.Scroll += new System.EventHandler(this.trackBarDimensioneCampo_Scroll);
            // 
            // lblColorSnake
            // 
            this.lblColorSnake.AutoSize = true;
            this.lblColorSnake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorSnake.Location = new System.Drawing.Point(406, 205);
            this.lblColorSnake.Name = "lblColorSnake";
            this.lblColorSnake.Size = new System.Drawing.Size(353, 29);
            this.lblColorSnake.TabIndex = 15;
            this.lblColorSnake.Text = "Seleziona il colore del serpente";
            // 
            // lblSelezionaLivello
            // 
            this.lblSelezionaLivello.AutoSize = true;
            this.lblSelezionaLivello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelezionaLivello.Location = new System.Drawing.Point(374, 105);
            this.lblSelezionaLivello.Name = "lblSelezionaLivello";
            this.lblSelezionaLivello.Size = new System.Drawing.Size(221, 29);
            this.lblSelezionaLivello.TabIndex = 14;
            this.lblSelezionaLivello.Text = "Seleziona un livello";
            // 
            // pnlColors
            // 
            this.pnlColors.Location = new System.Drawing.Point(326, 252);
            this.pnlColors.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlColors.Name = "pnlColors";
            this.pnlColors.Size = new System.Drawing.Size(252, 300);
            this.pnlColors.TabIndex = 13;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(46, 132);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(84, 29);
            this.btnLeft.TabIndex = 9;
            this.btnLeft.Text = "button2";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(687, 132);
            this.btnRight.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(84, 29);
            this.btnRight.TabIndex = 8;
            this.btnRight.Text = "button1";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // picRight1
            // 
            this.picRight1.Location = new System.Drawing.Point(466, 132);
            this.picRight1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.picRight1.Name = "picRight1";
            this.picRight1.Size = new System.Drawing.Size(112, 62);
            this.picRight1.TabIndex = 7;
            this.picRight1.TabStop = false;
            // 
            // picLeft1
            // 
            this.picLeft1.Location = new System.Drawing.Point(226, 132);
            this.picLeft1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.picLeft1.Name = "picLeft1";
            this.picLeft1.Size = new System.Drawing.Size(112, 62);
            this.picLeft1.TabIndex = 6;
            this.picLeft1.TabStop = false;
            // 
            // picCenter
            // 
            this.picCenter.Location = new System.Drawing.Point(346, 132);
            this.picCenter.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.picCenter.Name = "picCenter";
            this.picCenter.Size = new System.Drawing.Size(112, 62);
            this.picCenter.TabIndex = 5;
            this.picCenter.TabStop = false;
            // 
            // pnlNickname
            // 
            this.pnlNickname.Controls.Add(this.txtNome);
            this.pnlNickname.Controls.Add(this.lblPlayer2);
            this.pnlNickname.Controls.Add(this.txtPlayer2);
            this.pnlNickname.Controls.Add(this.lblPlayer1);
            this.pnlNickname.Controls.Add(this.lblNome);
            this.pnlNickname.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNickname.Location = new System.Drawing.Point(0, 837);
            this.pnlNickname.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlNickname.Name = "pnlNickname";
            this.pnlNickname.Size = new System.Drawing.Size(982, 125);
            this.pnlNickname.TabIndex = 12;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.Location = new System.Drawing.Point(412, 63);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(44, 26);
            this.txtNome.TabIndex = 15;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(784, 12);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(92, 20);
            this.lblPlayer2.TabIndex = 14;
            this.lblPlayer2.Text = "Giocatore 2";
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Location = new System.Drawing.Point(788, 51);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(120, 26);
            this.txtPlayer2.TabIndex = 11;
            this.txtPlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(421, 12);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(92, 20);
            this.lblPlayer1.TabIndex = 12;
            this.lblPlayer1.Text = "Giocatore 1";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(20, 63);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(268, 29);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Inserisci il tuo nickname";
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.btnClassifica);
            this.pnlSettings.Controls.Add(this.btnSettings);
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSettings.Location = new System.Drawing.Point(0, 0);
            this.pnlSettings.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(982, 85);
            this.pnlSettings.TabIndex = 13;
            // 
            // btnClassifica
            // 
            this.btnClassifica.Location = new System.Drawing.Point(0, 0);
            this.btnClassifica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClassifica.Name = "btnClassifica";
            this.btnClassifica.Size = new System.Drawing.Size(94, 85);
            this.btnClassifica.TabIndex = 6;
            this.btnClassifica.Text = "Classifica";
            this.btnClassifica.UseVisualStyleBackColor = true;
            this.btnClassifica.Click += new System.EventHandler(this.btnClassifica_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSettings.Location = new System.Drawing.Point(898, 0);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(84, 85);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 1044);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.pnlLivelli);
            this.Controls.Add(this.pnlNickname);
            this.Controls.Add(this.btnStart);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlVelocita.ResumeLayout(false);
            this.pnlVelocita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVelocita)).EndInit();
            this.pnlLivelli.ResumeLayout(false);
            this.pnlLivelli.PerformLayout();
            this.pnlNumeroGiocatori.ResumeLayout(false);
            this.pnlNumeroGiocatori.PerformLayout();
            this.pnlDimensioneCampo.ResumeLayout(false);
            this.pnlDimensioneCampo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDimensioneCampo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRight1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCenter)).EndInit();
            this.pnlNickname.ResumeLayout(false);
            this.pnlNickname.PerformLayout();
            this.pnlSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlVelocita;
        private System.Windows.Forms.Label lblDimensioneCampo;
        private System.Windows.Forms.Panel pnlLivelli;
        private System.Windows.Forms.Label lblVelocita;
        private System.Windows.Forms.PictureBox picRight1;
        private System.Windows.Forms.PictureBox picLeft1;
        private System.Windows.Forms.PictureBox picCenter;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel pnlNickname;
        private System.Windows.Forms.Panel pnlColors;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnClassifica;
        private System.Windows.Forms.Label lblSelezionaLivello;
        private System.Windows.Forms.Label lblColorSnake;
        private System.Windows.Forms.TrackBar trackBarVelocita;
        private System.Windows.Forms.TrackBar trackBarDimensioneCampo;
        private System.Windows.Forms.Panel pnlDimensioneCampo;
        private System.Windows.Forms.RadioButton radioButtonMultiplayer;
        private System.Windows.Forms.RadioButton radioButtonSinglePlayer;
        private System.Windows.Forms.Panel pnlNumeroGiocatori;
        private System.Windows.Forms.Label lblNumeroGiocatori;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.TextBox txtNome;
    }
}
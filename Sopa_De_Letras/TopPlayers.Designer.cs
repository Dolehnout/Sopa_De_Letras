namespace Sopa_De_Letras
{
    partial class TopPlayers
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.metroSetTabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
            this.metroLblRanking = new MetroSet_UI.Controls.MetroSetListBox();
            this.metroBtnRegresar = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 41);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(231, 380);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Jugador";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 41);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(404, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tiempo";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Location = new System.Drawing.Point(4, 41);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(404, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Puntuación";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // metroSetTabControl1
            // 
            this.metroSetTabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.metroSetTabControl1.AnimateTime = 200;
            this.metroSetTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroSetTabControl1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetTabControl1.Controls.Add(this.tabPage1);
            this.metroSetTabControl1.Controls.Add(this.tabPage2);
            this.metroSetTabControl1.Controls.Add(this.tabPage3);
            this.metroSetTabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetTabControl1.IsDerivedStyle = false;
            this.metroSetTabControl1.ItemSize = new System.Drawing.Size(160, 37);
            this.metroSetTabControl1.Location = new System.Drawing.Point(314, 10);
            this.metroSetTabControl1.Name = "metroSetTabControl1";
            this.metroSetTabControl1.SelectedIndex = 2;
            this.metroSetTabControl1.SelectedTextColor = System.Drawing.Color.White;
            this.metroSetTabControl1.Size = new System.Drawing.Size(239, 425);
            this.metroSetTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl1.Speed = 100;
            this.metroSetTabControl1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetTabControl1.StyleManager = null;
            this.metroSetTabControl1.TabIndex = 3;
            this.metroSetTabControl1.TabStop = false;
            this.metroSetTabControl1.TabStyle = MetroSet_UI.Enums.TabStyle.Style2;
            this.metroSetTabControl1.ThemeAuthor = "Narwin";
            this.metroSetTabControl1.ThemeName = "MetroDark";
            this.metroSetTabControl1.UnselectedTextColor = System.Drawing.Color.White;
            this.metroSetTabControl1.UseAnimation = false;
            // 
            // metroLblRanking
            // 
            this.metroLblRanking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroLblRanking.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroLblRanking.DisabledBackColor = System.Drawing.Color.White;
            this.metroLblRanking.DisabledForeColor = System.Drawing.Color.White;
            this.metroLblRanking.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLblRanking.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.metroLblRanking.HoveredItemColor = System.Drawing.Color.DimGray;
            this.metroLblRanking.IsDerivedStyle = true;
            this.metroLblRanking.ItemHeight = 30;
            this.metroLblRanking.Location = new System.Drawing.Point(221, 52);
            this.metroLblRanking.MultiSelect = false;
            this.metroLblRanking.Name = "metroLblRanking";
            this.metroLblRanking.SelectedIndex = -1;
            this.metroLblRanking.SelectedItem = null;
            this.metroLblRanking.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroLblRanking.SelectedItemColor = System.Drawing.Color.White;
            this.metroLblRanking.SelectedText = null;
            this.metroLblRanking.SelectedValue = null;
            this.metroLblRanking.ShowBorder = true;
            this.metroLblRanking.ShowScrollBar = true;
            this.metroLblRanking.Size = new System.Drawing.Size(412, 383);
            this.metroLblRanking.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroLblRanking.StyleManager = null;
            this.metroLblRanking.TabIndex = 3;
            this.metroLblRanking.ThemeAuthor = "Narwin";
            this.metroLblRanking.ThemeName = "MetroDark";
            // 
            // metroBtnRegresar
            // 
            this.metroBtnRegresar.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroBtnRegresar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroBtnRegresar.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroBtnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroBtnRegresar.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroBtnRegresar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroBtnRegresar.HoverTextColor = System.Drawing.Color.White;
            this.metroBtnRegresar.IsDerivedStyle = true;
            this.metroBtnRegresar.Location = new System.Drawing.Point(29, 408);
            this.metroBtnRegresar.Name = "metroBtnRegresar";
            this.metroBtnRegresar.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroBtnRegresar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroBtnRegresar.NormalTextColor = System.Drawing.Color.White;
            this.metroBtnRegresar.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroBtnRegresar.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroBtnRegresar.PressTextColor = System.Drawing.Color.White;
            this.metroBtnRegresar.Size = new System.Drawing.Size(75, 23);
            this.metroBtnRegresar.Style = MetroSet_UI.Enums.Style.Light;
            this.metroBtnRegresar.StyleManager = null;
            this.metroBtnRegresar.TabIndex = 4;
            this.metroBtnRegresar.Text = "Regresar";
            this.metroBtnRegresar.ThemeAuthor = "Narwin";
            this.metroBtnRegresar.ThemeName = "MetroLite";
            this.metroBtnRegresar.Click += new System.EventHandler(this.metroBtnRegresar_Click);
            // 
            // TopPlayers
            // 
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderThickness = 3F;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.metroBtnRegresar);
            this.Controls.Add(this.metroLblRanking);
            this.Controls.Add(this.metroSetTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TopPlayers";
            this.Padding = new System.Windows.Forms.Padding(12, 90, 12, 12);
            this.ShowBorder = true;
            this.ShowLeftRect = false;
            this.ShowTitle = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.Text = "TOP DE JUGADORES";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.UseSlideAnimation = true;
            this.Load += new System.EventHandler(this.TopPlayers_Load);
            this.metroSetTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MetroSet_UI.Controls.MetroSetListBox metroLblRanking;
        private MetroSet_UI.Controls.MetroSetButton metroBtnRegresar;
    }
}
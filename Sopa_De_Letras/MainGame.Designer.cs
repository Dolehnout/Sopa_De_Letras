namespace Sopa_De_Letras
{
    partial class MainGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
            this.Sopa = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblPuntuacion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGanaste = new System.Windows.Forms.Label();
            this.lblPalabrasBuscar = new System.Windows.Forms.Label();
            this.lblPuntuacionTotal = new System.Windows.Forms.Label();
            this.lblTiempoTotal = new System.Windows.Forms.Label();
            this.metroRegresar = new MetroSet_UI.Controls.MetroSetButton();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Sopa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Sopa
            // 
            this.Sopa.AllowUserToAddRows = false;
            this.Sopa.AllowUserToDeleteRows = false;
            this.Sopa.AllowUserToResizeColumns = false;
            this.Sopa.AllowUserToResizeRows = false;
            this.Sopa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Sopa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Sopa.ColumnHeadersVisible = false;
            this.Sopa.EnableHeadersVisualStyles = false;
            this.Sopa.Location = new System.Drawing.Point(248, 104);
            this.Sopa.Name = "Sopa";
            this.Sopa.ReadOnly = true;
            this.Sopa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Sopa.RowHeadersVisible = false;
            this.Sopa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Sopa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Sopa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Sopa.ShowCellErrors = false;
            this.Sopa.ShowCellToolTips = false;
            this.Sopa.ShowEditingIcon = false;
            this.Sopa.ShowRowErrors = false;
            this.Sopa.Size = new System.Drawing.Size(452, 332);
            this.Sopa.TabIndex = 0;
            this.Sopa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Sopa_CellClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 1;
            // 
            // lblPuntuacion
            // 
            this.lblPuntuacion.AutoSize = true;
            this.lblPuntuacion.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblPuntuacion.Location = new System.Drawing.Point(422, 70);
            this.lblPuntuacion.Name = "lblPuntuacion";
            this.lblPuntuacion.Size = new System.Drawing.Size(152, 18);
            this.lblPuntuacion.TabIndex = 3;
            this.lblPuntuacion.Text = "Su puntuacion: 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::Sopa_De_Letras.Properties.Resources.confetti_25;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 485);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // lblGanaste
            // 
            this.lblGanaste.AutoSize = true;
            this.lblGanaste.Enabled = false;
            this.lblGanaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanaste.Location = new System.Drawing.Point(235, 200);
            this.lblGanaste.Name = "lblGanaste";
            this.lblGanaste.Size = new System.Drawing.Size(339, 73);
            this.lblGanaste.TabIndex = 5;
            this.lblGanaste.Text = "GANASTE";
            this.lblGanaste.Visible = false;
            // 
            // lblPalabrasBuscar
            // 
            this.lblPalabrasBuscar.AutoSize = true;
            this.lblPalabrasBuscar.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabrasBuscar.Location = new System.Drawing.Point(12, 84);
            this.lblPalabrasBuscar.Name = "lblPalabrasBuscar";
            this.lblPalabrasBuscar.Size = new System.Drawing.Size(151, 15);
            this.lblPalabrasBuscar.TabIndex = 6;
            this.lblPalabrasBuscar.Text = "Palabras a buscar:";
            // 
            // lblPuntuacionTotal
            // 
            this.lblPuntuacionTotal.AutoSize = true;
            this.lblPuntuacionTotal.Enabled = false;
            this.lblPuntuacionTotal.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntuacionTotal.Location = new System.Drawing.Point(343, 273);
            this.lblPuntuacionTotal.Name = "lblPuntuacionTotal";
            this.lblPuntuacionTotal.Size = new System.Drawing.Size(167, 15);
            this.lblPuntuacionTotal.TabIndex = 5;
            this.lblPuntuacionTotal.Text = "Su puntuación total:";
            this.lblPuntuacionTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPuntuacionTotal.Visible = false;
            // 
            // lblTiempoTotal
            // 
            this.lblTiempoTotal.AutoSize = true;
            this.lblTiempoTotal.Enabled = false;
            this.lblTiempoTotal.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoTotal.Location = new System.Drawing.Point(358, 330);
            this.lblTiempoTotal.Name = "lblTiempoTotal";
            this.lblTiempoTotal.Size = new System.Drawing.Size(135, 15);
            this.lblTiempoTotal.TabIndex = 5;
            this.lblTiempoTotal.Text = "Su tiempo total:";
            this.lblTiempoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTiempoTotal.Visible = false;
            // 
            // metroRegresar
            // 
            this.metroRegresar.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroRegresar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroRegresar.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroRegresar.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroRegresar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroRegresar.HoverTextColor = System.Drawing.Color.White;
            this.metroRegresar.IsDerivedStyle = true;
            this.metroRegresar.Location = new System.Drawing.Point(15, 433);
            this.metroRegresar.Name = "metroRegresar";
            this.metroRegresar.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroRegresar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroRegresar.NormalTextColor = System.Drawing.Color.White;
            this.metroRegresar.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroRegresar.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroRegresar.PressTextColor = System.Drawing.Color.White;
            this.metroRegresar.Size = new System.Drawing.Size(75, 23);
            this.metroRegresar.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroRegresar.StyleManager = null;
            this.metroRegresar.TabIndex = 7;
            this.metroRegresar.Text = "Regresar";
            this.metroRegresar.ThemeAuthor = "Narwin";
            this.metroRegresar.ThemeName = "MetroDark";
            this.metroRegresar.Click += new System.EventHandler(this.metroRegresar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(38, 273);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 18);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Jugador:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 483);
            this.Controls.Add(this.metroRegresar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblPalabrasBuscar);
            this.Controls.Add(this.lblTiempoTotal);
            this.Controls.Add(this.lblPuntuacionTotal);
            this.Controls.Add(this.lblGanaste);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPuntuacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sopa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sopa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Sopa;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPuntuacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGanaste;
        private System.Windows.Forms.Label lblPalabrasBuscar;
        private System.Windows.Forms.Label lblPuntuacionTotal;
        private System.Windows.Forms.Label lblTiempoTotal;
        private MetroSet_UI.Controls.MetroSetButton metroRegresar;
        private System.Windows.Forms.Label lblNombre;
    }
}
namespace Sopa_De_Letras
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.txtRegistro = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnRegistro = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.switchDarkMode = new MaterialSkin.Controls.MaterialSwitch();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDark = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRegistro
            // 
            this.txtRegistro.AnimateReadOnly = false;
            this.txtRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRegistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRegistro.Depth = 0;
            this.txtRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRegistro.HideSelection = true;
            this.txtRegistro.LeadingIcon = null;
            this.txtRegistro.Location = new System.Drawing.Point(441, 172);
            this.txtRegistro.MaxLength = 15;
            this.txtRegistro.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.PasswordChar = '\0';
            this.txtRegistro.PrefixSuffixText = null;
            this.txtRegistro.ReadOnly = false;
            this.txtRegistro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRegistro.SelectedText = "";
            this.txtRegistro.SelectionLength = 0;
            this.txtRegistro.SelectionStart = 0;
            this.txtRegistro.ShortcutsEnabled = true;
            this.txtRegistro.Size = new System.Drawing.Size(250, 48);
            this.txtRegistro.TabIndex = 0;
            this.txtRegistro.TabStop = false;
            this.txtRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRegistro.TrailingIcon = null;
            this.txtRegistro.UseSystemPasswordChar = false;
            // 
            // btnRegistro
            // 
            this.btnRegistro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistro.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegistro.Depth = 0;
            this.btnRegistro.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistro.HighEmphasis = true;
            this.btnRegistro.Icon = null;
            this.btnRegistro.Location = new System.Drawing.Point(491, 253);
            this.btnRegistro.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegistro.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegistro.Size = new System.Drawing.Size(116, 36);
            this.btnRegistro.TabIndex = 1;
            this.btnRegistro.Text = "Registrarse";
            this.btnRegistro.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegistro.UseAccentColor = false;
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(443, 148);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(134, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Ingrese su usuario:";
            // 
            // switchDarkMode
            // 
            this.switchDarkMode.AutoSize = true;
            this.switchDarkMode.Depth = 0;
            this.switchDarkMode.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.switchDarkMode.Location = new System.Drawing.Point(3, 72);
            this.switchDarkMode.Margin = new System.Windows.Forms.Padding(0);
            this.switchDarkMode.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchDarkMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchDarkMode.Name = "switchDarkMode";
            this.switchDarkMode.Ripple = true;
            this.switchDarkMode.Size = new System.Drawing.Size(58, 37);
            this.switchDarkMode.TabIndex = 4;
            this.switchDarkMode.UseVisualStyleBackColor = true;
            this.switchDarkMode.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(173, 308);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(434, 122);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxDark
            // 
            this.pictureBoxDark.Image = global::Sopa_De_Letras.Properties.Resources.sun;
            this.pictureBoxDark.Location = new System.Drawing.Point(66, 77);
            this.pictureBoxDark.Name = "pictureBoxDark";
            this.pictureBoxDark.Size = new System.Drawing.Size(24, 25);
            this.pictureBoxDark.TabIndex = 5;
            this.pictureBoxDark.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.ErrorImage = null;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(121, 147);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(157, 142);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 2;
            this.PictureBox1.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBoxDark);
            this.Controls.Add(this.switchDarkMode);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.txtRegistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regístrate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtRegistro;
        private MaterialSkin.Controls.MaterialButton btnRegistro;
        private System.Windows.Forms.PictureBox PictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSwitch switchDarkMode;
        private System.Windows.Forms.PictureBox pictureBoxDark;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
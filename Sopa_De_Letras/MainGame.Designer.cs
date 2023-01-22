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
            this.Sopa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Sopa)).BeginInit();
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
            this.Sopa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Sopa.ShowCellErrors = false;
            this.Sopa.ShowCellToolTips = false;
            this.Sopa.ShowEditingIcon = false;
            this.Sopa.ShowRowErrors = false;
            this.Sopa.Size = new System.Drawing.Size(455, 337);
            this.Sopa.TabIndex = 0;
            this.Sopa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Sopa_CellClick);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 483);
            this.Controls.Add(this.Sopa);
            this.Name = "MainGame";
            this.Text = "MainGame";
            ((System.ComponentModel.ISupportInitialize)(this.Sopa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Sopa;
    }
}
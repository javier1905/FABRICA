namespace CapaPresentacion
{
    partial class FormBASEtradicional
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
            this.pn_principal = new System.Windows.Forms.Panel();
            this.pn_barraTitulo = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pn_principal.SuspendLayout();
            this.pn_barraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_principal
            // 
            this.pn_principal.BackColor = System.Drawing.Color.Transparent;
            this.pn_principal.Controls.Add(this.pn_barraTitulo);
            this.pn_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_principal.Location = new System.Drawing.Point(0, 0);
            this.pn_principal.Name = "pn_principal";
            this.pn_principal.Size = new System.Drawing.Size(824, 471);
            this.pn_principal.TabIndex = 1;
            // 
            // pn_barraTitulo
            // 
            this.pn_barraTitulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pn_barraTitulo.Controls.Add(this.lbl_titulo);
            this.pn_barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pn_barraTitulo.Name = "pn_barraTitulo";
            this.pn_barraTitulo.Size = new System.Drawing.Size(824, 37);
            this.pn_barraTitulo.TabIndex = 0;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(3, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(91, 19);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "E.M.Sturam";
            // 
            // FormBASEtradicional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(824, 471);
            this.Controls.Add(this.pn_principal);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormBASEtradicional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pn_principal.ResumeLayout(false);
            this.pn_barraTitulo.ResumeLayout(false);
            this.pn_barraTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_barraTitulo;
        protected System.Windows.Forms.Panel pn_principal;
        private System.Windows.Forms.Label lbl_titulo;
    }
}
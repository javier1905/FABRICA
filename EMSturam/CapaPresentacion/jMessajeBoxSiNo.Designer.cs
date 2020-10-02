namespace CapaPresentacion
{
    partial class jMessajeBoxSiNo
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
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.pn_barraTitulo = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_si = new System.Windows.Forms.Button();
            this.btn_no = new System.Windows.Forms.Button();
            this.lbl_mensaje = new System.Windows.Forms.Label();
            this.pn_barraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lineShape3
            // 
            this.lineShape3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape3.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 357;
            this.lineShape3.X2 = 357;
            this.lineShape3.Y1 = 40;
            this.lineShape3.Y2 = 148;
            // 
            // lineShape2
            // 
            this.lineShape2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape2.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 0;
            this.lineShape2.X2 = 358;
            this.lineShape2.Y1 = 147;
            this.lineShape2.Y2 = 147;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 0;
            this.lineShape1.Y1 = 40;
            this.lineShape1.Y2 = 148;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lineShape2,
            this.lineShape3});
            this.shapeContainer1.Size = new System.Drawing.Size(358, 148);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // pn_barraTitulo
            // 
            this.pn_barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.pn_barraTitulo.Controls.Add(this.lbl_titulo);
            this.pn_barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pn_barraTitulo.Name = "pn_barraTitulo";
            this.pn_barraTitulo.Size = new System.Drawing.Size(358, 40);
            this.pn_barraTitulo.TabIndex = 1;
            this.pn_barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_barraTitulo_MouseDown);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(1, 11);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(51, 19);
            this.lbl_titulo.TabIndex = 6;
            this.lbl_titulo.Text = "label2";
            // 
            // btn_si
            // 
            this.btn_si.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.btn_si.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btn_si.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btn_si.FlatAppearance.BorderSize = 0;
            this.btn_si.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_si.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_si.Location = new System.Drawing.Point(12, 90);
            this.btn_si.Name = "btn_si";
            this.btn_si.Size = new System.Drawing.Size(150, 38);
            this.btn_si.TabIndex = 3;
            this.btn_si.Text = "SI";
            this.btn_si.UseVisualStyleBackColor = false;
            this.btn_si.Click += new System.EventHandler(this.btn_si_Click);
            // 
            // btn_no
            // 
            this.btn_no.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.btn_no.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_no.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btn_no.FlatAppearance.BorderSize = 0;
            this.btn_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_no.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_no.Location = new System.Drawing.Point(196, 90);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(150, 38);
            this.btn_no.TabIndex = 4;
            this.btn_no.Text = "NO";
            this.btn_no.UseVisualStyleBackColor = false;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // lbl_mensaje
            // 
            this.lbl_mensaje.AutoSize = true;
            this.lbl_mensaje.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mensaje.Location = new System.Drawing.Point(12, 52);
            this.lbl_mensaje.Name = "lbl_mensaje";
            this.lbl_mensaje.Size = new System.Drawing.Size(51, 19);
            this.lbl_mensaje.TabIndex = 5;
            this.lbl_mensaje.Text = "label1";
            // 
            // jMessajeBoxSiNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 148);
            this.Controls.Add(this.lbl_mensaje);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_si);
            this.Controls.Add(this.pn_barraTitulo);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "jMessajeBoxSiNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "jMessajeBoxSiNo";
            this.pn_barraTitulo.ResumeLayout(false);
            this.pn_barraTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Panel pn_barraTitulo;
        private System.Windows.Forms.Button btn_si;
        private System.Windows.Forms.Button btn_no;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_mensaje;
    }
}
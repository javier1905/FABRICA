namespace CapaPresentacion
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pn_contenedosTHIS = new System.Windows.Forms.Panel();
            this.pn_contenedorFILL = new System.Windows.Forms.Panel();
            this.pn_barraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.ln_usuario = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_usuario = new CapaLogica.JTextBox();
            this.txt_pass = new CapaLogica.JTextBox();
            this.pn_contenedosTHIS.SuspendLayout();
            this.pn_barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_contenedosTHIS
            // 
            this.pn_contenedosTHIS.BackColor = System.Drawing.SystemColors.Window;
            this.pn_contenedosTHIS.Controls.Add(this.pn_contenedorFILL);
            this.pn_contenedosTHIS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_contenedosTHIS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pn_contenedosTHIS.Location = new System.Drawing.Point(0, 37);
            this.pn_contenedosTHIS.Name = "pn_contenedosTHIS";
            this.pn_contenedosTHIS.Size = new System.Drawing.Size(800, 413);
            this.pn_contenedosTHIS.TabIndex = 1;
            // 
            // pn_contenedorFILL
            // 
            this.pn_contenedorFILL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_contenedorFILL.Location = new System.Drawing.Point(0, 0);
            this.pn_contenedorFILL.Name = "pn_contenedorFILL";
            this.pn_contenedorFILL.Size = new System.Drawing.Size(800, 413);
            this.pn_contenedorFILL.TabIndex = 1;
            // 
            // pn_barraTitulo
            // 
            this.pn_barraTitulo.Controls.Add(this.pictureBox1);
            this.pn_barraTitulo.Controls.Add(this.lbl_titulo);
            this.pn_barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pn_barraTitulo.Name = "pn_barraTitulo";
            this.pn_barraTitulo.Size = new System.Drawing.Size(454, 40);
            this.pn_barraTitulo.TabIndex = 6;
            this.pn_barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pn_barraTitulo_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EMS.Properties.Resources.logoEMS;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(49, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(48, 19);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Login";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1,
            this.ln_usuario});
            this.shapeContainer1.Size = new System.Drawing.Size(454, 228);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.lineShape4.Enabled = false;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 0;
            this.lineShape4.X2 = 461;
            this.lineShape4.Y1 = 227;
            this.lineShape4.Y2 = 227;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 453;
            this.lineShape3.X2 = 453;
            this.lineShape3.Y1 = 39;
            this.lineShape3.Y2 = 229;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 0;
            this.lineShape2.X2 = 0;
            this.lineShape2.Y1 = 40;
            this.lineShape2.Y2 = 230;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 41;
            this.lineShape1.X2 = 366;
            this.lineShape1.Y1 = 145;
            this.lineShape1.Y2 = 145;
            // 
            // ln_usuario
            // 
            this.ln_usuario.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.ln_usuario.Enabled = false;
            this.ln_usuario.Name = "ln_usuario";
            this.ln_usuario.X1 = 75;
            this.ln_usuario.X2 = 366;
            this.ln_usuario.Y1 = 99;
            this.ln_usuario.Y2 = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(39, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password:";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Enabled = false;
            this.lbl_usuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_usuario.Location = new System.Drawing.Point(74, 79);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(47, 19);
            this.lbl_usuario.TabIndex = 5;
            this.lbl_usuario.Text = "User:";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_aceptar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.ForeColor = System.Drawing.Color.Black;
            this.btn_aceptar.Location = new System.Drawing.Point(47, 172);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(161, 44);
            this.btn_aceptar.TabIndex = 2;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_cancelar.Location = new System.Drawing.Point(235, 172);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(161, 44);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.White;
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_usuario.Location = new System.Drawing.Point(127, 78);
            this.txt_usuario.MaxLength = 20;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Pdecimales = false;
            this.txt_usuario.Penteros = false;
            this.txt_usuario.Phora = false;
            this.txt_usuario.Ptexto = false;
            this.txt_usuario.Size = new System.Drawing.Size(235, 20);
            this.txt_usuario.TabIndex = 0;
            this.txt_usuario.TextChanged += new System.EventHandler(this.txt_usuario_TextChanged);
            this.txt_usuario.Enter += new System.EventHandler(this.TXT_usuario_Entra);
            this.txt_usuario.Leave += new System.EventHandler(this.TXT_usuario_Sale);
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.White;
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_pass.Location = new System.Drawing.Point(125, 123);
            this.txt_pass.MaxLength = 15;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Pdecimales = false;
            this.txt_pass.Penteros = false;
            this.txt_pass.Phora = false;
            this.txt_pass.Ptexto = false;
            this.txt_pass.Size = new System.Drawing.Size(235, 20);
            this.txt_pass.TabIndex = 1;
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_usuario_TextChanged);
            this.txt_pass.Enter += new System.EventHandler(this.TXT_pass_Entra);
            this.txt_pass.Leave += new System.EventHandler(this.TXT_pass_Sale);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.btn_aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(454, 228);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.pn_barraTitulo);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLogin";
            this.Opacity = 0.88D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.pn_contenedosTHIS.ResumeLayout(false);
            this.pn_barraTitulo.ResumeLayout(false);
            this.pn_barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_contenedosTHIS;
        private System.Windows.Forms.Panel pn_contenedorFILL;
        private System.Windows.Forms.Panel pn_barraTitulo;
        private System.Windows.Forms.Label lbl_titulo;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape ln_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_cancelar;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private CapaLogica.JTextBox txt_usuario;
        private CapaLogica.JTextBox txt_pass;
    }
}


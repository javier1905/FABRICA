namespace CapaPresentacion
{
    partial class PUESTOSform
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.lbx_puesto = new System.Windows.Forms.ListBox();
            this.lbl_idPuesto = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_nombreArea = new System.Windows.Forms.Label();
            this.lbl_lista = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txt_puesto = new CapaLogica.JTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Indigo;
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(119, 241);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(106, 38);
            this.btn_cancelar.TabIndex = 24;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.Indigo;
            this.btn_aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_aceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btn_aceptar.FlatAppearance.BorderSize = 0;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.ForeColor = System.Drawing.Color.White;
            this.btn_aceptar.Location = new System.Drawing.Point(12, 241);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(101, 38);
            this.btn_aceptar.TabIndex = 23;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Indigo;
            this.btn_eliminar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Location = new System.Drawing.Point(12, 197);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(213, 38);
            this.btn_eliminar.TabIndex = 22;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.Indigo;
            this.btn_modificar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_modificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.ForeColor = System.Drawing.Color.White;
            this.btn_modificar.Location = new System.Drawing.Point(12, 153);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(213, 38);
            this.btn_modificar.TabIndex = 21;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // lbx_puesto
            // 
            this.lbx_puesto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_puesto.FormattingEnabled = true;
            this.lbx_puesto.ItemHeight = 19;
            this.lbx_puesto.Location = new System.Drawing.Point(236, 70);
            this.lbx_puesto.Name = "lbx_puesto";
            this.lbx_puesto.Size = new System.Drawing.Size(146, 213);
            this.lbx_puesto.TabIndex = 18;
            this.lbx_puesto.SelectedIndexChanged += new System.EventHandler(this.lbx_puesto_SelectedIndexChanged);
            // 
            // lbl_idPuesto
            // 
            this.lbl_idPuesto.AutoSize = true;
            this.lbl_idPuesto.Enabled = false;
            this.lbl_idPuesto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idPuesto.ForeColor = System.Drawing.Color.Black;
            this.lbl_idPuesto.Location = new System.Drawing.Point(47, 37);
            this.lbl_idPuesto.Name = "lbl_idPuesto";
            this.lbl_idPuesto.Size = new System.Drawing.Size(24, 19);
            this.lbl_idPuesto.TabIndex = 17;
            this.lbl_idPuesto.Text = "Id";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.Black;
            this.lbl_id.Location = new System.Drawing.Point(25, 37);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(30, 19);
            this.lbl_id.TabIndex = 16;
            this.lbl_id.Text = "Id:";
            // 
            // lbl_nombreArea
            // 
            this.lbl_nombreArea.AutoSize = true;
            this.lbl_nombreArea.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreArea.ForeColor = System.Drawing.Color.Black;
            this.lbl_nombreArea.Location = new System.Drawing.Point(8, 70);
            this.lbl_nombreArea.Name = "lbl_nombreArea";
            this.lbl_nombreArea.Size = new System.Drawing.Size(62, 19);
            this.lbl_nombreArea.TabIndex = 15;
            this.lbl_nombreArea.Text = "Puesto:";
            // 
            // lbl_lista
            // 
            this.lbl_lista.AutoSize = true;
            this.lbl_lista.BackColor = System.Drawing.Color.Indigo;
            this.lbl_lista.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lista.ForeColor = System.Drawing.Color.White;
            this.lbl_lista.Location = new System.Drawing.Point(3, 8);
            this.lbl_lista.Name = "lbl_lista";
            this.lbl_lista.Size = new System.Drawing.Size(140, 19);
            this.lbl_lista.TabIndex = 8;
            this.lbl_lista.Text = "Listado de puestos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.lbl_lista);
            this.panel1.Location = new System.Drawing.Point(236, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 35);
            this.panel1.TabIndex = 19;
            // 
            // btn_insertar
            // 
            this.btn_insertar.BackColor = System.Drawing.Color.Indigo;
            this.btn_insertar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_insertar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btn_insertar.FlatAppearance.BorderSize = 0;
            this.btn_insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insertar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insertar.ForeColor = System.Drawing.Color.White;
            this.btn_insertar.Image = global::EMS.Properties.Resources.insertar1;
            this.btn_insertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_insertar.Location = new System.Drawing.Point(12, 109);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(213, 38);
            this.btn_insertar.TabIndex = 20;
            this.btn_insertar.Text = "Insertar";
            this.btn_insertar.UseVisualStyleBackColor = false;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.BackColor = System.Drawing.Color.White;
            this.btn_cerrar.BackgroundImage = global::EMS.Properties.Resources.cerrarGris;
            this.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cerrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.btn_cerrar.Location = new System.Drawing.Point(443, 5);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(30, 27);
            this.btn_cerrar.TabIndex = 25;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(477, 325);
            this.shapeContainer1.TabIndex = 27;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 9;
            this.lineShape2.X2 = 222;
            this.lineShape2.Y1 = 91;
            this.lineShape2.Y2 = 91;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 26;
            this.lineShape1.X2 = 82;
            this.lineShape1.Y1 = 58;
            this.lineShape1.Y2 = 58;
            // 
            // txt_puesto
            // 
            this.txt_puesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_puesto.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_puesto.Location = new System.Drawing.Point(66, 68);
            this.txt_puesto.MaxLength = 20;
            this.txt_puesto.Name = "txt_puesto";
            this.txt_puesto.Pdecimales = false;
            this.txt_puesto.Penteros = false;
            this.txt_puesto.Phora = false;
            this.txt_puesto.Ptexto = true;
            this.txt_puesto.Size = new System.Drawing.Size(157, 20);
            this.txt_puesto.TabIndex = 28;
            this.txt_puesto.TextChanged += new System.EventHandler(this.txt_puesto_TextChanged);
            // 
            // PUESTOSform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(477, 325);
            this.Controls.Add(this.txt_puesto);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_insertar);
            this.Controls.Add(this.lbx_puesto);
            this.Controls.Add(this.lbl_idPuesto);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_nombreArea);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "PUESTOSform";
            this.Text = "PUESTOSform";
            this.Load += new System.EventHandler(this.PUESTOSform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.ListBox lbx_puesto;
        private System.Windows.Forms.Label lbl_idPuesto;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_nombreArea;
        private System.Windows.Forms.Label lbl_lista;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_insertar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private CapaLogica.JTextBox txt_puesto;
    }
}
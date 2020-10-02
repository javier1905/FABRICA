namespace CapaPresentacion
{
    partial class AREASform
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
            this.lbl_nombreArea = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lin_nArea = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_idArea = new System.Windows.Forms.Label();
            this.lbx_areas = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_lista = new System.Windows.Forms.Label();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_nombreArea = new CapaLogica.JTextBox();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nombreArea
            // 
            this.lbl_nombreArea.AutoSize = true;
            this.lbl_nombreArea.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.lbl_nombreArea.Location = new System.Drawing.Point(20, 71);
            this.lbl_nombreArea.Name = "lbl_nombreArea";
            this.lbl_nombreArea.Size = new System.Drawing.Size(48, 19);
            this.lbl_nombreArea.TabIndex = 1;
            this.lbl_nombreArea.Text = "Area:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lin_nArea});
            this.shapeContainer1.Size = new System.Drawing.Size(418, 312);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 65;
            this.lineShape1.X2 = 94;
            this.lineShape1.Y1 = 55;
            this.lineShape1.Y2 = 55;
            // 
            // lin_nArea
            // 
            this.lin_nArea.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.lin_nArea.Name = "lin_nArea";
            this.lin_nArea.X1 = 59;
            this.lin_nArea.X2 = 206;
            this.lin_nArea.Y1 = 93;
            this.lin_nArea.Y2 = 94;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.lbl_id.Location = new System.Drawing.Point(37, 36);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(30, 19);
            this.lbl_id.TabIndex = 4;
            this.lbl_id.Text = "Id:";
            // 
            // lbl_idArea
            // 
            this.lbl_idArea.AutoSize = true;
            this.lbl_idArea.Enabled = false;
            this.lbl_idArea.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.lbl_idArea.Location = new System.Drawing.Point(70, 36);
            this.lbl_idArea.Name = "lbl_idArea";
            this.lbl_idArea.Size = new System.Drawing.Size(24, 19);
            this.lbl_idArea.TabIndex = 5;
            this.lbl_idArea.Text = "Id";
            // 
            // lbx_areas
            // 
            this.lbx_areas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_areas.FormattingEnabled = true;
            this.lbx_areas.ItemHeight = 19;
            this.lbx_areas.Location = new System.Drawing.Point(248, 69);
            this.lbx_areas.Name = "lbx_areas";
            this.lbx_areas.Size = new System.Drawing.Size(146, 213);
            this.lbx_areas.TabIndex = 6;
            this.lbx_areas.SelectedIndexChanged += new System.EventHandler(this.lbx_areas_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.lbl_lista);
            this.panel1.Location = new System.Drawing.Point(248, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 35);
            this.panel1.TabIndex = 7;
            // 
            // lbl_lista
            // 
            this.lbl_lista.AutoSize = true;
            this.lbl_lista.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.lbl_lista.Location = new System.Drawing.Point(3, 8);
            this.lbl_lista.Name = "lbl_lista";
            this.lbl_lista.Size = new System.Drawing.Size(123, 19);
            this.lbl_lista.TabIndex = 8;
            this.lbl_lista.Text = "Listado de areas";
            // 
            // btn_insertar
            // 
            this.btn_insertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.btn_insertar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_insertar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btn_insertar.FlatAppearance.BorderSize = 0;
            this.btn_insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insertar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insertar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.btn_insertar.Location = new System.Drawing.Point(24, 108);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(213, 38);
            this.btn_insertar.TabIndex = 8;
            this.btn_insertar.Text = "Insertar";
            this.btn_insertar.UseVisualStyleBackColor = false;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.btn_modificar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_modificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.btn_modificar.Location = new System.Drawing.Point(24, 152);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(213, 38);
            this.btn_modificar.TabIndex = 10;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.btn_eliminar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.btn_eliminar.Location = new System.Drawing.Point(24, 196);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(213, 38);
            this.btn_eliminar.TabIndex = 11;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.btn_aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_aceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btn_aceptar.FlatAppearance.BorderSize = 0;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.btn_aceptar.Location = new System.Drawing.Point(24, 240);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(101, 38);
            this.btn_aceptar.TabIndex = 12;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.btn_cancelar.Location = new System.Drawing.Point(131, 240);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(106, 38);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_nombreArea
            // 
            this.txt_nombreArea.BackColor = System.Drawing.Color.White;
            this.txt_nombreArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombreArea.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_nombreArea.Location = new System.Drawing.Point(65, 70);
            this.txt_nombreArea.MaxLength = 20;
            this.txt_nombreArea.Name = "txt_nombreArea";
            this.txt_nombreArea.Pdecimales = false;
            this.txt_nombreArea.Penteros = false;
            this.txt_nombreArea.Phora = false;
            this.txt_nombreArea.Ptexto = true;
            this.txt_nombreArea.Size = new System.Drawing.Size(142, 20);
            this.txt_nombreArea.TabIndex = 2;
            this.txt_nombreArea.TextChanged += new System.EventHandler(this.txt_nombreArea_TextChanged);
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
            this.btn_cerrar.Location = new System.Drawing.Point(385, 3);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(30, 27);
            this.btn_cerrar.TabIndex = 14;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // AREASform
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(418, 312);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_insertar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbx_areas);
            this.Controls.Add(this.lbl_idArea);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_nombreArea);
            this.Controls.Add(this.lbl_nombreArea);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AREASform";
            this.Text = "AREASform";
            this.Load += new System.EventHandler(this.AREASform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_nombreArea;
        private CapaLogica.JTextBox txt_nombreArea;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lin_nArea;
        private System.Windows.Forms.Label lbl_id;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label lbl_idArea;
        private System.Windows.Forms.ListBox lbx_areas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_lista;
        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_cerrar;
    }
}
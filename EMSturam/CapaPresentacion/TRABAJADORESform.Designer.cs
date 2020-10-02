namespace CapaPresentacion
{
    partial class TRABAJADORESform
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
            this.dtp_fNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbx_puesto = new System.Windows.Forms.ComboBox();
            this.dtp_fIngreso = new System.Windows.Forms.DateTimePicker();
            this.cbx_area = new System.Windows.Forms.ComboBox();
            this.btn_seleccionarFoto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ofd_selectorFoto = new System.Windows.Forms.OpenFileDialog();
            this.txt_apellido = new CapaLogica.JTextBox();
            this.txt_nombre = new CapaLogica.JTextBox();
            this.txt_idTrabajador = new CapaLogica.JTextBox();
            this.pbx_foto = new System.Windows.Forms.PictureBox();
            this.lbx_trabajadores = new System.Windows.Forms.ListBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_insertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_fNacimiento
            // 
            this.dtp_fNacimiento.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fNacimiento.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fNacimiento.Location = new System.Drawing.Point(401, 280);
            this.dtp_fNacimiento.Name = "dtp_fNacimiento";
            this.dtp_fNacimiento.Size = new System.Drawing.Size(153, 27);
            this.dtp_fNacimiento.TabIndex = 3;
            // 
            // cbx_puesto
            // 
            this.cbx_puesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_puesto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_puesto.FormattingEnabled = true;
            this.cbx_puesto.Location = new System.Drawing.Point(401, 319);
            this.cbx_puesto.Name = "cbx_puesto";
            this.cbx_puesto.Size = new System.Drawing.Size(153, 27);
            this.cbx_puesto.TabIndex = 4;
            // 
            // dtp_fIngreso
            // 
            this.dtp_fIngreso.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fIngreso.Location = new System.Drawing.Point(401, 358);
            this.dtp_fIngreso.Name = "dtp_fIngreso";
            this.dtp_fIngreso.Size = new System.Drawing.Size(153, 27);
            this.dtp_fIngreso.TabIndex = 5;
            // 
            // cbx_area
            // 
            this.cbx_area.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_area.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_area.FormattingEnabled = true;
            this.cbx_area.Location = new System.Drawing.Point(401, 397);
            this.cbx_area.Name = "cbx_area";
            this.cbx_area.Size = new System.Drawing.Size(153, 27);
            this.cbx_area.TabIndex = 6;
            // 
            // btn_seleccionarFoto
            // 
            this.btn_seleccionarFoto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccionarFoto.Location = new System.Drawing.Point(401, 436);
            this.btn_seleccionarFoto.Name = "btn_seleccionarFoto";
            this.btn_seleccionarFoto.Size = new System.Drawing.Size(153, 41);
            this.btn_seleccionarFoto.TabIndex = 7;
            this.btn_seleccionarFoto.Text = "Seleccionar Foto";
            this.btn_seleccionarFoto.UseVisualStyleBackColor = true;
            this.btn_seleccionarFoto.Click += new System.EventHandler(this.btn_seleccionarFoto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre:";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.Location = new System.Drawing.Point(322, 248);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(73, 19);
            this.lbl_apellido.TabIndex = 10;
            this.lbl_apellido.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha de Nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(333, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Puesto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(259, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha de Ingreso:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(347, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Area:";
            // 
            // ofd_selectorFoto
            // 
            this.ofd_selectorFoto.FileName = "openFileDialog1";
            // 
            // txt_apellido
            // 
            this.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_apellido.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_apellido.Location = new System.Drawing.Point(401, 248);
            this.txt_apellido.MaxLength = 10;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Pdecimales = false;
            this.txt_apellido.Penteros = false;
            this.txt_apellido.Phora = false;
            this.txt_apellido.Ptexto = true;
            this.txt_apellido.Size = new System.Drawing.Size(153, 20);
            this.txt_apellido.TabIndex = 2;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_nombre.Location = new System.Drawing.Point(401, 216);
            this.txt_nombre.MaxLength = 10;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pdecimales = false;
            this.txt_nombre.Penteros = false;
            this.txt_nombre.Phora = false;
            this.txt_nombre.Ptexto = true;
            this.txt_nombre.Size = new System.Drawing.Size(153, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // txt_idTrabajador
            // 
            this.txt_idTrabajador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_idTrabajador.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_idTrabajador.Location = new System.Drawing.Point(401, 184);
            this.txt_idTrabajador.MaxLength = 10;
            this.txt_idTrabajador.Name = "txt_idTrabajador";
            this.txt_idTrabajador.Pdecimales = false;
            this.txt_idTrabajador.Penteros = false;
            this.txt_idTrabajador.Phora = false;
            this.txt_idTrabajador.Ptexto = true;
            this.txt_idTrabajador.Size = new System.Drawing.Size(153, 20);
            this.txt_idTrabajador.TabIndex = 0;
            // 
            // pbx_foto
            // 
            this.pbx_foto.Location = new System.Drawing.Point(401, 42);
            this.pbx_foto.Name = "pbx_foto";
            this.pbx_foto.Size = new System.Drawing.Size(156, 136);
            this.pbx_foto.TabIndex = 15;
            this.pbx_foto.TabStop = false;
            // 
            // lbx_trabajadores
            // 
            this.lbx_trabajadores.FormattingEnabled = true;
            this.lbx_trabajadores.Location = new System.Drawing.Point(572, 42);
            this.lbx_trabajadores.Name = "lbx_trabajadores";
            this.lbx_trabajadores.Size = new System.Drawing.Size(191, 433);
            this.lbx_trabajadores.TabIndex = 16;
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
            this.btn_cancelar.Location = new System.Drawing.Point(119, 174);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(106, 38);
            this.btn_cancelar.TabIndex = 21;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
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
            this.btn_aceptar.Location = new System.Drawing.Point(12, 174);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(101, 38);
            this.btn_aceptar.TabIndex = 20;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
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
            this.btn_eliminar.Location = new System.Drawing.Point(12, 130);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(213, 38);
            this.btn_eliminar.TabIndex = 19;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
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
            this.btn_modificar.Location = new System.Drawing.Point(12, 86);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(213, 38);
            this.btn_modificar.TabIndex = 18;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
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
            this.btn_insertar.Location = new System.Drawing.Point(12, 42);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(213, 38);
            this.btn_insertar.TabIndex = 17;
            this.btn_insertar.Text = "Insertar";
            this.btn_insertar.UseVisualStyleBackColor = false;
            // 
            // TRABAJADORESform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 517);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_insertar);
            this.Controls.Add(this.lbx_trabajadores);
            this.Controls.Add(this.pbx_foto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_seleccionarFoto);
            this.Controls.Add(this.cbx_area);
            this.Controls.Add(this.dtp_fIngreso);
            this.Controls.Add(this.cbx_puesto);
            this.Controls.Add(this.dtp_fNacimiento);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_idTrabajador);
            this.Name = "TRABAJADORESform";
            this.Text = "TRABAJADORESform";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CapaLogica.JTextBox txt_idTrabajador;
        private CapaLogica.JTextBox txt_nombre;
        private CapaLogica.JTextBox txt_apellido;
        private System.Windows.Forms.DateTimePicker dtp_fNacimiento;
        private System.Windows.Forms.ComboBox cbx_puesto;
        private System.Windows.Forms.DateTimePicker dtp_fIngreso;
        private System.Windows.Forms.ComboBox cbx_area;
        private System.Windows.Forms.Button btn_seleccionarFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog ofd_selectorFoto;
        private System.Windows.Forms.PictureBox pbx_foto;
        private System.Windows.Forms.ListBox lbx_trabajadores;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_insertar;
    }
}
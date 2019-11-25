namespace ConsultorioOdontologico.UI.Registros
{
    partial class rProcedimientos
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EstadoComboBox = new System.Windows.Forms.ComboBox();
            this.TipoProcedimientoComboBox = new System.Windows.Forms.ComboBox();
            this.MontoTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CitaIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.CProcedimientoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCitaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTipoProcedimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.ProcedimientoIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PacienteComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BuscarProcedimientoButton = new System.Windows.Forms.Button();
            this.BuscarCitasButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.RemoverFilaButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CitaIdNumericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcedimientoIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EstadoComboBox);
            this.groupBox2.Controls.Add(this.TipoProcedimientoComboBox);
            this.groupBox2.Controls.Add(this.MontoTextBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.AgregarButton);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.DescripcionTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(8, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(662, 132);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cumplimiento Cita";
            // 
            // EstadoComboBox
            // 
            this.EstadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstadoComboBox.FormattingEnabled = true;
            this.EstadoComboBox.Items.AddRange(new object[] {
            "En Proceso",
            "Terminado"});
            this.EstadoComboBox.Location = new System.Drawing.Point(83, 54);
            this.EstadoComboBox.Name = "EstadoComboBox";
            this.EstadoComboBox.Size = new System.Drawing.Size(299, 21);
            this.EstadoComboBox.TabIndex = 28;
            // 
            // TipoProcedimientoComboBox
            // 
            this.TipoProcedimientoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoProcedimientoComboBox.FormattingEnabled = true;
            this.TipoProcedimientoComboBox.Location = new System.Drawing.Point(83, 27);
            this.TipoProcedimientoComboBox.Name = "TipoProcedimientoComboBox";
            this.TipoProcedimientoComboBox.Size = new System.Drawing.Size(299, 21);
            this.TipoProcedimientoComboBox.TabIndex = 34;
            this.TipoProcedimientoComboBox.SelectedIndexChanged += new System.EventHandler(this.TipoProcedimientoComboBox_SelectedIndexChanged);
            // 
            // MontoTextBox
            // 
            this.MontoTextBox.Location = new System.Drawing.Point(82, 94);
            this.MontoTextBox.Name = "MontoTextBox";
            this.MontoTextBox.ReadOnly = true;
            this.MontoTextBox.Size = new System.Drawing.Size(253, 20);
            this.MontoTextBox.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Monto";
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(341, 92);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(41, 22);
            this.AgregarButton.TabIndex = 31;
            this.AgregarButton.Text = "+";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Estado";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(469, 17);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(182, 53);
            this.DescripcionTextBox.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(392, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Descripción";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Procedimiento";
            // 
            // CitaIdNumericUpDown
            // 
            this.CitaIdNumericUpDown.Location = new System.Drawing.Point(124, 53);
            this.CitaIdNumericUpDown.Name = "CitaIdNumericUpDown";
            this.CitaIdNumericUpDown.Size = new System.Drawing.Size(492, 20);
            this.CitaIdNumericUpDown.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cita Id";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RemoverFilaButton);
            this.groupBox3.Controls.Add(this.DetalleDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(8, 262);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(662, 272);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.AllowUserToAddRows = false;
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CProcedimientoId,
            this.CCitaId,
            this.CPaciente,
            this.CTipoProcedimiento,
            this.CDescripcion});
            this.DetalleDataGridView.Location = new System.Drawing.Point(5, 17);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.Size = new System.Drawing.Size(646, 213);
            this.DetalleDataGridView.TabIndex = 3;
            // 
            // CProcedimientoId
            // 
            this.CProcedimientoId.HeaderText = "ProcedimientoId";
            this.CProcedimientoId.Name = "CProcedimientoId";
            // 
            // CCitaId
            // 
            this.CCitaId.HeaderText = "Cita Id";
            this.CCitaId.Name = "CCitaId";
            this.CCitaId.ReadOnly = true;
            // 
            // CPaciente
            // 
            this.CPaciente.HeaderText = "Paciente";
            this.CPaciente.Name = "CPaciente";
            this.CPaciente.ReadOnly = true;
            // 
            // CTipoProcedimiento
            // 
            this.CTipoProcedimiento.HeaderText = "Tipo de Procedimiento";
            this.CTipoProcedimiento.Name = "CTipoProcedimiento";
            this.CTipoProcedimiento.ReadOnly = true;
            // 
            // CDescripcion
            // 
            this.CDescripcion.HeaderText = "Descripción";
            this.CDescripcion.Name = "CDescripcion";
            this.CDescripcion.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "ProcedimientoId";
            // 
            // ProcedimientoIdNumericUpDown
            // 
            this.ProcedimientoIdNumericUpDown.Location = new System.Drawing.Point(123, 14);
            this.ProcedimientoIdNumericUpDown.Name = "ProcedimientoIdNumericUpDown";
            this.ProcedimientoIdNumericUpDown.Size = new System.Drawing.Size(493, 20);
            this.ProcedimientoIdNumericUpDown.TabIndex = 17;
            // 
            // PacienteComboBox
            // 
            this.PacienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PacienteComboBox.Enabled = false;
            this.PacienteComboBox.FormattingEnabled = true;
            this.PacienteComboBox.Location = new System.Drawing.Point(125, 88);
            this.PacienteComboBox.Name = "PacienteComboBox";
            this.PacienteComboBox.Size = new System.Drawing.Size(534, 21);
            this.PacienteComboBox.TabIndex = 27;
            this.PacienteComboBox.SelectedIndexChanged += new System.EventHandler(this.PacienteComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nombre del Paciente";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLabel.Location = new System.Drawing.Point(362, 626);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(16, 15);
            this.UsuarioLabel.TabIndex = 55;
            this.UsuarioLabel.Text = "...";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(286, 625);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 16);
            this.label12.TabIndex = 54;
            this.label12.Text = "Usuario: ";
            // 
            // BuscarProcedimientoButton
            // 
            this.BuscarProcedimientoButton.FlatAppearance.BorderSize = 0;
            this.BuscarProcedimientoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarProcedimientoButton.Image = global::ConsultorioOdontologico.Properties.Resources.icons8_google_web_search_100_1_;
            this.BuscarProcedimientoButton.Location = new System.Drawing.Point(622, 5);
            this.BuscarProcedimientoButton.Name = "BuscarProcedimientoButton";
            this.BuscarProcedimientoButton.Size = new System.Drawing.Size(37, 35);
            this.BuscarProcedimientoButton.TabIndex = 43;
            this.BuscarProcedimientoButton.UseVisualStyleBackColor = true;
            this.BuscarProcedimientoButton.Click += new System.EventHandler(this.BuscarProcedimientoButton_Click);
            // 
            // BuscarCitasButton
            // 
            this.BuscarCitasButton.FlatAppearance.BorderSize = 0;
            this.BuscarCitasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarCitasButton.Image = global::ConsultorioOdontologico.Properties.Resources.icons8_google_web_search_100_1_;
            this.BuscarCitasButton.Location = new System.Drawing.Point(622, 44);
            this.BuscarCitasButton.Name = "BuscarCitasButton";
            this.BuscarCitasButton.Size = new System.Drawing.Size(37, 35);
            this.BuscarCitasButton.TabIndex = 42;
            this.BuscarCitasButton.UseVisualStyleBackColor = true;
            this.BuscarCitasButton.Click += new System.EventHandler(this.BuscarCitasButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = global::ConsultorioOdontologico.Properties.Resources.BotonEliminar1;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(582, 549);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(77, 62);
            this.EliminarButton.TabIndex = 41;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Image = global::ConsultorioOdontologico.Properties.Resources.BotonGuardar;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(289, 549);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(81, 62);
            this.GuardarButton.TabIndex = 40;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Image = global::ConsultorioOdontologico.Properties.Resources.CrearNuevo1;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(15, 549);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(76, 62);
            this.NuevoButton.TabIndex = 39;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // RemoverFilaButton
            // 
            this.RemoverFilaButton.Image = global::ConsultorioOdontologico.Properties.Resources.iconfinder_Delete_14932791;
            this.RemoverFilaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverFilaButton.Location = new System.Drawing.Point(7, 236);
            this.RemoverFilaButton.Name = "RemoverFilaButton";
            this.RemoverFilaButton.Size = new System.Drawing.Size(117, 30);
            this.RemoverFilaButton.TabIndex = 4;
            this.RemoverFilaButton.Text = "Remover Fila";
            this.RemoverFilaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoverFilaButton.UseVisualStyleBackColor = true;
            this.RemoverFilaButton.Click += new System.EventHandler(this.RemoverFilaButton_Click);
            // 
            // rProcedimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 650);
            this.Controls.Add(this.UsuarioLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BuscarProcedimientoButton);
            this.Controls.Add(this.BuscarCitasButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.PacienteComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProcedimientoIdNumericUpDown);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CitaIdNumericUpDown);
            this.Name = "rProcedimientos";
            this.Text = "Procedimientos";
            this.Load += new System.EventHandler(this.rProcedimientos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CitaIdNumericUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcedimientoIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown CitaIdNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DetalleDataGridView;
        private System.Windows.Forms.ComboBox TipoProcedimientoComboBox;
        private System.Windows.Forms.TextBox MontoTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown ProcedimientoIdNumericUpDown;
        private System.Windows.Forms.ComboBox PacienteComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox EstadoComboBox;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button BuscarProcedimientoButton;
        private System.Windows.Forms.Button BuscarCitasButton;
        private System.Windows.Forms.Button RemoverFilaButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProcedimientoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCitaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTipoProcedimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcion;
        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.Label label12;
    }
}
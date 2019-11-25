namespace ConsultorioOdontologico.UI.Registros
{
    partial class rCitas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CitaIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HoraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ObservacionTextBox = new System.Windows.Forms.TextBox();
            this.EstadoComboBox = new System.Windows.Forms.ComboBox();
            this.PacienteComboBox = new System.Windows.Forms.ComboBox();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.AgregarPacienteButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.BuscarCitasButton = new System.Windows.Forms.Button();
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CitaIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CitaId";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Paciente";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estado";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Observación";
            // 
            // CitaIdNumericUpDown
            // 
            this.CitaIdNumericUpDown.Location = new System.Drawing.Point(92, 19);
            this.CitaIdNumericUpDown.Name = "CitaIdNumericUpDown";
            this.CitaIdNumericUpDown.Size = new System.Drawing.Size(132, 20);
            this.CitaIdNumericUpDown.TabIndex = 7;
            this.CitaIdNumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(89, 91);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(185, 20);
            this.FechaDateTimePicker.TabIndex = 9;
            // 
            // HoraDateTimePicker
            // 
            this.HoraDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HoraDateTimePicker.CustomFormat = "hh:mm tt";
            this.HoraDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HoraDateTimePicker.Location = new System.Drawing.Point(89, 117);
            this.HoraDateTimePicker.Name = "HoraDateTimePicker";
            this.HoraDateTimePicker.Size = new System.Drawing.Size(185, 20);
            this.HoraDateTimePicker.TabIndex = 10;
            // 
            // ObservacionTextBox
            // 
            this.ObservacionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ObservacionTextBox.Location = new System.Drawing.Point(89, 170);
            this.ObservacionTextBox.Multiline = true;
            this.ObservacionTextBox.Name = "ObservacionTextBox";
            this.ObservacionTextBox.Size = new System.Drawing.Size(185, 39);
            this.ObservacionTextBox.TabIndex = 12;
            // 
            // EstadoComboBox
            // 
            this.EstadoComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EstadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstadoComboBox.FormattingEnabled = true;
            this.EstadoComboBox.Items.AddRange(new object[] {
            "Programada",
            "Vencida",
            "Reprogramada",
            "Cumplida"});
            this.EstadoComboBox.Location = new System.Drawing.Point(89, 143);
            this.EstadoComboBox.Name = "EstadoComboBox";
            this.EstadoComboBox.Size = new System.Drawing.Size(185, 21);
            this.EstadoComboBox.TabIndex = 44;
            // 
            // PacienteComboBox
            // 
            this.PacienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PacienteComboBox.FormattingEnabled = true;
            this.PacienteComboBox.Location = new System.Drawing.Point(92, 58);
            this.PacienteComboBox.Name = "PacienteComboBox";
            this.PacienteComboBox.Size = new System.Drawing.Size(132, 21);
            this.PacienteComboBox.TabIndex = 48;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // AgregarPacienteButton
            // 
            this.AgregarPacienteButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AgregarPacienteButton.FlatAppearance.BorderSize = 0;
            this.AgregarPacienteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarPacienteButton.Image = global::ConsultorioOdontologico.Properties.Resources.icons8_añadir_48;
            this.AgregarPacienteButton.Location = new System.Drawing.Point(231, 46);
            this.AgregarPacienteButton.Name = "AgregarPacienteButton";
            this.AgregarPacienteButton.Size = new System.Drawing.Size(48, 43);
            this.AgregarPacienteButton.TabIndex = 51;
            this.AgregarPacienteButton.UseVisualStyleBackColor = true;
            this.AgregarPacienteButton.Click += new System.EventHandler(this.AgregarPacienteButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = global::ConsultorioOdontologico.Properties.Resources.BotonEliminar1;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(197, 235);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(77, 62);
            this.EliminarButton.TabIndex = 47;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Image = global::ConsultorioOdontologico.Properties.Resources.BotonGuardar;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(103, 235);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(81, 62);
            this.GuardarButton.TabIndex = 46;
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
            this.NuevoButton.Location = new System.Drawing.Point(12, 235);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(76, 62);
            this.NuevoButton.TabIndex = 45;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // BuscarCitasButton
            // 
            this.BuscarCitasButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BuscarCitasButton.FlatAppearance.BorderSize = 0;
            this.BuscarCitasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarCitasButton.Image = global::ConsultorioOdontologico.Properties.Resources.icons8_google_web_search_100_1_;
            this.BuscarCitasButton.Location = new System.Drawing.Point(237, 9);
            this.BuscarCitasButton.Name = "BuscarCitasButton";
            this.BuscarCitasButton.Size = new System.Drawing.Size(37, 35);
            this.BuscarCitasButton.TabIndex = 38;
            this.BuscarCitasButton.UseVisualStyleBackColor = true;
            this.BuscarCitasButton.Click += new System.EventHandler(this.BuscarCitasButton_Click);
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLabel.Location = new System.Drawing.Point(176, 318);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(16, 15);
            this.UsuarioLabel.TabIndex = 53;
            this.UsuarioLabel.Text = "...";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(100, 317);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 16);
            this.label12.TabIndex = 52;
            this.label12.Text = "Usuario: ";
            // 
            // rCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 343);
            this.Controls.Add(this.UsuarioLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.AgregarPacienteButton);
            this.Controls.Add(this.PacienteComboBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.EstadoComboBox);
            this.Controls.Add(this.BuscarCitasButton);
            this.Controls.Add(this.ObservacionTextBox);
            this.Controls.Add(this.HoraDateTimePicker);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.CitaIdNumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rCitas";
            this.Text = "rCitas";
            this.Load += new System.EventHandler(this.rCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CitaIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown CitaIdNumericUpDown;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.DateTimePicker HoraDateTimePicker;
        private System.Windows.Forms.TextBox ObservacionTextBox;
        private System.Windows.Forms.Button BuscarCitasButton;
        private System.Windows.Forms.ComboBox EstadoComboBox;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.ComboBox PacienteComboBox;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Button AgregarPacienteButton;
        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.Label label12;
    }
}
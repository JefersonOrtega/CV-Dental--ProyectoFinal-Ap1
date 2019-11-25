namespace ConsultorioOdontologico.UI.Registros
{
    partial class rCobros
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
            this.label3 = new System.Windows.Forms.Label();
            this.ProcedimientoIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CobroIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AbonoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.BuscarPacienteButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MontoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PacientetextBox = new System.Windows.Forms.TextBox();
            this.CMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTipoProcedimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProcedimientoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorCobrarDataGridView = new System.Windows.Forms.DataGridView();
            this.SaldarCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProcedimientoIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CobroIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbonoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PorCobrarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CobroId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Abono";
            // 
            // ProcedimientoIdNumericUpDown
            // 
            this.ProcedimientoIdNumericUpDown.Location = new System.Drawing.Point(123, 48);
            this.ProcedimientoIdNumericUpDown.Name = "ProcedimientoIdNumericUpDown";
            this.ProcedimientoIdNumericUpDown.Size = new System.Drawing.Size(392, 20);
            this.ProcedimientoIdNumericUpDown.TabIndex = 41;
            // 
            // CobroIdnumericUpDown
            // 
            this.CobroIdnumericUpDown.Location = new System.Drawing.Point(123, 12);
            this.CobroIdnumericUpDown.Name = "CobroIdnumericUpDown";
            this.CobroIdnumericUpDown.Size = new System.Drawing.Size(392, 20);
            this.CobroIdnumericUpDown.TabIndex = 40;
            // 
            // AbonoNumericUpDown
            // 
            this.AbonoNumericUpDown.DecimalPlaces = 2;
            this.AbonoNumericUpDown.Location = new System.Drawing.Point(123, 176);
            this.AbonoNumericUpDown.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.AbonoNumericUpDown.Name = "AbonoNumericUpDown";
            this.AbonoNumericUpDown.Size = new System.Drawing.Size(435, 20);
            this.AbonoNumericUpDown.TabIndex = 44;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = global::ConsultorioOdontologico.Properties.Resources.BotonEliminar1;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(481, 479);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(77, 62);
            this.EliminarButton.TabIndex = 47;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Image = global::ConsultorioOdontologico.Properties.Resources.BotonGuardar;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(225, 479);
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
            this.NuevoButton.Location = new System.Drawing.Point(13, 480);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(76, 62);
            this.NuevoButton.TabIndex = 45;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // BuscarPacienteButton
            // 
            this.BuscarPacienteButton.FlatAppearance.BorderSize = 0;
            this.BuscarPacienteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarPacienteButton.Image = global::ConsultorioOdontologico.Properties.Resources.icons8_google_web_search_100_1_;
            this.BuscarPacienteButton.Location = new System.Drawing.Point(523, 39);
            this.BuscarPacienteButton.Name = "BuscarPacienteButton";
            this.BuscarPacienteButton.Size = new System.Drawing.Size(37, 35);
            this.BuscarPacienteButton.TabIndex = 43;
            this.BuscarPacienteButton.UseVisualStyleBackColor = true;
            this.BuscarPacienteButton.Click += new System.EventHandler(this.BuscarPacienteButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.FlatAppearance.BorderSize = 0;
            this.BuscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarButton.Image = global::ConsultorioOdontologico.Properties.Resources.icons8_google_web_search_100_1_;
            this.BuscarButton.Location = new System.Drawing.Point(521, 2);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(37, 35);
            this.BuscarButton.TabIndex = 42;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PacienteId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Monto a Pagar";
            // 
            // MontoTextBox
            // 
            this.MontoTextBox.Location = new System.Drawing.Point(123, 141);
            this.MontoTextBox.Name = "MontoTextBox";
            this.MontoTextBox.ReadOnly = true;
            this.MontoTextBox.Size = new System.Drawing.Size(435, 20);
            this.MontoTextBox.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "ProcedimientoId";
            // 
            // PacientetextBox
            // 
            this.PacientetextBox.Location = new System.Drawing.Point(123, 108);
            this.PacientetextBox.Name = "PacientetextBox";
            this.PacientetextBox.Size = new System.Drawing.Size(435, 20);
            this.PacientetextBox.TabIndex = 51;
            this.PacientetextBox.TextChanged += new System.EventHandler(this.PacientetextBox_TextChanged);
            // 
            // CMonto
            // 
            this.CMonto.HeaderText = "Monto";
            this.CMonto.Name = "CMonto";
            // 
            // CEstado
            // 
            this.CEstado.HeaderText = "Estado";
            this.CEstado.Name = "CEstado";
            // 
            // cTipoProcedimiento
            // 
            this.cTipoProcedimiento.HeaderText = "Tipo de Procedimiento";
            this.cTipoProcedimiento.Name = "cTipoProcedimiento";
            // 
            // CProcedimientoId
            // 
            this.CProcedimientoId.HeaderText = "ProcedimientoId";
            this.CProcedimientoId.Name = "CProcedimientoId";
            // 
            // CPaciente
            // 
            this.CPaciente.HeaderText = "Paciente";
            this.CPaciente.Name = "CPaciente";
            // 
            // PorCobrarDataGridView
            // 
            this.PorCobrarDataGridView.AllowUserToAddRows = false;
            this.PorCobrarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PorCobrarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CPaciente,
            this.CProcedimientoId,
            this.cTipoProcedimiento,
            this.CEstado,
            this.CMonto});
            this.PorCobrarDataGridView.Location = new System.Drawing.Point(12, 224);
            this.PorCobrarDataGridView.Name = "PorCobrarDataGridView";
            this.PorCobrarDataGridView.Size = new System.Drawing.Size(546, 243);
            this.PorCobrarDataGridView.TabIndex = 35;
            // 
            // SaldarCheckBox
            // 
            this.SaldarCheckBox.AutoSize = true;
            this.SaldarCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaldarCheckBox.ForeColor = System.Drawing.Color.Red;
            this.SaldarCheckBox.Location = new System.Drawing.Point(381, 198);
            this.SaldarCheckBox.Name = "SaldarCheckBox";
            this.SaldarCheckBox.Size = new System.Drawing.Size(177, 20);
            this.SaldarCheckBox.TabIndex = 52;
            this.SaldarCheckBox.Text = "Saldar Procedimiento";
            this.SaldarCheckBox.UseVisualStyleBackColor = true;
            this.SaldarCheckBox.CheckedChanged += new System.EventHandler(this.SaldarCheckBox_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Fecha";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(123, 79);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(437, 20);
            this.FechaDateTimePicker.TabIndex = 54;
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLabel.Location = new System.Drawing.Point(298, 565);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(16, 15);
            this.UsuarioLabel.TabIndex = 56;
            this.UsuarioLabel.Text = "...";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(222, 564);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 16);
            this.label12.TabIndex = 55;
            this.label12.Text = "Usuario: ";
            // 
            // rCobros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 589);
            this.Controls.Add(this.UsuarioLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SaldarCheckBox);
            this.Controls.Add(this.PacientetextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MontoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.AbonoNumericUpDown);
            this.Controls.Add(this.BuscarPacienteButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.ProcedimientoIdNumericUpDown);
            this.Controls.Add(this.CobroIdnumericUpDown);
            this.Controls.Add(this.PorCobrarDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rCobros";
            this.Text = "rCobros";
            this.Load += new System.EventHandler(this.rCobros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProcedimientoIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CobroIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbonoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PorCobrarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BuscarPacienteButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.NumericUpDown ProcedimientoIdNumericUpDown;
        private System.Windows.Forms.NumericUpDown CobroIdnumericUpDown;
        private System.Windows.Forms.NumericUpDown AbonoNumericUpDown;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MontoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PacientetextBox;
        private System.Windows.Forms.DataGridView PorCobrarDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProcedimientoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTipoProcedimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMonto;
        private System.Windows.Forms.CheckBox SaldarCheckBox;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.Label label12;
    }
}
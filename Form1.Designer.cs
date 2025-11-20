namespace _1_PracticaFinal_POO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Grilla_Empleado = new DataGridView();
            BTN_AGREGAR = new Button();
            BTN_ELIMINAR = new Button();
            BTN_MODIFICAR = new Button();
            PICKER = new DateTimePicker();
            label1 = new Label();
            CB_ADM = new CheckBox();
            CB_OP = new CheckBox();
            groupBox1 = new GroupBox();
            TXT_BUSQUEDA = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)Grilla_Empleado).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // Grilla_Empleado
            // 
            Grilla_Empleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla_Empleado.Location = new Point(31, 30);
            Grilla_Empleado.Name = "Grilla_Empleado";
            Grilla_Empleado.Size = new Size(431, 212);
            Grilla_Empleado.TabIndex = 0;
            Grilla_Empleado.CellFormatting += Grilla_Empleado_CellFormatting;
            // 
            // BTN_AGREGAR
            // 
            BTN_AGREGAR.Location = new Point(173, 342);
            BTN_AGREGAR.Name = "BTN_AGREGAR";
            BTN_AGREGAR.Size = new Size(75, 23);
            BTN_AGREGAR.TabIndex = 1;
            BTN_AGREGAR.Text = "Agregar";
            BTN_AGREGAR.UseVisualStyleBackColor = true;
            BTN_AGREGAR.Click += BTN_AGREGAR_Click;
            // 
            // BTN_ELIMINAR
            // 
            BTN_ELIMINAR.Location = new Point(497, 118);
            BTN_ELIMINAR.Name = "BTN_ELIMINAR";
            BTN_ELIMINAR.Size = new Size(75, 23);
            BTN_ELIMINAR.TabIndex = 2;
            BTN_ELIMINAR.Text = "Eliminar";
            BTN_ELIMINAR.UseVisualStyleBackColor = true;
            // 
            // BTN_MODIFICAR
            // 
            BTN_MODIFICAR.Location = new Point(497, 187);
            BTN_MODIFICAR.Name = "BTN_MODIFICAR";
            BTN_MODIFICAR.Size = new Size(75, 23);
            BTN_MODIFICAR.TabIndex = 3;
            BTN_MODIFICAR.Text = "Modificar";
            BTN_MODIFICAR.UseVisualStyleBackColor = true;
            // 
            // PICKER
            // 
            PICKER.Location = new Point(115, 248);
            PICKER.Name = "PICKER";
            PICKER.Size = new Size(281, 23);
            PICKER.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 254);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 5;
            label1.Text = "Fecha Ingreso";
            // 
            // CB_ADM
            // 
            CB_ADM.AutoSize = true;
            CB_ADM.Location = new Point(5, 29);
            CB_ADM.Name = "CB_ADM";
            CB_ADM.Size = new Size(104, 19);
            CB_ADM.TabIndex = 6;
            CB_ADM.Text = "Administrativo";
            CB_ADM.UseVisualStyleBackColor = true;
            // 
            // CB_OP
            // 
            CB_OP.AutoSize = true;
            CB_OP.Location = new Point(136, 29);
            CB_OP.Name = "CB_OP";
            CB_OP.Size = new Size(72, 19);
            CB_OP.TabIndex = 7;
            CB_OP.Text = "Operario";
            CB_OP.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CB_OP);
            groupBox1.Controls.Add(CB_ADM);
            groupBox1.Location = new Point(115, 277);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(238, 48);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo";
            // 
            // TXT_BUSQUEDA
            // 
            TXT_BUSQUEDA.Location = new Point(197, 1);
            TXT_BUSQUEDA.Name = "TXT_BUSQUEDA";
            TXT_BUSQUEDA.Size = new Size(199, 23);
            TXT_BUSQUEDA.TabIndex = 9;
            TXT_BUSQUEDA.TextChanged += TXT_BUSQUEDA_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 4);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 10;
            label2.Text = "Busqueda Incremental";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Location = new Point(497, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(238, 76);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(136, 51);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(81, 19);
            checkBox4.TabIndex = 9;
            checkBox4.Text = "SueldoDes";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(5, 54);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(84, 19);
            checkBox3.TabIndex = 8;
            checkBox3.Text = "SueldoASC";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(136, 29);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(94, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Descendente";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(5, 29);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(88, 19);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Ascendente";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.MouseClick += checkBox2_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(label2);
            Controls.Add(TXT_BUSQUEDA);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(PICKER);
            Controls.Add(BTN_MODIFICAR);
            Controls.Add(BTN_ELIMINAR);
            Controls.Add(BTN_AGREGAR);
            Controls.Add(Grilla_Empleado);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Grilla_Empleado).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Grilla_Empleado;
        private Button BTN_AGREGAR;
        private Button BTN_ELIMINAR;
        private Button BTN_MODIFICAR;
        private DateTimePicker PICKER;
        private Label label1;
        private CheckBox CB_ADM;
        private CheckBox CB_OP;
        private GroupBox groupBox1;
        private TextBox TXT_BUSQUEDA;
        private Label label2;
        private GroupBox groupBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
    }
}

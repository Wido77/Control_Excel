namespace Control_Excel
{
    partial class Form1
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
            this.btnCargar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGrid = new System.Windows.Forms.Button();
            this.gbox1 = new System.Windows.Forms.GroupBox();
            this.btnMes = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblGastos = new System.Windows.Forms.Label();
            this.lblGastosR = new System.Windows.Forms.Label();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.lblIngresosR = new System.Windows.Forms.Label();
            this.lblAhorros = new System.Windows.Forms.Label();
            this.lblAhorrosR = new System.Windows.Forms.Label();
            this.btnQueries = new System.Windows.Forms.Button();
            this.lblDia1 = new System.Windows.Forms.Label();
            this.lblDisp1 = new System.Windows.Forms.Label();
            this.lblDisp31 = new System.Windows.Forms.Label();
            this.lblDia31 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbox2 = new System.Windows.Forms.GroupBox();
            this.btnConcepto = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gpboxMes = new System.Windows.Forms.GroupBox();
            this.gpboxConcepto = new System.Windows.Forms.GroupBox();
            this.lblIngresosC = new System.Windows.Forms.Label();
            this.lblIngresos2 = new System.Windows.Forms.Label();
            this.lblGastosC = new System.Windows.Forms.Label();
            this.lblGastos2 = new System.Windows.Forms.Label();
            this.lblSumatorioR = new System.Windows.Forms.Label();
            this.lblSumatorio = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbox3 = new System.Windows.Forms.GroupBox();
            this.btnAño = new System.Windows.Forms.Button();
            this.cboxAño = new System.Windows.Forms.ComboBox();
            this.btnPruebaForm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.gbox1.SuspendLayout();
            this.gbox2.SuspendLayout();
            this.gpboxMes.SuspendLayout();
            this.gpboxConcepto.SuspendLayout();
            this.gbox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Red;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Location = new System.Drawing.Point(1105, 819);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(141, 57);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Cargar en BBDD";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(12, 12);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.Size = new System.Drawing.Size(1077, 925);
            this.DataGridView1.TabIndex = 1;
            // 
            // btnGrid
            // 
            this.btnGrid.BackColor = System.Drawing.Color.Lime;
            this.btnGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrid.Location = new System.Drawing.Point(1120, 790);
            this.btnGrid.Name = "btnGrid";
            this.btnGrid.Size = new System.Drawing.Size(75, 23);
            this.btnGrid.TabIndex = 2;
            this.btnGrid.Text = "Cargar grid";
            this.btnGrid.UseVisualStyleBackColor = false;
            this.btnGrid.Click += new System.EventHandler(this.btnGrid_Click);
            // 
            // gbox1
            // 
            this.gbox1.Controls.Add(this.btnMes);
            this.gbox1.Controls.Add(this.comboBox1);
            this.gbox1.Controls.Add(this.gpboxMes);
            this.gbox1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbox1.Location = new System.Drawing.Point(1214, 74);
            this.gbox1.Name = "gbox1";
            this.gbox1.Size = new System.Drawing.Size(321, 170);
            this.gbox1.TabIndex = 3;
            this.gbox1.TabStop = false;
            this.gbox1.Text = "Mes";
            // 
            // btnMes
            // 
            this.btnMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMes.Location = new System.Drawing.Point(204, 14);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(93, 32);
            this.btnMes.TabIndex = 1;
            this.btnMes.Text = "Mes";
            this.btnMes.UseVisualStyleBackColor = false;
            this.btnMes.Click += new System.EventHandler(this.btnMes_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.comboBox1.Location = new System.Drawing.Point(12, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 0;
            // 
            // lblGastos
            // 
            this.lblGastos.AutoSize = true;
            this.lblGastos.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastos.Location = new System.Drawing.Point(111, 23);
            this.lblGastos.Name = "lblGastos";
            this.lblGastos.Size = new System.Drawing.Size(52, 19);
            this.lblGastos.TabIndex = 4;
            this.lblGastos.Text = "Gastos";
            // 
            // lblGastosR
            // 
            this.lblGastosR.BackColor = System.Drawing.Color.White;
            this.lblGastosR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGastosR.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastosR.ForeColor = System.Drawing.Color.Red;
            this.lblGastosR.Location = new System.Drawing.Point(115, 47);
            this.lblGastosR.Name = "lblGastosR";
            this.lblGastosR.Size = new System.Drawing.Size(79, 23);
            this.lblGastosR.TabIndex = 5;
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresos.Location = new System.Drawing.Point(6, 23);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(64, 19);
            this.lblIngresos.TabIndex = 6;
            this.lblIngresos.Text = "Ingresos";
            // 
            // lblIngresosR
            // 
            this.lblIngresosR.BackColor = System.Drawing.Color.White;
            this.lblIngresosR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIngresosR.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresosR.ForeColor = System.Drawing.Color.Green;
            this.lblIngresosR.Location = new System.Drawing.Point(6, 47);
            this.lblIngresosR.Name = "lblIngresosR";
            this.lblIngresosR.Size = new System.Drawing.Size(79, 23);
            this.lblIngresosR.TabIndex = 7;
            // 
            // lblAhorros
            // 
            this.lblAhorros.AutoSize = true;
            this.lblAhorros.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAhorros.Location = new System.Drawing.Point(213, 23);
            this.lblAhorros.Name = "lblAhorros";
            this.lblAhorros.Size = new System.Drawing.Size(57, 19);
            this.lblAhorros.TabIndex = 8;
            this.lblAhorros.Text = "Ahorros";
            // 
            // lblAhorrosR
            // 
            this.lblAhorrosR.BackColor = System.Drawing.Color.White;
            this.lblAhorrosR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAhorrosR.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAhorrosR.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAhorrosR.Location = new System.Drawing.Point(212, 47);
            this.lblAhorrosR.Name = "lblAhorrosR";
            this.lblAhorrosR.Size = new System.Drawing.Size(79, 23);
            this.lblAhorrosR.TabIndex = 9;
            // 
            // btnQueries
            // 
            this.btnQueries.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnQueries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQueries.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueries.ForeColor = System.Drawing.Color.Black;
            this.btnQueries.Location = new System.Drawing.Point(1250, 440);
            this.btnQueries.Name = "btnQueries";
            this.btnQueries.Size = new System.Drawing.Size(270, 55);
            this.btnQueries.TabIndex = 10;
            this.btnQueries.Text = "Consultas";
            this.btnQueries.UseVisualStyleBackColor = false;
            this.btnQueries.Click += new System.EventHandler(this.btnGrafico1_Click);
            // 
            // lblDia1
            // 
            this.lblDia1.AutoSize = true;
            this.lblDia1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia1.Location = new System.Drawing.Point(1116, 715);
            this.lblDia1.Name = "lblDia1";
            this.lblDia1.Size = new System.Drawing.Size(122, 19);
            this.lblDia1.TabIndex = 11;
            this.lblDia1.Text = "Disponible a día 1 ";
            // 
            // lblDisp1
            // 
            this.lblDisp1.BackColor = System.Drawing.Color.White;
            this.lblDisp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisp1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisp1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDisp1.Location = new System.Drawing.Point(1244, 711);
            this.lblDisp1.Name = "lblDisp1";
            this.lblDisp1.Size = new System.Drawing.Size(79, 23);
            this.lblDisp1.TabIndex = 12;
            // 
            // lblDisp31
            // 
            this.lblDisp31.BackColor = System.Drawing.Color.White;
            this.lblDisp31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisp31.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisp31.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDisp31.Location = new System.Drawing.Point(1244, 744);
            this.lblDisp31.Name = "lblDisp31";
            this.lblDisp31.Size = new System.Drawing.Size(79, 23);
            this.lblDisp31.TabIndex = 14;
            // 
            // lblDia31
            // 
            this.lblDia31.AutoSize = true;
            this.lblDia31.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia31.Location = new System.Drawing.Point(1108, 745);
            this.lblDia31.Name = "lblDia31";
            this.lblDia31.Size = new System.Drawing.Size(130, 19);
            this.lblDia31.TabIndex = 13;
            this.lblDia31.Text = "Disponible a día 31 ";
            // 
            // gbox2
            // 
            this.gbox2.Controls.Add(this.btnConcepto);
            this.gbox2.Controls.Add(this.comboBox2);
            this.gbox2.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbox2.Location = new System.Drawing.Point(1208, 530);
            this.gbox2.Name = "gbox2";
            this.gbox2.Size = new System.Drawing.Size(312, 55);
            this.gbox2.TabIndex = 4;
            this.gbox2.TabStop = false;
            this.gbox2.Text = "Concepto";
            // 
            // btnConcepto
            // 
            this.btnConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcepto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcepto.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConcepto.Location = new System.Drawing.Point(204, 14);
            this.btnConcepto.Name = "btnConcepto";
            this.btnConcepto.Size = new System.Drawing.Size(93, 32);
            this.btnConcepto.TabIndex = 1;
            this.btnConcepto.Text = "Buscar";
            this.btnConcepto.UseVisualStyleBackColor = true;
            this.btnConcepto.Click += new System.EventHandler(this.btnConcepto_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.comboBox2.Location = new System.Drawing.Point(6, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(188, 27);
            this.comboBox2.TabIndex = 0;
            // 
            // gpboxMes
            // 
            this.gpboxMes.Controls.Add(this.lblIngresosR);
            this.gpboxMes.Controls.Add(this.lblIngresos);
            this.gpboxMes.Controls.Add(this.lblGastosR);
            this.gpboxMes.Controls.Add(this.lblGastos);
            this.gpboxMes.Controls.Add(this.lblAhorrosR);
            this.gpboxMes.Controls.Add(this.lblAhorros);
            this.gpboxMes.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpboxMes.Location = new System.Drawing.Point(6, 67);
            this.gpboxMes.Name = "gpboxMes";
            this.gpboxMes.Size = new System.Drawing.Size(300, 83);
            this.gpboxMes.TabIndex = 15;
            this.gpboxMes.TabStop = false;
            // 
            // gpboxConcepto
            // 
            this.gpboxConcepto.Controls.Add(this.lblIngresosC);
            this.gpboxConcepto.Controls.Add(this.lblIngresos2);
            this.gpboxConcepto.Controls.Add(this.lblGastosC);
            this.gpboxConcepto.Controls.Add(this.lblGastos2);
            this.gpboxConcepto.Controls.Add(this.lblSumatorioR);
            this.gpboxConcepto.Controls.Add(this.lblSumatorio);
            this.gpboxConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpboxConcepto.Location = new System.Drawing.Point(1223, 333);
            this.gpboxConcepto.Name = "gpboxConcepto";
            this.gpboxConcepto.Size = new System.Drawing.Size(316, 83);
            this.gpboxConcepto.TabIndex = 16;
            this.gpboxConcepto.TabStop = false;
            // 
            // lblIngresosC
            // 
            this.lblIngresosC.BackColor = System.Drawing.Color.White;
            this.lblIngresosC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIngresosC.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresosC.ForeColor = System.Drawing.Color.Green;
            this.lblIngresosC.Location = new System.Drawing.Point(6, 47);
            this.lblIngresosC.Name = "lblIngresosC";
            this.lblIngresosC.Size = new System.Drawing.Size(79, 23);
            this.lblIngresosC.TabIndex = 7;
            // 
            // lblIngresos2
            // 
            this.lblIngresos2.AutoSize = true;
            this.lblIngresos2.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresos2.Location = new System.Drawing.Point(6, 23);
            this.lblIngresos2.Name = "lblIngresos2";
            this.lblIngresos2.Size = new System.Drawing.Size(64, 19);
            this.lblIngresos2.TabIndex = 6;
            this.lblIngresos2.Text = "Ingresos";
            // 
            // lblGastosC
            // 
            this.lblGastosC.BackColor = System.Drawing.Color.White;
            this.lblGastosC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGastosC.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastosC.ForeColor = System.Drawing.Color.Red;
            this.lblGastosC.Location = new System.Drawing.Point(115, 47);
            this.lblGastosC.Name = "lblGastosC";
            this.lblGastosC.Size = new System.Drawing.Size(79, 23);
            this.lblGastosC.TabIndex = 5;
            // 
            // lblGastos2
            // 
            this.lblGastos2.AutoSize = true;
            this.lblGastos2.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastos2.Location = new System.Drawing.Point(111, 23);
            this.lblGastos2.Name = "lblGastos2";
            this.lblGastos2.Size = new System.Drawing.Size(52, 19);
            this.lblGastos2.TabIndex = 4;
            this.lblGastos2.Text = "Gastos";
            // 
            // lblSumatorioR
            // 
            this.lblSumatorioR.BackColor = System.Drawing.Color.White;
            this.lblSumatorioR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSumatorioR.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumatorioR.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSumatorioR.Location = new System.Drawing.Point(223, 47);
            this.lblSumatorioR.Name = "lblSumatorioR";
            this.lblSumatorioR.Size = new System.Drawing.Size(79, 23);
            this.lblSumatorioR.TabIndex = 9;
            // 
            // lblSumatorio
            // 
            this.lblSumatorio.AutoSize = true;
            this.lblSumatorio.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumatorio.Location = new System.Drawing.Point(227, 23);
            this.lblSumatorio.Name = "lblSumatorio";
            this.lblSumatorio.Size = new System.Drawing.Size(75, 19);
            this.lblSumatorio.TabIndex = 8;
            this.lblSumatorio.Text = "Sumatorio";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.LightGray;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.Location = new System.Drawing.Point(1406, 766);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(93, 32);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbox3
            // 
            this.gbox3.Controls.Add(this.btnAño);
            this.gbox3.Controls.Add(this.cboxAño);
            this.gbox3.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbox3.Location = new System.Drawing.Point(1223, 13);
            this.gbox3.Name = "gbox3";
            this.gbox3.Size = new System.Drawing.Size(312, 55);
            this.gbox3.TabIndex = 4;
            this.gbox3.TabStop = false;
            this.gbox3.Text = "Año";
            // 
            // btnAño
            // 
            this.btnAño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAño.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAño.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAño.Location = new System.Drawing.Point(204, 14);
            this.btnAño.Name = "btnAño";
            this.btnAño.Size = new System.Drawing.Size(93, 32);
            this.btnAño.TabIndex = 1;
            this.btnAño.Text = "Año";
            this.btnAño.UseVisualStyleBackColor = false;
            this.btnAño.Click += new System.EventHandler(this.btnAño_Click);
            // 
            // cboxAño
            // 
            this.cboxAño.FormattingEnabled = true;
            this.cboxAño.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.cboxAño.Location = new System.Drawing.Point(6, 19);
            this.cboxAño.Name = "cboxAño";
            this.cboxAño.Size = new System.Drawing.Size(121, 27);
            this.cboxAño.TabIndex = 0;
            // 
            // btnPruebaForm
            // 
            this.btnPruebaForm.BackColor = System.Drawing.Color.LightGray;
            this.btnPruebaForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPruebaForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPruebaForm.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPruebaForm.Location = new System.Drawing.Point(1395, 715);
            this.btnPruebaForm.Name = "btnPruebaForm";
            this.btnPruebaForm.Size = new System.Drawing.Size(104, 32);
            this.btnPruebaForm.TabIndex = 17;
            this.btnPruebaForm.Text = "PruebaForm";
            this.btnPruebaForm.UseVisualStyleBackColor = false;
            this.btnPruebaForm.Click += new System.EventHandler(this.btnPruebaForm_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(1314, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Año + Mes";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1547, 949);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPruebaForm);
            this.Controls.Add(this.gbox3);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gpboxConcepto);
            this.Controls.Add(this.gbox2);
            this.Controls.Add(this.lblDisp31);
            this.Controls.Add(this.lblDia31);
            this.Controls.Add(this.lblDisp1);
            this.Controls.Add(this.lblDia1);
            this.Controls.Add(this.btnQueries);
            this.Controls.Add(this.gbox1);
            this.Controls.Add(this.btnGrid);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.btnCargar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.gbox1.ResumeLayout(false);
            this.gbox2.ResumeLayout(false);
            this.gpboxMes.ResumeLayout(false);
            this.gpboxMes.PerformLayout();
            this.gpboxConcepto.ResumeLayout(false);
            this.gpboxConcepto.PerformLayout();
            this.gbox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Button btnGrid;
        private System.Windows.Forms.GroupBox gbox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnMes;
        private System.Windows.Forms.Label lblGastos;
        private System.Windows.Forms.Label lblGastosR;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Label lblIngresosR;
        private System.Windows.Forms.Label lblAhorros;
        private System.Windows.Forms.Label lblAhorrosR;
        private System.Windows.Forms.Button btnQueries;
        private System.Windows.Forms.Label lblDia1;
        private System.Windows.Forms.Label lblDisp1;
        private System.Windows.Forms.Label lblDisp31;
        private System.Windows.Forms.Label lblDia31;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbox2;
        private System.Windows.Forms.Button btnConcepto;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox gpboxMes;
        private System.Windows.Forms.GroupBox gpboxConcepto;
        private System.Windows.Forms.Label lblIngresosC;
        private System.Windows.Forms.Label lblIngresos2;
        private System.Windows.Forms.Label lblGastosC;
        private System.Windows.Forms.Label lblGastos2;
        private System.Windows.Forms.Label lblSumatorioR;
        private System.Windows.Forms.Label lblSumatorio;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox gbox3;
        private System.Windows.Forms.ComboBox cboxAño;
        private System.Windows.Forms.Button btnPruebaForm;
        private System.Windows.Forms.Button btnAño;
        private System.Windows.Forms.Button button2;
    }
}


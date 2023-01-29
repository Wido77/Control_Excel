using System;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnCargar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGrid = new System.Windows.Forms.Button();
            this.gbox1 = new System.Windows.Forms.GroupBox();
            this.btnMes = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gpboxMes = new System.Windows.Forms.GroupBox();
            this.lblIngresosR = new System.Windows.Forms.Label();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.lblGastosR = new System.Windows.Forms.Label();
            this.lblGastos = new System.Windows.Forms.Label();
            this.lblAhorrosR = new System.Windows.Forms.Label();
            this.lblAhorros = new System.Windows.Forms.Label();
            this.btnQueries = new System.Windows.Forms.Button();
            this.lblDia1 = new System.Windows.Forms.Label();
            this.lblDisp1 = new System.Windows.Forms.Label();
            this.lblDisp31 = new System.Windows.Forms.Label();
            this.lblDia31 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbox2 = new System.Windows.Forms.GroupBox();
            this.btnConcepto = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
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
            this.btnAñoMes = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.lbox1 = new System.Windows.Forms.ListBox();
            this.lblResumen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.gbox1.SuspendLayout();
            this.gpboxMes.SuspendLayout();
            this.gbox2.SuspendLayout();
            this.gpboxConcepto.SuspendLayout();
            this.gbox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Red;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Location = new System.Drawing.Point(1097, 880);
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
            this.btnGrid.Location = new System.Drawing.Point(1250, 914);
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
            this.gbox1.Location = new System.Drawing.Point(1102, 74);
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
            // btnQueries
            // 
            this.btnQueries.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnQueries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQueries.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueries.ForeColor = System.Drawing.Color.Black;
            this.btnQueries.Location = new System.Drawing.Point(1118, 758);
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
            this.lblDia1.Location = new System.Drawing.Point(1216, 839);
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
            this.lblDisp1.Location = new System.Drawing.Point(1352, 835);
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
            this.lblDisp31.Location = new System.Drawing.Point(1352, 858);
            this.lblDisp31.Name = "lblDisp31";
            this.lblDisp31.Size = new System.Drawing.Size(79, 23);
            this.lblDisp31.TabIndex = 14;
            // 
            // lblDia31
            // 
            this.lblDia31.AutoSize = true;
            this.lblDia31.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia31.Location = new System.Drawing.Point(1216, 858);
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
            this.gbox2.Location = new System.Drawing.Point(1408, 758);
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
            // gpboxConcepto
            // 
            this.gpboxConcepto.Controls.Add(this.lblIngresosC);
            this.gpboxConcepto.Controls.Add(this.lblIngresos2);
            this.gpboxConcepto.Controls.Add(this.lblGastosC);
            this.gpboxConcepto.Controls.Add(this.lblGastos2);
            this.gpboxConcepto.Controls.Add(this.lblSumatorioR);
            this.gpboxConcepto.Controls.Add(this.lblSumatorio);
            this.gpboxConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpboxConcepto.Location = new System.Drawing.Point(1446, 88);
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
            this.btnCerrar.Location = new System.Drawing.Point(1446, 907);
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
            this.gbox3.Location = new System.Drawing.Point(1102, 13);
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
            this.btnPruebaForm.Location = new System.Drawing.Point(1437, 869);
            this.btnPruebaForm.Name = "btnPruebaForm";
            this.btnPruebaForm.Size = new System.Drawing.Size(104, 32);
            this.btnPruebaForm.TabIndex = 17;
            this.btnPruebaForm.Text = "PruebaForm";
            this.btnPruebaForm.UseVisualStyleBackColor = false;
            this.btnPruebaForm.Click += new System.EventHandler(this.btnPruebaForm_Click);
            // 
            // btnAñoMes
            // 
            this.btnAñoMes.BackColor = System.Drawing.Color.Red;
            this.btnAñoMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñoMes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñoMes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAñoMes.Location = new System.Drawing.Point(1437, 27);
            this.btnAñoMes.Name = "btnAñoMes";
            this.btnAñoMes.Size = new System.Drawing.Size(109, 32);
            this.btnAñoMes.TabIndex = 2;
            this.btnAñoMes.Text = "Año + Mes";
            this.btnAñoMes.UseVisualStyleBackColor = false;
            this.btnAñoMes.Click += new System.EventHandler(this.btnAñoMes_Click);
            // 
            // c1
            // 
            this.c1.BorderlineColor = System.Drawing.Color.Black;
            this.c1.BorderlineWidth = 3;
            chartArea1.Name = "ChartArea1";
            this.c1.ChartAreas.Add(chartArea1);
            legend1.Name = "Ingresos";
            this.c1.Legends.Add(legend1);
            this.c1.Location = new System.Drawing.Point(1114, 303);
            this.c1.Name = "c1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Ingresos";
            series1.Name = "Ingresos";
            this.c1.Series.Add(series1);
            this.c1.Size = new System.Drawing.Size(634, 431);
            this.c1.TabIndex = 18;
            this.c1.Text = "chart1";
            // 
            // btnGrafico
            // 
            this.btnGrafico.BackColor = System.Drawing.Color.Yellow;
            this.btnGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrafico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafico.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrafico.Location = new System.Drawing.Point(1565, 28);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(109, 32);
            this.btnGrafico.TabIndex = 19;
            this.btnGrafico.Text = "Grafico";
            this.btnGrafico.UseVisualStyleBackColor = false;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // lbox1
            // 
            this.lbox1.FormattingEnabled = true;
            this.lbox1.Location = new System.Drawing.Point(1590, 858);
            this.lbox1.Name = "lbox1";
            this.lbox1.Size = new System.Drawing.Size(120, 95);
            this.lbox1.TabIndex = 20;
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumen.Location = new System.Drawing.Point(1110, 254);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(356, 46);
            this.lblResumen.TabIndex = 21;
            this.lblResumen.Text = "Resumen Mensual";
            this.lblResumen.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1762, 1027);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.lbox1);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.btnAñoMes);
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
            this.gpboxMes.ResumeLayout(false);
            this.gpboxMes.PerformLayout();
            this.gbox2.ResumeLayout(false);
            this.gpboxConcepto.ResumeLayout(false);
            this.gpboxConcepto.PerformLayout();
            this.gbox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
        private System.Windows.Forms.Button btnAñoMes;
        private System.Windows.Forms.DataVisualization.Charting.Chart c1;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.ListBox lbox1;
        private System.Windows.Forms.Label lblResumen;
    }
}


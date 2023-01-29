
namespace Control_Excel
{
    partial class Grafico
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.c1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtboxEnero = new System.Windows.Forms.TextBox();
            this.txtBoxFebrero = new System.Windows.Forms.TextBox();
            this.cbox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1
            // 
            this.c1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.c1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.c1.Legends.Add(legend1);
            this.c1.Location = new System.Drawing.Point(12, 12);
            this.c1.Name = "c1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            this.c1.Series.Add(series1);
            this.c1.Size = new System.Drawing.Size(906, 404);
            this.c1.TabIndex = 0;
            this.c1.Text = "chart1";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(711, 441);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(98, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(820, 441);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(98, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtboxEnero
            // 
            this.txtboxEnero.Location = new System.Drawing.Point(25, 422);
            this.txtboxEnero.Name = "txtboxEnero";
            this.txtboxEnero.Size = new System.Drawing.Size(100, 20);
            this.txtboxEnero.TabIndex = 3;
            // 
            // txtBoxFebrero
            // 
            this.txtBoxFebrero.Location = new System.Drawing.Point(25, 454);
            this.txtBoxFebrero.Name = "txtBoxFebrero";
            this.txtBoxFebrero.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFebrero.TabIndex = 4;
            // 
            // cbox1
            // 
            this.cbox1.FormattingEnabled = true;
            this.cbox1.Location = new System.Drawing.Point(230, 443);
            this.cbox1.Name = "cbox1";
            this.cbox1.Size = new System.Drawing.Size(121, 21);
            this.cbox1.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(839, 130);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 6;
            // 
            // Grafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(971, 486);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cbox1);
            this.Controls.Add(this.txtBoxFebrero);
            this.Controls.Add(this.txtboxEnero);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.c1);
            this.Name = "Grafico";
            this.Text = "Grafico";
            ((System.ComponentModel.ISupportInitialize)(this.c1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart c1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtboxEnero;
        private System.Windows.Forms.TextBox txtBoxFebrero;
        private System.Windows.Forms.ComboBox cbox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

namespace Control_Excel
{
    partial class Queries
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
            this.gbox1 = new System.Windows.Forms.GroupBox();
            this.cbox4 = new System.Windows.Forms.ComboBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.cbox3 = new System.Windows.Forms.ComboBox();
            this.cbox2 = new System.Windows.Forms.ComboBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblIdmes = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbox1 = new System.Windows.Forms.ComboBox();
            this.rtxt1 = new System.Windows.Forms.RichTextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbox5 = new System.Windows.Forms.ComboBox();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.gbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox1
            // 
            this.gbox1.Controls.Add(this.lblConcepto);
            this.gbox1.Controls.Add(this.cbox5);
            this.gbox1.Controls.Add(this.cbox4);
            this.gbox1.Controls.Add(this.btnEjecutar);
            this.gbox1.Controls.Add(this.cbox3);
            this.gbox1.Controls.Add(this.cbox2);
            this.gbox1.Controls.Add(this.lblAño);
            this.gbox1.Controls.Add(this.lblIdmes);
            this.gbox1.Controls.Add(this.lblTipo);
            this.gbox1.Controls.Add(this.lblCampo);
            this.gbox1.Controls.Add(this.btnBuscar);
            this.gbox1.Controls.Add(this.cbox1);
            this.gbox1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbox1.Location = new System.Drawing.Point(12, 12);
            this.gbox1.Name = "gbox1";
            this.gbox1.Size = new System.Drawing.Size(403, 164);
            this.gbox1.TabIndex = 5;
            this.gbox1.TabStop = false;
            this.gbox1.Text = "Update DDBB";
            // 
            // cbox4
            // 
            this.cbox4.FormattingEnabled = true;
            this.cbox4.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.cbox4.Items.AddRange(new object[] {
            "Gastos",
            "Ingresos"});
            this.cbox4.Location = new System.Drawing.Point(131, 77);
            this.cbox4.Name = "cbox4";
            this.cbox4.Size = new System.Drawing.Size(121, 27);
            this.cbox4.TabIndex = 14;
            this.cbox4.Visible = false;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.BackColor = System.Drawing.Color.Red;
            this.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjecutar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.ForeColor = System.Drawing.Color.Black;
            this.btnEjecutar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEjecutar.Location = new System.Drawing.Point(294, 97);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(93, 32);
            this.btnEjecutar.TabIndex = 13;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = false;
            this.btnEjecutar.Visible = false;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // cbox3
            // 
            this.cbox3.FormattingEnabled = true;
            this.cbox3.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.cbox3.Location = new System.Drawing.Point(131, 117);
            this.cbox3.Name = "cbox3";
            this.cbox3.Size = new System.Drawing.Size(121, 27);
            this.cbox3.TabIndex = 12;
            this.cbox3.Visible = false;
            // 
            // cbox2
            // 
            this.cbox2.FormattingEnabled = true;
            this.cbox2.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.cbox2.Location = new System.Drawing.Point(131, 77);
            this.cbox2.Name = "cbox2";
            this.cbox2.Size = new System.Drawing.Size(121, 27);
            this.cbox2.TabIndex = 11;
            this.cbox2.Visible = false;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(80, 120);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(38, 19);
            this.lblAño.TabIndex = 9;
            this.lblAño.Text = "Año: ";
            this.lblAño.Visible = false;
            // 
            // lblIdmes
            // 
            this.lblIdmes.AutoSize = true;
            this.lblIdmes.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdmes.Location = new System.Drawing.Point(76, 80);
            this.lblIdmes.Name = "lblIdmes";
            this.lblIdmes.Size = new System.Drawing.Size(41, 19);
            this.lblIdmes.TabIndex = 8;
            this.lblIdmes.Text = "Mes: ";
            this.lblIdmes.Visible = false;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(76, 80);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(42, 19);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo: ";
            this.lblTipo.Visible = false;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.Location = new System.Drawing.Point(6, 35);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(119, 19);
            this.lblCampo.TabIndex = 7;
            this.lblCampo.Text = "Campo a cambiar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.Location = new System.Drawing.Point(294, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 32);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbox1
            // 
            this.cbox1.FormattingEnabled = true;
            this.cbox1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.cbox1.Items.AddRange(new object[] {
            "Mes + Año",
            "Tipo",
            "Concepto"});
            this.cbox1.Location = new System.Drawing.Point(131, 32);
            this.cbox1.Name = "cbox1";
            this.cbox1.Size = new System.Drawing.Size(121, 27);
            this.cbox1.TabIndex = 0;
            // 
            // rtxt1
            // 
            this.rtxt1.Location = new System.Drawing.Point(12, 182);
            this.rtxt1.Name = "rtxt1";
            this.rtxt1.Size = new System.Drawing.Size(403, 103);
            this.rtxt1.TabIndex = 6;
            this.rtxt1.Text = "";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.LightGray;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.Location = new System.Drawing.Point(143, 352);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(121, 32);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.Location = new System.Drawing.Point(143, 243);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 32);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Dale!";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbox5
            // 
            this.cbox5.FormattingEnabled = true;
            this.cbox5.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.cbox5.Location = new System.Drawing.Point(131, 77);
            this.cbox5.Name = "cbox5";
            this.cbox5.Size = new System.Drawing.Size(121, 27);
            this.cbox5.TabIndex = 15;
            this.cbox5.Visible = false;
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcepto.Location = new System.Drawing.Point(45, 80);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(72, 19);
            this.lblConcepto.TabIndex = 16;
            this.lblConcepto.Text = "Concepto:";
            this.lblConcepto.Visible = false;
            // 
            // Queries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 396);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.rtxt1);
            this.Controls.Add(this.gbox1);
            this.Name = "Queries";
            this.Text = "Consultas";
            this.gbox1.ResumeLayout(false);
            this.gbox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbox1;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblIdmes;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbox2;
        private System.Windows.Forms.ComboBox cbox3;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.RichTextBox rtxt1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbox4;
        private System.Windows.Forms.ComboBox cbox5;
        private System.Windows.Forms.Label lblConcepto;
    }
}
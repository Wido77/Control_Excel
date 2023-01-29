
namespace Control_Excel
{
    partial class Desglose
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
            this.dgvDesglose = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesglose)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDesglose
            // 
            this.dgvDesglose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesglose.Location = new System.Drawing.Point(12, 13);
            this.dgvDesglose.Name = "dgvDesglose";
            this.dgvDesglose.Size = new System.Drawing.Size(570, 325);
            this.dgvDesglose.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.LightGray;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.Location = new System.Drawing.Point(236, 344);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(93, 32);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseEnter += new System.EventHandler(this.OnMouseEnterbtnCerrar);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.OnMouseLeavebtnCerrar);
            // 
            // Desglose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 382);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvDesglose);
            this.Name = "Desglose";
            this.Text = "Desglose";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesglose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDesglose;
        private System.Windows.Forms.Button btnCerrar;
    }
}
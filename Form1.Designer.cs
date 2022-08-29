
namespace NeuronaArtificial
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
            this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            this.listBoxEntradas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownW1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownW2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBias = new System.Windows.Forms.NumericUpDown();
            this.buttonAnalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownW1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownW2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBias)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCanvas
            // 
            this.pictureBoxCanvas.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxCanvas.Name = "pictureBoxCanvas";
            this.pictureBoxCanvas.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCanvas.TabIndex = 0;
            this.pictureBoxCanvas.TabStop = false;
            this.pictureBoxCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCanvas_MouseClick);
            // 
            // listBoxEntradas
            // 
            this.listBoxEntradas.FormattingEnabled = true;
            this.listBoxEntradas.Location = new System.Drawing.Point(544, 280);
            this.listBoxEntradas.Name = "listBoxEntradas";
            this.listBoxEntradas.Size = new System.Drawing.Size(209, 225);
            this.listBoxEntradas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "W1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "W2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bias";
            // 
            // numericUpDownW1
            // 
            this.numericUpDownW1.DecimalPlaces = 1;
            this.numericUpDownW1.Location = new System.Drawing.Point(73, 24);
            this.numericUpDownW1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownW1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.numericUpDownW1.Name = "numericUpDownW1";
            this.numericUpDownW1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownW1.TabIndex = 5;
            this.numericUpDownW1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAnalizar);
            this.groupBox1.Controls.Add(this.numericUpDownBias);
            this.groupBox1.Controls.Add(this.numericUpDownW2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDownW1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(544, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 222);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // numericUpDownW2
            // 
            this.numericUpDownW2.DecimalPlaces = 1;
            this.numericUpDownW2.Location = new System.Drawing.Point(73, 66);
            this.numericUpDownW2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownW2.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.numericUpDownW2.Name = "numericUpDownW2";
            this.numericUpDownW2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownW2.TabIndex = 6;
            this.numericUpDownW2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownBias
            // 
            this.numericUpDownBias.DecimalPlaces = 1;
            this.numericUpDownBias.Location = new System.Drawing.Point(73, 106);
            this.numericUpDownBias.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownBias.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.numericUpDownBias.Name = "numericUpDownBias";
            this.numericUpDownBias.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBias.TabIndex = 7;
            this.numericUpDownBias.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // buttonAnalizar
            // 
            this.buttonAnalizar.Location = new System.Drawing.Point(64, 166);
            this.buttonAnalizar.Name = "buttonAnalizar";
            this.buttonAnalizar.Size = new System.Drawing.Size(75, 23);
            this.buttonAnalizar.TabIndex = 8;
            this.buttonAnalizar.Text = "Analizar";
            this.buttonAnalizar.UseVisualStyleBackColor = true;
            this.buttonAnalizar.Click += new System.EventHandler(this.buttonAnalizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 525);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxEntradas);
            this.Controls.Add(this.pictureBoxCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownW1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownW2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCanvas;
        private System.Windows.Forms.ListBox listBoxEntradas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownW1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAnalizar;
        private System.Windows.Forms.NumericUpDown numericUpDownBias;
        private System.Windows.Forms.NumericUpDown numericUpDownW2;
    }
}


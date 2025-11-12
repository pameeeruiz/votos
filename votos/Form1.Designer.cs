namespace votos
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
            this.dgvRepublicanos = new System.Windows.Forms.DataGridView();
            this.dgvDemocratas = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAgregarR = new System.Windows.Forms.Button();
            this.btnAgregard = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEliminard = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepublicanos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemocratas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRepublicanos
            // 
            this.dgvRepublicanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepublicanos.Location = new System.Drawing.Point(46, 233);
            this.dgvRepublicanos.Name = "dgvRepublicanos";
            this.dgvRepublicanos.RowHeadersWidth = 51;
            this.dgvRepublicanos.RowTemplate.Height = 24;
            this.dgvRepublicanos.Size = new System.Drawing.Size(255, 206);
            this.dgvRepublicanos.TabIndex = 2;
            // 
            // dgvDemocratas
            // 
            this.dgvDemocratas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDemocratas.Location = new System.Drawing.Point(450, 233);
            this.dgvDemocratas.Name = "dgvDemocratas";
            this.dgvDemocratas.RowHeadersWidth = 51;
            this.dgvDemocratas.RowTemplate.Height = 24;
            this.dgvDemocratas.Size = new System.Drawing.Size(255, 206);
            this.dgvDemocratas.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(319, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // btnAgregarR
            // 
            this.btnAgregarR.Location = new System.Drawing.Point(46, 445);
            this.btnAgregarR.Name = "btnAgregarR";
            this.btnAgregarR.Size = new System.Drawing.Size(107, 34);
            this.btnAgregarR.TabIndex = 5;
            this.btnAgregarR.Text = "Agregar";
            this.btnAgregarR.UseVisualStyleBackColor = true;
            this.btnAgregarR.Click += new System.EventHandler(this.btnAgregarR_Click);
            // 
            // btnAgregard
            // 
            this.btnAgregard.Location = new System.Drawing.Point(598, 445);
            this.btnAgregard.Name = "btnAgregard";
            this.btnAgregard.Size = new System.Drawing.Size(107, 34);
            this.btnAgregard.TabIndex = 6;
            this.btnAgregard.Text = "Agregar";
            this.btnAgregard.UseVisualStyleBackColor = true;
            this.btnAgregard.Click += new System.EventHandler(this.btnAgregard_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(184, 445);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 34);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEliminard
            // 
            this.btnEliminard.Location = new System.Drawing.Point(479, 445);
            this.btnEliminard.Name = "btnEliminard";
            this.btnEliminard.Size = new System.Drawing.Size(107, 34);
            this.btnEliminard.TabIndex = 8;
            this.btnEliminard.Text = "Eliminar";
            this.btnEliminard.UseVisualStyleBackColor = true;
            this.btnEliminard.Click += new System.EventHandler(this.btnEliminard_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(319, 481);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(107, 41);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(319, 421);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(107, 41);
            this.btnReiniciar.TabIndex = 10;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::votos.Properties.Resources.hillary;
            this.pictureBox2.Location = new System.Drawing.Point(463, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(226, 159);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::votos.Properties.Resources.dn;
            this.pictureBox1.Location = new System.Drawing.Point(65, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Republicanos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Democratas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnEliminard);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregard);
            this.Controls.Add(this.btnAgregarR);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgvDemocratas);
            this.Controls.Add(this.dgvRepublicanos);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepublicanos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemocratas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvRepublicanos;
        private System.Windows.Forms.DataGridView dgvDemocratas;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAgregarR;
        private System.Windows.Forms.Button btnAgregard;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEliminard;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


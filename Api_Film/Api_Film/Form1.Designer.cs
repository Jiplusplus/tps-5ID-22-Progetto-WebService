namespace Api_Film
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.titolo = new System.Windows.Forms.TextBox();
            this.invio = new System.Windows.Forms.Button();
            this.scelta = new System.Windows.Forms.ComboBox();
            this.checkBoxPlot = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.anno = new System.Windows.Forms.TextBox();
            this.domainUpDownType = new System.Windows.Forms.DomainUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxAnno = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titolo
            // 
            this.titolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titolo.Location = new System.Drawing.Point(295, 263);
            this.titolo.Name = "titolo";
            this.titolo.Size = new System.Drawing.Size(143, 31);
            this.titolo.TabIndex = 0;
            // 
            // invio
            // 
            this.invio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invio.Location = new System.Drawing.Point(412, 408);
            this.invio.Name = "invio";
            this.invio.Size = new System.Drawing.Size(121, 46);
            this.invio.TabIndex = 2;
            this.invio.Text = "INVIO";
            this.invio.UseVisualStyleBackColor = true;
            this.invio.Click += new System.EventHandler(this.invio_Click);
            // 
            // scelta
            // 
            this.scelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scelta.FormattingEnabled = true;
            this.scelta.Items.AddRange(new object[] {
            "Titolo",
            "IMDb ID"});
            this.scelta.Location = new System.Drawing.Point(209, 262);
            this.scelta.Name = "scelta";
            this.scelta.Size = new System.Drawing.Size(80, 33);
            this.scelta.TabIndex = 3;
            // 
            // checkBoxPlot
            // 
            this.checkBoxPlot.AutoSize = true;
            this.checkBoxPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPlot.Location = new System.Drawing.Point(578, 223);
            this.checkBoxPlot.Name = "checkBoxPlot";
            this.checkBoxPlot.Size = new System.Drawing.Size(151, 29);
            this.checkBoxPlot.TabIndex = 4;
            this.checkBoxPlot.Text = "Trama lunga\r\n";
            this.checkBoxPlot.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "INSERISCI I DATI RICHIESTI";
            // 
            // anno
            // 
            this.anno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anno.Location = new System.Drawing.Point(349, 317);
            this.anno.Name = "anno";
            this.anno.Size = new System.Drawing.Size(100, 31);
            this.anno.TabIndex = 6;
            // 
            // domainUpDownType
            // 
            this.domainUpDownType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainUpDownType.Items.Add("movie");
            this.domainUpDownType.Items.Add("series");
            this.domainUpDownType.Items.Add("episode");
            this.domainUpDownType.Location = new System.Drawing.Point(659, 302);
            this.domainUpDownType.Name = "domainUpDownType";
            this.domainUpDownType.Size = new System.Drawing.Size(98, 31);
            this.domainUpDownType.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(553, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo";
            // 
            // checkBoxAnno
            // 
            this.checkBoxAnno.AutoSize = true;
            this.checkBoxAnno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAnno.Location = new System.Drawing.Point(164, 319);
            this.checkBoxAnno.Name = "checkBoxAnno";
            this.checkBoxAnno.Size = new System.Drawing.Size(179, 29);
            this.checkBoxAnno.TabIndex = 10;
            this.checkBoxAnno.Text = "Cerca per anno";
            this.checkBoxAnno.UseVisualStyleBackColor = true;
            this.checkBoxAnno.CheckedChanged += new System.EventHandler(this.checkBoxAnno_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 107);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "RICERCA PER NOME O PER ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(962, 552);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.scelta);
            this.Controls.Add(this.titolo);
            this.Controls.Add(this.invio);
            this.Controls.Add(this.checkBoxAnno);
            this.Controls.Add(this.checkBoxPlot);
            this.Controls.Add(this.anno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.domainUpDownType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titolo;
        private System.Windows.Forms.Button invio;
        private System.Windows.Forms.ComboBox scelta;
        private System.Windows.Forms.CheckBox checkBoxPlot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox anno;
        private System.Windows.Forms.DomainUpDown domainUpDownType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxAnno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}


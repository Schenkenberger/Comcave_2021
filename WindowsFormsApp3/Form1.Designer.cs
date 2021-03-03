
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ausgabeZahl = new System.Windows.Forms.TextBox();
            this.nmb8 = new System.Windows.Forms.Button();
            this.nmb4 = new System.Windows.Forms.Button();
            this.nmb5 = new System.Windows.Forms.Button();
            this.nmb6 = new System.Windows.Forms.Button();
            this.nmb1 = new System.Windows.Forms.Button();
            this.nmb2 = new System.Windows.Forms.Button();
            this.nmb3 = new System.Windows.Forms.Button();
            this.nmb0 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.nmb7 = new System.Windows.Forms.Button();
            this.nmb9 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnErgebnis = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ausgabeZahl
            // 
            this.ausgabeZahl.Location = new System.Drawing.Point(12, 12);
            this.ausgabeZahl.Name = "ausgabeZahl";
            this.ausgabeZahl.Size = new System.Drawing.Size(319, 20);
            this.ausgabeZahl.TabIndex = 3;
            this.ausgabeZahl.TextChanged += new System.EventHandler(this.ausgabeZahl_TextChanged);
            // 
            // nmb8
            // 
            this.nmb8.Location = new System.Drawing.Point(93, 51);
            this.nmb8.Name = "nmb8";
            this.nmb8.Size = new System.Drawing.Size(75, 23);
            this.nmb8.TabIndex = 8;
            this.nmb8.Text = "8";
            this.nmb8.UseVisualStyleBackColor = true;
            this.nmb8.Click += new System.EventHandler(this.nmb8_Click);
            // 
            // nmb4
            // 
            this.nmb4.Location = new System.Drawing.Point(12, 80);
            this.nmb4.Name = "nmb4";
            this.nmb4.Size = new System.Drawing.Size(75, 23);
            this.nmb4.TabIndex = 9;
            this.nmb4.Text = "4";
            this.nmb4.UseVisualStyleBackColor = true;
            this.nmb4.Click += new System.EventHandler(this.nmb4_Click);
            // 
            // nmb5
            // 
            this.nmb5.Location = new System.Drawing.Point(93, 80);
            this.nmb5.Name = "nmb5";
            this.nmb5.Size = new System.Drawing.Size(75, 23);
            this.nmb5.TabIndex = 10;
            this.nmb5.Text = "5";
            this.nmb5.UseVisualStyleBackColor = true;
            this.nmb5.Click += new System.EventHandler(this.nmb5_Click);
            // 
            // nmb6
            // 
            this.nmb6.Location = new System.Drawing.Point(174, 80);
            this.nmb6.Name = "nmb6";
            this.nmb6.Size = new System.Drawing.Size(75, 23);
            this.nmb6.TabIndex = 11;
            this.nmb6.Text = "6";
            this.nmb6.UseVisualStyleBackColor = true;
            this.nmb6.Click += new System.EventHandler(this.nmb6_Click);
            // 
            // nmb1
            // 
            this.nmb1.Location = new System.Drawing.Point(12, 109);
            this.nmb1.Name = "nmb1";
            this.nmb1.Size = new System.Drawing.Size(75, 23);
            this.nmb1.TabIndex = 12;
            this.nmb1.Text = "1";
            this.nmb1.UseVisualStyleBackColor = true;
            this.nmb1.Click += new System.EventHandler(this.nmb1_Click);
            // 
            // nmb2
            // 
            this.nmb2.Location = new System.Drawing.Point(93, 109);
            this.nmb2.Name = "nmb2";
            this.nmb2.Size = new System.Drawing.Size(75, 23);
            this.nmb2.TabIndex = 13;
            this.nmb2.Text = "2";
            this.nmb2.UseVisualStyleBackColor = true;
            this.nmb2.Click += new System.EventHandler(this.nmb2_Click);
            // 
            // nmb3
            // 
            this.nmb3.Location = new System.Drawing.Point(174, 109);
            this.nmb3.Name = "nmb3";
            this.nmb3.Size = new System.Drawing.Size(75, 23);
            this.nmb3.TabIndex = 14;
            this.nmb3.Text = "3";
            this.nmb3.UseVisualStyleBackColor = true;
            this.nmb3.Click += new System.EventHandler(this.nmb3_Click);
            // 
            // nmb0
            // 
            this.nmb0.Location = new System.Drawing.Point(93, 138);
            this.nmb0.Name = "nmb0";
            this.nmb0.Size = new System.Drawing.Size(75, 23);
            this.nmb0.TabIndex = 15;
            this.nmb0.Text = "0";
            this.nmb0.UseVisualStyleBackColor = true;
            this.nmb0.Click += new System.EventHandler(this.nmb0_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(255, 51);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 16;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(255, 109);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(75, 23);
            this.btnMult.TabIndex = 18;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(255, 138);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 23);
            this.btnDiv.TabIndex = 19;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // nmb7
            // 
            this.nmb7.Location = new System.Drawing.Point(12, 51);
            this.nmb7.Name = "nmb7";
            this.nmb7.Size = new System.Drawing.Size(75, 23);
            this.nmb7.TabIndex = 20;
            this.nmb7.Text = "7";
            this.nmb7.UseVisualStyleBackColor = true;
            this.nmb7.Click += new System.EventHandler(this.nmb7_Click);
            // 
            // nmb9
            // 
            this.nmb9.Location = new System.Drawing.Point(174, 51);
            this.nmb9.Name = "nmb9";
            this.nmb9.Size = new System.Drawing.Size(75, 23);
            this.nmb9.TabIndex = 21;
            this.nmb9.Text = "9";
            this.nmb9.UseVisualStyleBackColor = true;
            this.nmb9.Click += new System.EventHandler(this.nmb9_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(255, 80);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 23);
            this.btnMinus.TabIndex = 22;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnErgebnis
            // 
            this.btnErgebnis.Location = new System.Drawing.Point(255, 167);
            this.btnErgebnis.Name = "btnErgebnis";
            this.btnErgebnis.Size = new System.Drawing.Size(75, 23);
            this.btnErgebnis.TabIndex = 23;
            this.btnErgebnis.Text = "=";
            this.btnErgebnis.UseVisualStyleBackColor = true;
            this.btnErgebnis.Click += new System.EventHandler(this.btnErgebnis_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(175, 138);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 201);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnErgebnis);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.nmb9);
            this.Controls.Add(this.nmb7);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.nmb0);
            this.Controls.Add(this.nmb3);
            this.Controls.Add(this.nmb2);
            this.Controls.Add(this.nmb1);
            this.Controls.Add(this.nmb6);
            this.Controls.Add(this.nmb5);
            this.Controls.Add(this.nmb4);
            this.Controls.Add(this.nmb8);
            this.Controls.Add(this.ausgabeZahl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ausgabeZahl;
        private System.Windows.Forms.Button nmb8;
        private System.Windows.Forms.Button nmb4;
        private System.Windows.Forms.Button nmb5;
        private System.Windows.Forms.Button nmb6;
        private System.Windows.Forms.Button nmb1;
        private System.Windows.Forms.Button nmb2;
        private System.Windows.Forms.Button nmb3;
        private System.Windows.Forms.Button nmb0;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button nmb7;
        private System.Windows.Forms.Button nmb9;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnErgebnis;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
    }
}



namespace WindowsFormsApp2
{
    partial class Taschenrechner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Taschenrechner));
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
            this.btnKlammerauf = new System.Windows.Forms.Button();
            this.btnKlammerzu = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ausgabeZahl
            // 
            this.ausgabeZahl.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ausgabeZahl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ausgabeZahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ausgabeZahl.Location = new System.Drawing.Point(3, 3);
            this.ausgabeZahl.Multiline = true;
            this.ausgabeZahl.Name = "ausgabeZahl";
            this.ausgabeZahl.Size = new System.Drawing.Size(281, 85);
            this.ausgabeZahl.TabIndex = 3;
            this.ausgabeZahl.TextChanged += new System.EventHandler(this.ausgabeZahl_TextChanged);
            // 
            // nmb8
            // 
            this.nmb8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nmb8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmb8.Location = new System.Drawing.Point(73, 58);
            this.nmb8.Name = "nmb8";
            this.nmb8.Size = new System.Drawing.Size(64, 49);
            this.nmb8.TabIndex = 8;
            this.nmb8.Text = "8";
            this.nmb8.UseVisualStyleBackColor = true;
            this.nmb8.Click += new System.EventHandler(this.nmb8_Click);
            // 
            // nmb4
            // 
            this.nmb4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nmb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmb4.Location = new System.Drawing.Point(3, 113);
            this.nmb4.Name = "nmb4";
            this.nmb4.Size = new System.Drawing.Size(64, 49);
            this.nmb4.TabIndex = 9;
            this.nmb4.Text = "4";
            this.nmb4.UseVisualStyleBackColor = true;
            this.nmb4.Click += new System.EventHandler(this.nmb4_Click);
            // 
            // nmb5
            // 
            this.nmb5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nmb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmb5.Location = new System.Drawing.Point(73, 113);
            this.nmb5.Name = "nmb5";
            this.nmb5.Size = new System.Drawing.Size(64, 49);
            this.nmb5.TabIndex = 10;
            this.nmb5.Text = "5";
            this.nmb5.UseVisualStyleBackColor = true;
            this.nmb5.Click += new System.EventHandler(this.nmb5_Click);
            // 
            // nmb6
            // 
            this.nmb6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nmb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmb6.Location = new System.Drawing.Point(143, 113);
            this.nmb6.Name = "nmb6";
            this.nmb6.Size = new System.Drawing.Size(64, 49);
            this.nmb6.TabIndex = 11;
            this.nmb6.Text = "6";
            this.nmb6.UseVisualStyleBackColor = true;
            this.nmb6.Click += new System.EventHandler(this.nmb6_Click);
            // 
            // nmb1
            // 
            this.nmb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nmb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmb1.Location = new System.Drawing.Point(3, 168);
            this.nmb1.Name = "nmb1";
            this.nmb1.Size = new System.Drawing.Size(64, 49);
            this.nmb1.TabIndex = 12;
            this.nmb1.Text = "1";
            this.nmb1.UseVisualStyleBackColor = true;
            this.nmb1.Click += new System.EventHandler(this.nmb1_Click);
            // 
            // nmb2
            // 
            this.nmb2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nmb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmb2.Location = new System.Drawing.Point(73, 168);
            this.nmb2.Name = "nmb2";
            this.nmb2.Size = new System.Drawing.Size(64, 49);
            this.nmb2.TabIndex = 13;
            this.nmb2.Text = "2";
            this.nmb2.UseVisualStyleBackColor = true;
            this.nmb2.Click += new System.EventHandler(this.nmb2_Click);
            // 
            // nmb3
            // 
            this.nmb3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nmb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmb3.Location = new System.Drawing.Point(143, 168);
            this.nmb3.Name = "nmb3";
            this.nmb3.Size = new System.Drawing.Size(64, 49);
            this.nmb3.TabIndex = 14;
            this.nmb3.Text = "3";
            this.nmb3.UseVisualStyleBackColor = true;
            this.nmb3.Click += new System.EventHandler(this.nmb3_Click);
            // 
            // nmb0
            // 
            this.nmb0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nmb0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmb0.Location = new System.Drawing.Point(73, 223);
            this.nmb0.Name = "nmb0";
            this.nmb0.Size = new System.Drawing.Size(64, 49);
            this.nmb0.TabIndex = 15;
            this.nmb0.Text = "0";
            this.nmb0.UseVisualStyleBackColor = true;
            this.nmb0.Click += new System.EventHandler(this.nmb0_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(213, 168);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(65, 49);
            this.btnPlus.TabIndex = 16;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMult
            // 
            this.btnMult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(213, 58);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(65, 49);
            this.btnMult.TabIndex = 18;
            this.btnMult.Text = "x";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(213, 3);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(65, 49);
            this.btnDiv.TabIndex = 19;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // nmb7
            // 
            this.nmb7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nmb7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmb7.Location = new System.Drawing.Point(3, 58);
            this.nmb7.Name = "nmb7";
            this.nmb7.Size = new System.Drawing.Size(64, 49);
            this.nmb7.TabIndex = 20;
            this.nmb7.Text = "7";
            this.nmb7.UseVisualStyleBackColor = true;
            this.nmb7.Click += new System.EventHandler(this.nmb7_Click);
            // 
            // nmb9
            // 
            this.nmb9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nmb9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmb9.Location = new System.Drawing.Point(143, 58);
            this.nmb9.Name = "nmb9";
            this.nmb9.Size = new System.Drawing.Size(64, 49);
            this.nmb9.TabIndex = 21;
            this.nmb9.Text = "9";
            this.nmb9.UseVisualStyleBackColor = true;
            this.nmb9.Click += new System.EventHandler(this.nmb9_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(213, 113);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(65, 49);
            this.btnMinus.TabIndex = 22;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnErgebnis
            // 
            this.btnErgebnis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnErgebnis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErgebnis.Location = new System.Drawing.Point(213, 223);
            this.btnErgebnis.Name = "btnErgebnis";
            this.btnErgebnis.Size = new System.Drawing.Size(65, 49);
            this.btnErgebnis.TabIndex = 23;
            this.btnErgebnis.Text = "=";
            this.btnErgebnis.UseVisualStyleBackColor = true;
            this.btnErgebnis.Click += new System.EventHandler(this.btnErgebnis_Click);
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(143, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 49);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnKlammerauf
            // 
            this.btnKlammerauf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKlammerauf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKlammerauf.Location = new System.Drawing.Point(3, 3);
            this.btnKlammerauf.Name = "btnKlammerauf";
            this.btnKlammerauf.Size = new System.Drawing.Size(64, 49);
            this.btnKlammerauf.TabIndex = 26;
            this.btnKlammerauf.Text = "(";
            this.btnKlammerauf.UseVisualStyleBackColor = true;
            this.btnKlammerauf.Click += new System.EventHandler(this.btnKlammerauf_Click);
            // 
            // btnKlammerzu
            // 
            this.btnKlammerzu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKlammerzu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKlammerzu.Location = new System.Drawing.Point(73, 3);
            this.btnKlammerzu.Name = "btnKlammerzu";
            this.btnKlammerzu.Size = new System.Drawing.Size(64, 49);
            this.btnKlammerzu.TabIndex = 27;
            this.btnKlammerzu.Text = ")";
            this.btnKlammerzu.UseVisualStyleBackColor = true;
            this.btnKlammerzu.Click += new System.EventHandler(this.btnKlammerzu_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ausgabeZahl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.48276F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.51724F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(287, 372);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.nmb0, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnClear, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnKlammerzu, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.nmb1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnKlammerauf, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.nmb2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.nmb3, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnDiv, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnMinus, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnMult, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnErgebnis, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.nmb5, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.nmb8, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnPlus, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.nmb9, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.nmb4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.nmb7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.nmb6, 2, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 94);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(281, 275);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // Taschenrechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 372);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Taschenrechner";
            this.Text = "Taschenrechner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnKlammerauf;
        private System.Windows.Forms.Button btnKlammerzu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}


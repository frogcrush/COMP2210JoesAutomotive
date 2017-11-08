namespace JoesAutomotive
{
    partial class Form1
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
            this.grpOilLube = new System.Windows.Forms.GroupBox();
            this.chk_ol_lubejob = new System.Windows.Forms.CheckBox();
            this.chk_ol_oilchange = new System.Windows.Forms.CheckBox();
            this.grpFlushes = new System.Windows.Forms.GroupBox();
            this.chk_f_trans = new System.Windows.Forms.CheckBox();
            this.chk_f_radflush = new System.Windows.Forms.CheckBox();
            this.grpMisc = new System.Windows.Forms.GroupBox();
            this.chk_tire = new System.Windows.Forms.CheckBox();
            this.chk_muffler = new System.Windows.Forms.CheckBox();
            this.chk_inspection = new System.Windows.Forms.CheckBox();
            this.grpPartsLabour = new System.Windows.Forms.GroupBox();
            this.txt_labour = new System.Windows.Forms.TextBox();
            this.txt_parts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtParts = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServiceLabour = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.grpOilLube.SuspendLayout();
            this.grpFlushes.SuspendLayout();
            this.grpMisc.SuspendLayout();
            this.grpPartsLabour.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOilLube
            // 
            this.grpOilLube.Controls.Add(this.chk_ol_lubejob);
            this.grpOilLube.Controls.Add(this.chk_ol_oilchange);
            this.grpOilLube.Location = new System.Drawing.Point(12, 12);
            this.grpOilLube.Name = "grpOilLube";
            this.grpOilLube.Size = new System.Drawing.Size(200, 79);
            this.grpOilLube.TabIndex = 0;
            this.grpOilLube.TabStop = false;
            this.grpOilLube.Text = "Oil && Lube";
            // 
            // chk_ol_lubejob
            // 
            this.chk_ol_lubejob.AutoSize = true;
            this.chk_ol_lubejob.Location = new System.Drawing.Point(6, 44);
            this.chk_ol_lubejob.Name = "chk_ol_lubejob";
            this.chk_ol_lubejob.Size = new System.Drawing.Size(112, 17);
            this.chk_ol_lubejob.TabIndex = 1;
            this.chk_ol_lubejob.Tag = "18.00";
            this.chk_ol_lubejob.Text = "Lube Job ($18.00)";
            this.chk_ol_lubejob.UseVisualStyleBackColor = true;
            // 
            // chk_ol_oilchange
            // 
            this.chk_ol_oilchange.AutoSize = true;
            this.chk_ol_oilchange.Location = new System.Drawing.Point(6, 21);
            this.chk_ol_oilchange.Name = "chk_ol_oilchange";
            this.chk_ol_oilchange.Size = new System.Drawing.Size(120, 17);
            this.chk_ol_oilchange.TabIndex = 0;
            this.chk_ol_oilchange.Tag = "26.00";
            this.chk_ol_oilchange.Text = "Oil Change ($26.00)";
            this.chk_ol_oilchange.UseVisualStyleBackColor = true;
            // 
            // grpFlushes
            // 
            this.grpFlushes.Controls.Add(this.chk_f_trans);
            this.grpFlushes.Controls.Add(this.chk_f_radflush);
            this.grpFlushes.Location = new System.Drawing.Point(218, 12);
            this.grpFlushes.Name = "grpFlushes";
            this.grpFlushes.Size = new System.Drawing.Size(200, 79);
            this.grpFlushes.TabIndex = 1;
            this.grpFlushes.TabStop = false;
            this.grpFlushes.Text = "Flushes";
            // 
            // chk_f_trans
            // 
            this.chk_f_trans.AutoSize = true;
            this.chk_f_trans.Location = new System.Drawing.Point(6, 42);
            this.chk_f_trans.Name = "chk_f_trans";
            this.chk_f_trans.Size = new System.Drawing.Size(157, 17);
            this.chk_f_trans.TabIndex = 1;
            this.chk_f_trans.Tag = "80.00";
            this.chk_f_trans.Text = "Transmission Flush ($80.00)";
            this.chk_f_trans.UseVisualStyleBackColor = true;
            // 
            // chk_f_radflush
            // 
            this.chk_f_radflush.AutoSize = true;
            this.chk_f_radflush.Location = new System.Drawing.Point(6, 19);
            this.chk_f_radflush.Name = "chk_f_radflush";
            this.chk_f_radflush.Size = new System.Drawing.Size(136, 17);
            this.chk_f_radflush.TabIndex = 0;
            this.chk_f_radflush.Tag = "30.00";
            this.chk_f_radflush.Text = "Radiator Flush ($30.00)";
            this.chk_f_radflush.UseVisualStyleBackColor = true;
            // 
            // grpMisc
            // 
            this.grpMisc.Controls.Add(this.chk_tire);
            this.grpMisc.Controls.Add(this.chk_muffler);
            this.grpMisc.Controls.Add(this.chk_inspection);
            this.grpMisc.Location = new System.Drawing.Point(12, 97);
            this.grpMisc.Name = "grpMisc";
            this.grpMisc.Size = new System.Drawing.Size(200, 100);
            this.grpMisc.TabIndex = 2;
            this.grpMisc.TabStop = false;
            this.grpMisc.Text = "Misc";
            // 
            // chk_tire
            // 
            this.chk_tire.AutoSize = true;
            this.chk_tire.Location = new System.Drawing.Point(7, 66);
            this.chk_tire.Name = "chk_tire";
            this.chk_tire.Size = new System.Drawing.Size(129, 17);
            this.chk_tire.TabIndex = 2;
            this.chk_tire.Tag = "20.00";
            this.chk_tire.Text = "Tire Rotation ($20.00)";
            this.chk_tire.UseVisualStyleBackColor = true;
            // 
            // chk_muffler
            // 
            this.chk_muffler.AutoSize = true;
            this.chk_muffler.Location = new System.Drawing.Point(6, 42);
            this.chk_muffler.Name = "chk_muffler";
            this.chk_muffler.Size = new System.Drawing.Size(149, 17);
            this.chk_muffler.TabIndex = 1;
            this.chk_muffler.Tag = "100.00";
            this.chk_muffler.Text = "Replace Muffler ($100.00)";
            this.chk_muffler.UseVisualStyleBackColor = true;
            // 
            // chk_inspection
            // 
            this.chk_inspection.AutoSize = true;
            this.chk_inspection.Location = new System.Drawing.Point(6, 19);
            this.chk_inspection.Name = "chk_inspection";
            this.chk_inspection.Size = new System.Drawing.Size(117, 17);
            this.chk_inspection.TabIndex = 0;
            this.chk_inspection.Tag = "15.00";
            this.chk_inspection.Text = "Inspection ($15.00)";
            this.chk_inspection.UseVisualStyleBackColor = true;
            // 
            // grpPartsLabour
            // 
            this.grpPartsLabour.Controls.Add(this.txt_labour);
            this.grpPartsLabour.Controls.Add(this.txt_parts);
            this.grpPartsLabour.Controls.Add(this.label2);
            this.grpPartsLabour.Controls.Add(this.label1);
            this.grpPartsLabour.Location = new System.Drawing.Point(218, 97);
            this.grpPartsLabour.Name = "grpPartsLabour";
            this.grpPartsLabour.Size = new System.Drawing.Size(200, 100);
            this.grpPartsLabour.TabIndex = 3;
            this.grpPartsLabour.TabStop = false;
            this.grpPartsLabour.Text = "Parts && Labour";
            // 
            // txt_labour
            // 
            this.txt_labour.Location = new System.Drawing.Point(73, 54);
            this.txt_labour.Name = "txt_labour";
            this.txt_labour.Size = new System.Drawing.Size(100, 20);
            this.txt_labour.TabIndex = 3;
            this.txt_labour.Tag = "value";
            // 
            // txt_parts
            // 
            this.txt_parts.Location = new System.Drawing.Point(73, 28);
            this.txt_parts.Name = "txt_parts";
            this.txt_parts.Size = new System.Drawing.Size(100, 20);
            this.txt_parts.TabIndex = 2;
            this.txt_parts.Tag = "value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Labour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parts";
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.txtTotal);
            this.grpSummary.Controls.Add(this.label6);
            this.grpSummary.Controls.Add(this.txtTax);
            this.grpSummary.Controls.Add(this.label5);
            this.grpSummary.Controls.Add(this.txtParts);
            this.grpSummary.Controls.Add(this.label4);
            this.grpSummary.Controls.Add(this.txtServiceLabour);
            this.grpSummary.Controls.Add(this.label3);
            this.grpSummary.Location = new System.Drawing.Point(12, 203);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(406, 135);
            this.grpSummary.TabIndex = 4;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(206, 97);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Fees";
            // 
            // txtTax
            // 
            this.txtTax.BackColor = System.Drawing.SystemColors.Control;
            this.txtTax.Enabled = false;
            this.txtTax.Location = new System.Drawing.Point(206, 71);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(100, 20);
            this.txtTax.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tax (on parts)";
            // 
            // txtParts
            // 
            this.txtParts.BackColor = System.Drawing.SystemColors.Control;
            this.txtParts.Enabled = false;
            this.txtParts.Location = new System.Drawing.Point(206, 45);
            this.txtParts.Name = "txtParts";
            this.txtParts.Size = new System.Drawing.Size(100, 20);
            this.txtParts.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Parts";
            // 
            // txtServiceLabour
            // 
            this.txtServiceLabour.BackColor = System.Drawing.SystemColors.Control;
            this.txtServiceLabour.Enabled = false;
            this.txtServiceLabour.Location = new System.Drawing.Point(206, 19);
            this.txtServiceLabour.Name = "txtServiceLabour";
            this.txtServiceLabour.Size = new System.Drawing.Size(100, 20);
            this.txtServiceLabour.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Services && Labour";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(343, 344);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(175, 344);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 344);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calculate Total";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 376);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.grpPartsLabour);
            this.Controls.Add(this.grpMisc);
            this.Controls.Add(this.grpFlushes);
            this.Controls.Add(this.grpOilLube);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Joe\'s Automotive";
            this.grpOilLube.ResumeLayout(false);
            this.grpOilLube.PerformLayout();
            this.grpFlushes.ResumeLayout(false);
            this.grpFlushes.PerformLayout();
            this.grpMisc.ResumeLayout(false);
            this.grpMisc.PerformLayout();
            this.grpPartsLabour.ResumeLayout(false);
            this.grpPartsLabour.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOilLube;
        private System.Windows.Forms.CheckBox chk_ol_lubejob;
        private System.Windows.Forms.CheckBox chk_ol_oilchange;
        private System.Windows.Forms.GroupBox grpFlushes;
        private System.Windows.Forms.CheckBox chk_f_trans;
        private System.Windows.Forms.CheckBox chk_f_radflush;
        private System.Windows.Forms.GroupBox grpMisc;
        private System.Windows.Forms.CheckBox chk_tire;
        private System.Windows.Forms.CheckBox chk_muffler;
        private System.Windows.Forms.CheckBox chk_inspection;
        private System.Windows.Forms.GroupBox grpPartsLabour;
        private System.Windows.Forms.TextBox txt_labour;
        private System.Windows.Forms.TextBox txt_parts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtParts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServiceLabour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalc;
    }
}


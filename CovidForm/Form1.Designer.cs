namespace CovidForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgwCountries = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNewConfirmed = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNewDeaths = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTotalConfirmed = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTotalDeaths = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtNewRecovered = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtTotalRecovered = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.labelTarih = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCountries)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwCountries
            // 
            this.dgwCountries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwCountries.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgwCountries.Location = new System.Drawing.Point(12, 247);
            this.dgwCountries.Name = "dgwCountries";
            this.dgwCountries.ReadOnly = true;
            this.dgwCountries.RowHeadersWidth = 51;
            this.dgwCountries.RowTemplate.Height = 24;
            this.dgwCountries.Size = new System.Drawing.Size(996, 424);
            this.dgwCountries.TabIndex = 0;
            this.dgwCountries.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCountries_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bugünkü Vaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bugünkü Vefat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bugünkü İyileşen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Toplam Vaka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Toplam Vefat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Toplam İyileşen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(940, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(928, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.txtNewConfirmed);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(62, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 78);
            this.panel1.TabIndex = 2;
            // 
            // txtNewConfirmed
            // 
            this.txtNewConfirmed.AutoSize = true;
            this.txtNewConfirmed.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewConfirmed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNewConfirmed.Location = new System.Drawing.Point(3, 21);
            this.txtNewConfirmed.Name = "txtNewConfirmed";
            this.txtNewConfirmed.Size = new System.Drawing.Size(295, 46);
            this.txtNewConfirmed.TabIndex = 1;
            this.txtNewConfirmed.Text = "Bugünkü Vaka";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.txtNewDeaths);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(363, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 78);
            this.panel2.TabIndex = 3;
            // 
            // txtNewDeaths
            // 
            this.txtNewDeaths.AutoSize = true;
            this.txtNewDeaths.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewDeaths.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNewDeaths.Location = new System.Drawing.Point(3, 20);
            this.txtNewDeaths.Name = "txtNewDeaths";
            this.txtNewDeaths.Size = new System.Drawing.Size(303, 46);
            this.txtNewDeaths.TabIndex = 1;
            this.txtNewDeaths.Text = "Bugünkü Vefat";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.txtTotalConfirmed);
            this.panel3.Controls.Add(this.label4);
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(62, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 78);
            this.panel3.TabIndex = 4;
            // 
            // txtTotalConfirmed
            // 
            this.txtTotalConfirmed.AutoSize = true;
            this.txtTotalConfirmed.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalConfirmed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTotalConfirmed.Location = new System.Drawing.Point(3, 20);
            this.txtTotalConfirmed.Name = "txtTotalConfirmed";
            this.txtTotalConfirmed.Size = new System.Drawing.Size(266, 46);
            this.txtTotalConfirmed.TabIndex = 1;
            this.txtTotalConfirmed.Text = "Toplam Vaka";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Controls.Add(this.txtTotalDeaths);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(363, 61);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(295, 78);
            this.panel4.TabIndex = 4;
            // 
            // txtTotalDeaths
            // 
            this.txtTotalDeaths.AutoSize = true;
            this.txtTotalDeaths.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDeaths.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTotalDeaths.Location = new System.Drawing.Point(3, 20);
            this.txtTotalDeaths.Name = "txtTotalDeaths";
            this.txtTotalDeaths.Size = new System.Drawing.Size(274, 46);
            this.txtTotalDeaths.TabIndex = 1;
            this.txtTotalDeaths.Text = "Toplam Vefat";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel5.Controls.Add(this.txtNewRecovered);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(664, 146);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(295, 78);
            this.panel5.TabIndex = 4;
            // 
            // txtNewRecovered
            // 
            this.txtNewRecovered.AutoSize = true;
            this.txtNewRecovered.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewRecovered.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNewRecovered.Location = new System.Drawing.Point(3, 20);
            this.txtNewRecovered.Name = "txtNewRecovered";
            this.txtNewRecovered.Size = new System.Drawing.Size(352, 46);
            this.txtNewRecovered.TabIndex = 1;
            this.txtNewRecovered.Text = "Bugünkü İyileşen";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel6.Controls.Add(this.txtTotalRecovered);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(664, 61);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(295, 78);
            this.panel6.TabIndex = 5;
            // 
            // txtTotalRecovered
            // 
            this.txtTotalRecovered.AutoSize = true;
            this.txtTotalRecovered.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalRecovered.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTotalRecovered.Location = new System.Drawing.Point(3, 20);
            this.txtTotalRecovered.Name = "txtTotalRecovered";
            this.txtTotalRecovered.Size = new System.Drawing.Size(323, 46);
            this.txtTotalRecovered.TabIndex = 1;
            this.txtTotalRecovered.Text = "Toplam İyileşen";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(776, 674);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(233, 17);
            this.lblUrl.TabIndex = 6;
            this.lblUrl.Text = "https://api.covid19api.com/summary";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(707, 674);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Kaynak :";
            // 
            // lblCountryName
            // 
            this.lblCountryName.AutoSize = true;
            this.lblCountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCountryName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCountryName.Location = new System.Drawing.Point(61, 9);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(175, 44);
            this.lblCountryName.TabIndex = 6;
            this.lblCountryName.Text = "Kaynak :";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(931, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 41);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // labelTarih
            // 
            this.labelTarih.AutoSize = true;
            this.labelTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTarih.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelTarih.Location = new System.Drawing.Point(598, 14);
            this.labelTarih.Name = "labelTarih";
            this.labelTarih.Size = new System.Drawing.Size(98, 25);
            this.labelTarih.TabIndex = 6;
            this.labelTarih.Text = "Kaynak :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1020, 697);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.labelTarih);
            this.Controls.Add(this.lblCountryName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgwCountries);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Covid Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCountries)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCountries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtNewConfirmed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtNewDeaths;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txtTotalConfirmed;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label txtTotalDeaths;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label txtNewRecovered;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label txtTotalRecovered;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label labelTarih;
    }
}


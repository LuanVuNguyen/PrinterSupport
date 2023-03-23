
namespace PrinterSupport
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_SaveSetup = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_printer3 = new System.Windows.Forms.ComboBox();
            this.cb_printer2 = new System.Windows.Forms.ComboBox();
            this.cb_printer_phieuuudai = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_printer_hoadon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_urlSever = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_SaveSetup);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(-2, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 213);
            this.panel1.TabIndex = 0;
            // 
            // btn_SaveSetup
            // 
            this.btn_SaveSetup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_SaveSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveSetup.Location = new System.Drawing.Point(133, 163);
            this.btn_SaveSetup.Name = "btn_SaveSetup";
            this.btn_SaveSetup.Size = new System.Drawing.Size(130, 42);
            this.btn_SaveSetup.TabIndex = 2;
            this.btn_SaveSetup.Text = "SAVE";
            this.btn_SaveSetup.UseVisualStyleBackColor = true;
            this.btn_SaveSetup.Click += new System.EventHandler(this.btn_SaveSetup_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cb_printer3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cb_printer2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cb_printer_phieuuudai, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_printer_hoadon, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(430, 147);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cb_printer3
            // 
            this.cb_printer3.FormattingEnabled = true;
            this.cb_printer3.Location = new System.Drawing.Point(134, 112);
            this.cb_printer3.Name = "cb_printer3";
            this.cb_printer3.Size = new System.Drawing.Size(292, 21);
            this.cb_printer3.TabIndex = 7;
            // 
            // cb_printer2
            // 
            this.cb_printer2.FormattingEnabled = true;
            this.cb_printer2.Location = new System.Drawing.Point(134, 76);
            this.cb_printer2.Name = "cb_printer2";
            this.cb_printer2.Size = new System.Drawing.Size(292, 21);
            this.cb_printer2.TabIndex = 6;
            // 
            // cb_printer_phieuuudai
            // 
            this.cb_printer_phieuuudai.FormattingEnabled = true;
            this.cb_printer_phieuuudai.Location = new System.Drawing.Point(134, 40);
            this.cb_printer_phieuuudai.Name = "cb_printer_phieuuudai";
            this.cb_printer_phieuuudai.Size = new System.Drawing.Size(292, 21);
            this.cb_printer_phieuuudai.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 73);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10);
            this.label4.Size = new System.Drawing.Size(79, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hóa Đơn 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 109);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10);
            this.label5.Size = new System.Drawing.Size(79, 33);
            this.label5.TabIndex = 3;
            this.label5.Text = "Hóa Đơn 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(70, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hóa Đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 37);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10);
            this.label3.Size = new System.Drawing.Size(90, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phiếu Ưu Đãi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_printer_hoadon
            // 
            this.cb_printer_hoadon.FormattingEnabled = true;
            this.cb_printer_hoadon.Location = new System.Drawing.Point(134, 4);
            this.cb_printer_hoadon.Name = "cb_printer_hoadon";
            this.cb_printer_hoadon.Size = new System.Drawing.Size(292, 21);
            this.cb_printer_hoadon.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TYPE";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_urlSever);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(5, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 33);
            this.panel2.TabIndex = 2;
            // 
            // txt_urlSever
            // 
            this.txt_urlSever.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_urlSever.Location = new System.Drawing.Point(108, 5);
            this.txt_urlSever.Name = "txt_urlSever";
            this.txt_urlSever.Size = new System.Drawing.Size(301, 20);
            this.txt_urlSever.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "DICRECTION PATH:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "SELECT DEVICE";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(427, 262);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "PRINTER SUPPORT";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SaveSetup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cb_printer3;
        private System.Windows.Forms.ComboBox cb_printer2;
        private System.Windows.Forms.ComboBox cb_printer_phieuuudai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_printer_hoadon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_urlSever;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}


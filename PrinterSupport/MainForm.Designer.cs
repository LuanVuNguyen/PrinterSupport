
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
            this.type_in3 = new System.Windows.Forms.Label();
            this.type_in4 = new System.Windows.Forms.Label();
            this.type_in1 = new System.Windows.Forms.Label();
            this.type_in2 = new System.Windows.Forms.Label();
            this.cb_printer_hoadon = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_SaveSetup);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(-2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 248);
            this.panel1.TabIndex = 0;
            // 
            // btn_SaveSetup
            // 
            this.btn_SaveSetup.AutoSize = true;
            this.btn_SaveSetup.BackColor = System.Drawing.Color.White;
            this.btn_SaveSetup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_SaveSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveSetup.Location = new System.Drawing.Point(133, 192);
            this.btn_SaveSetup.Name = "btn_SaveSetup";
            this.btn_SaveSetup.Size = new System.Drawing.Size(132, 50);
            this.btn_SaveSetup.TabIndex = 2;
            this.btn_SaveSetup.Text = "SAVE";
            this.btn_SaveSetup.UseVisualStyleBackColor = false;
            this.btn_SaveSetup.Click += new System.EventHandler(this.Btn_SaveSetup_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cb_printer3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cb_printer2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cb_printer_phieuuudai, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.type_in3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.type_in4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.type_in1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.type_in2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_printer_hoadon, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(437, 169);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cb_printer3
            // 
            this.cb_printer3.FormattingEnabled = true;
            this.cb_printer3.Location = new System.Drawing.Point(134, 137);
            this.cb_printer3.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.cb_printer3.Name = "cb_printer3";
            this.cb_printer3.Size = new System.Drawing.Size(292, 21);
            this.cb_printer3.TabIndex = 7;
            // 
            // cb_printer2
            // 
            this.cb_printer2.FormattingEnabled = true;
            this.cb_printer2.Location = new System.Drawing.Point(134, 95);
            this.cb_printer2.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.cb_printer2.Name = "cb_printer2";
            this.cb_printer2.Size = new System.Drawing.Size(292, 21);
            this.cb_printer2.TabIndex = 6;
            // 
            // cb_printer_phieuuudai
            // 
            this.cb_printer_phieuuudai.FormattingEnabled = true;
            this.cb_printer_phieuuudai.Location = new System.Drawing.Point(134, 53);
            this.cb_printer_phieuuudai.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.cb_printer_phieuuudai.Name = "cb_printer_phieuuudai";
            this.cb_printer_phieuuudai.Size = new System.Drawing.Size(292, 21);
            this.cb_printer_phieuuudai.TabIndex = 5;
            // 
            // type_in3
            // 
            this.type_in3.AutoSize = true;
            this.type_in3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_in3.Location = new System.Drawing.Point(4, 85);
            this.type_in3.Name = "type_in3";
            this.type_in3.Padding = new System.Windows.Forms.Padding(10);
            this.type_in3.Size = new System.Drawing.Size(96, 37);
            this.type_in3.TabIndex = 2;
            this.type_in3.Text = "Hóa Đơn 2";
            // 
            // type_in4
            // 
            this.type_in4.AutoSize = true;
            this.type_in4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_in4.Location = new System.Drawing.Point(4, 127);
            this.type_in4.Name = "type_in4";
            this.type_in4.Padding = new System.Windows.Forms.Padding(10);
            this.type_in4.Size = new System.Drawing.Size(96, 37);
            this.type_in4.TabIndex = 3;
            this.type_in4.Text = "Hóa Đơn 3";
            // 
            // type_in1
            // 
            this.type_in1.AutoSize = true;
            this.type_in1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_in1.Location = new System.Drawing.Point(4, 1);
            this.type_in1.Name = "type_in1";
            this.type_in1.Padding = new System.Windows.Forms.Padding(10);
            this.type_in1.Size = new System.Drawing.Size(84, 37);
            this.type_in1.TabIndex = 0;
            this.type_in1.Text = "Hóa Đơn";
            // 
            // type_in2
            // 
            this.type_in2.AutoSize = true;
            this.type_in2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_in2.Location = new System.Drawing.Point(4, 43);
            this.type_in2.Name = "type_in2";
            this.type_in2.Padding = new System.Windows.Forms.Padding(10);
            this.type_in2.Size = new System.Drawing.Size(111, 37);
            this.type_in2.TabIndex = 1;
            this.type_in2.Text = "Phiếu Ưu Đãi";
            this.type_in2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_printer_hoadon
            // 
            this.cb_printer_hoadon.FormattingEnabled = true;
            this.cb_printer_hoadon.Location = new System.Drawing.Point(134, 11);
            this.cb_printer_hoadon.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.cb_printer_hoadon.Name = "cb_printer_hoadon";
            this.cb_printer_hoadon.Size = new System.Drawing.Size(292, 21);
            this.cb_printer_hoadon.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 6);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "TYPE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 6);
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
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(423, 257);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRINTER SUPPORT";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button btn_SaveSetup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cb_printer3;
        private System.Windows.Forms.ComboBox cb_printer2;
        private System.Windows.Forms.ComboBox cb_printer_phieuuudai;
        private System.Windows.Forms.Label type_in2;
        private System.Windows.Forms.Label type_in3;
        private System.Windows.Forms.Label type_in4;
        private System.Windows.Forms.ComboBox cb_printer_hoadon;
        private System.Windows.Forms.Label type_in1;
        private System.Windows.Forms.Label label7;
    }
}


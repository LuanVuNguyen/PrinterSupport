
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
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Printed = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.status_socket = new System.Windows.Forms.PictureBox();
            this.txt_status = new System.Windows.Forms.Label();
            this.btn_SaveSetup = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_printer3 = new System.Windows.Forms.ComboBox();
            this.cb_printer_HoaDonTam = new System.Windows.Forms.ComboBox();
            this.cb_printer_phieuuudai = new System.Windows.Forms.ComboBox();
            this.type_in3 = new System.Windows.Forms.Label();
            this.type_in4 = new System.Windows.Forms.Label();
            this.type_in1 = new System.Windows.Forms.Label();
            this.type_in2 = new System.Windows.Forms.Label();
            this.cb_printer_hoadon = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.status_socket)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_Printed);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_SaveSetup);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(-6, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 231);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "PRINTED";
            // 
            // btn_Printed
            // 
            this.btn_Printed.BackColor = System.Drawing.Color.White;
            this.btn_Printed.Location = new System.Drawing.Point(233, 193);
            this.btn_Printed.Name = "btn_Printed";
            this.btn_Printed.Size = new System.Drawing.Size(70, 30);
            this.btn_Printed.TabIndex = 7;
            this.btn_Printed.Text = "VIEW";
            this.btn_Printed.UseVisualStyleBackColor = false;
            this.btn_Printed.Click += new System.EventHandler(this.btn_Printed_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "STATUS";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.status_socket);
            this.panel2.Controls.Add(this.txt_status);
            this.panel2.Location = new System.Drawing.Point(344, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(91, 29);
            this.panel2.TabIndex = 6;
            // 
            // status_socket
            // 
            this.status_socket.Location = new System.Drawing.Point(66, 5);
            this.status_socket.Name = "status_socket";
            this.status_socket.Size = new System.Drawing.Size(16, 16);
            this.status_socket.TabIndex = 4;
            this.status_socket.TabStop = false;
            // 
            // txt_status
            // 
            this.txt_status.AutoSize = true;
            this.txt_status.Location = new System.Drawing.Point(2, 6);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(61, 13);
            this.txt_status.TabIndex = 5;
            this.txt_status.Text = "Disconnect";
            // 
            // btn_SaveSetup
            // 
            this.btn_SaveSetup.AutoSize = true;
            this.btn_SaveSetup.BackColor = System.Drawing.Color.White;
            this.btn_SaveSetup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_SaveSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveSetup.Location = new System.Drawing.Point(52, 186);
            this.btn_SaveSetup.Name = "btn_SaveSetup";
            this.btn_SaveSetup.Size = new System.Drawing.Size(120, 40);
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
            this.tableLayoutPanel1.Controls.Add(this.cb_printer_HoaDonTam, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cb_printer_phieuuudai, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.type_in3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.type_in4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.type_in1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.type_in2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_printer_hoadon, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(433, 169);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cb_printer3
            // 
            this.cb_printer3.FormattingEnabled = true;
            this.cb_printer3.Location = new System.Drawing.Point(134, 137);
            this.cb_printer3.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.cb_printer3.Name = "cb_printer3";
            this.cb_printer3.Size = new System.Drawing.Size(288, 21);
            this.cb_printer3.TabIndex = 7;
            // 
            // cb_printer_HoaDonTam
            // 
            this.cb_printer_HoaDonTam.FormattingEnabled = true;
            this.cb_printer_HoaDonTam.Location = new System.Drawing.Point(134, 95);
            this.cb_printer_HoaDonTam.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.cb_printer_HoaDonTam.Name = "cb_printer_HoaDonTam";
            this.cb_printer_HoaDonTam.Size = new System.Drawing.Size(288, 21);
            this.cb_printer_HoaDonTam.TabIndex = 6;
            // 
            // cb_printer_phieuuudai
            // 
            this.cb_printer_phieuuudai.FormattingEnabled = true;
            this.cb_printer_phieuuudai.Location = new System.Drawing.Point(134, 53);
            this.cb_printer_phieuuudai.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.cb_printer_phieuuudai.Name = "cb_printer_phieuuudai";
            this.cb_printer_phieuuudai.Size = new System.Drawing.Size(288, 21);
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
            this.cb_printer_hoadon.Size = new System.Drawing.Size(287, 21);
            this.cb_printer_hoadon.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 7);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "TYPE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SELECT DEVICE";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(438, 244);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRINTER SUPPORT";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.status_socket)).EndInit();
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
        private System.Windows.Forms.ComboBox cb_printer_HoaDonTam;
        private System.Windows.Forms.ComboBox cb_printer_phieuuudai;
        private System.Windows.Forms.Label type_in2;
        private System.Windows.Forms.Label type_in3;
        private System.Windows.Forms.Label type_in4;
        private System.Windows.Forms.ComboBox cb_printer_hoadon;
        private System.Windows.Forms.Label type_in1;
        private System.Windows.Forms.PictureBox status_socket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_status;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Printed;
        private System.Windows.Forms.Label label4;
    }
}


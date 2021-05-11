
namespace QuanLyChungCu.View
{
    partial class Form_Hopdong
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtsearchNameID = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTsearch = new System.Windows.Forms.TextBox();
            this.Contract = new System.Windows.Forms.GroupBox();
            this.cbboxHD = new System.Windows.Forms.ComboBox();
            this.btSearchdate = new System.Windows.Forms.Button();
            this.dateTimePickerNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNgayKi = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btSort = new System.Windows.Forms.Button();
            this.cbbProperties = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.cbbthanhvien = new System.Windows.Forms.ComboBox();
            this.txtNamechuho = new System.Windows.Forms.TextBox();
            this.txtMAHO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Contract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Fuchsia;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(1316, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 747);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Fuchsia;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 737);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1316, 10);
            this.label2.TabIndex = 1;
            // 
            // BtsearchNameID
            // 
            this.BtsearchNameID.Location = new System.Drawing.Point(334, 216);
            this.BtsearchNameID.Name = "BtsearchNameID";
            this.BtsearchNameID.Size = new System.Drawing.Size(75, 39);
            this.BtsearchNameID.TabIndex = 2;
            this.BtsearchNameID.Text = "Search";
            this.BtsearchNameID.UseVisualStyleBackColor = true;
            this.BtsearchNameID.Click += new System.EventHandler(this.BtsearchNameID_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name or ID: ";
            // 
            // TXTsearch
            // 
            this.TXTsearch.Location = new System.Drawing.Point(116, 222);
            this.TXTsearch.Name = "TXTsearch";
            this.TXTsearch.Size = new System.Drawing.Size(161, 26);
            this.TXTsearch.TabIndex = 4;
            // 
            // Contract
            // 
            this.Contract.Controls.Add(this.cbboxHD);
            this.Contract.Controls.Add(this.btSearchdate);
            this.Contract.Controls.Add(this.dateTimePickerNgayHetHan);
            this.Contract.Controls.Add(this.dateTimePickerNgayKi);
            this.Contract.Location = new System.Drawing.Point(4, 0);
            this.Contract.Name = "Contract";
            this.Contract.Size = new System.Drawing.Size(574, 163);
            this.Contract.TabIndex = 5;
            this.Contract.TabStop = false;
            this.Contract.Text = "Hợp Đồng";
            // 
            // cbboxHD
            // 
            this.cbboxHD.FormattingEnabled = true;
            this.cbboxHD.Location = new System.Drawing.Point(6, 125);
            this.cbboxHD.Name = "cbboxHD";
            this.cbboxHD.Size = new System.Drawing.Size(329, 28);
            this.cbboxHD.TabIndex = 2;
            this.cbboxHD.SelectedIndexChanged += new System.EventHandler(this.cbboxHD_SelectedIndexChanged);
            // 
            // btSearchdate
            // 
            this.btSearchdate.Location = new System.Drawing.Point(427, 32);
            this.btSearchdate.Name = "btSearchdate";
            this.btSearchdate.Size = new System.Drawing.Size(87, 42);
            this.btSearchdate.TabIndex = 1;
            this.btSearchdate.Text = "search";
            this.btSearchdate.UseVisualStyleBackColor = true;
            this.btSearchdate.Click += new System.EventHandler(this.btSearchdate_Click);
            // 
            // dateTimePickerNgayHetHan
            // 
            this.dateTimePickerNgayHetHan.Location = new System.Drawing.Point(9, 58);
            this.dateTimePickerNgayHetHan.Name = "dateTimePickerNgayHetHan";
            this.dateTimePickerNgayHetHan.Size = new System.Drawing.Size(326, 26);
            this.dateTimePickerNgayHetHan.TabIndex = 0;
            // 
            // dateTimePickerNgayKi
            // 
            this.dateTimePickerNgayKi.Location = new System.Drawing.Point(9, 26);
            this.dateTimePickerNgayKi.Name = "dateTimePickerNgayKi";
            this.dateTimePickerNgayKi.Size = new System.Drawing.Size(326, 26);
            this.dateTimePickerNgayKi.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1273, 359);
            this.dataGridView1.TabIndex = 6;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(4, 668);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 42);
            this.btAdd.TabIndex = 7;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(202, 668);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 42);
            this.btEdit.TabIndex = 7;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(516, 668);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 42);
            this.btDelete.TabIndex = 7;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSort
            // 
            this.btSort.Location = new System.Drawing.Point(783, 668);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(75, 42);
            this.btSort.TabIndex = 7;
            this.btSort.Text = "Sort";
            this.btSort.UseVisualStyleBackColor = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // cbbProperties
            // 
            this.cbbProperties.FormattingEnabled = true;
            this.cbbProperties.Items.AddRange(new object[] {
            "Name",
            "ThoiHan",
            "GiaTien"});
            this.cbbProperties.Location = new System.Drawing.Point(932, 668);
            this.cbbProperties.Name = "cbbProperties";
            this.cbbProperties.Size = new System.Drawing.Size(345, 28);
            this.cbbProperties.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btExit);
            this.groupBox1.Controls.Add(this.btOK);
            this.groupBox1.Controls.Add(this.cbbthanhvien);
            this.groupBox1.Controls.Add(this.txtNamechuho);
            this.groupBox1.Controls.Add(this.txtMAHO);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(791, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 279);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm thông tin cá nhân nếu chưa từng thuê";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(331, 232);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(85, 37);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Refresh";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(123, 232);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(91, 37);
            this.btOK.TabIndex = 4;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // cbbthanhvien
            // 
            this.cbbthanhvien.FormattingEnabled = true;
            this.cbbthanhvien.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbbthanhvien.Location = new System.Drawing.Point(123, 167);
            this.cbbthanhvien.Name = "cbbthanhvien";
            this.cbbthanhvien.Size = new System.Drawing.Size(293, 28);
            this.cbbthanhvien.TabIndex = 3;
            // 
            // txtNamechuho
            // 
            this.txtNamechuho.Location = new System.Drawing.Point(123, 99);
            this.txtNamechuho.Name = "txtNamechuho";
            this.txtNamechuho.Size = new System.Drawing.Size(293, 26);
            this.txtNamechuho.TabIndex = 2;
            // 
            // txtMAHO
            // 
            this.txtMAHO.Location = new System.Drawing.Point(123, 36);
            this.txtMAHO.Name = "txtMAHO";
            this.txtMAHO.Size = new System.Drawing.Size(293, 26);
            this.txtMAHO.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số Thành Viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên Chủ Hộ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Hộ :";
            // 
            // Form_Hopdong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 747);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbProperties);
            this.Controls.Add(this.btSort);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Contract);
            this.Controls.Add(this.TXTsearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtsearchNameID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Hopdong";
            this.Text = "Form_TienNuoc";
            this.Contract.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtsearchNameID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTsearch;
        private System.Windows.Forms.GroupBox Contract;
        private System.Windows.Forms.Button btSearchdate;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayHetHan;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayKi;
        private System.Windows.Forms.ComboBox cbboxHD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSort;
        private System.Windows.Forms.ComboBox cbbProperties;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.ComboBox cbbthanhvien;
        private System.Windows.Forms.TextBox txtNamechuho;
        private System.Windows.Forms.TextBox txtMAHO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btOK;
    }
}
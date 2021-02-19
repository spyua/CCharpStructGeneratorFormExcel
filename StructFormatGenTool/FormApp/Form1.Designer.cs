
namespace FormApp
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.group_excel_set = new System.Windows.Forms.GroupBox();
            this.edit_star_column = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edit_star_raw = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.edit_star_sheet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_export = new System.Windows.Forms.Button();
            this.LV_MSG = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Tb_OutputFileName = new System.Windows.Forms.TextBox();
            this.btn_save_path = new System.Windows.Forms.Button();
            this.cbx_export_format = new System.Windows.Forms.ComboBox();
            this.btn_select_path = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_save_path = new System.Windows.Forms.TextBox();
            this.tb_select_path = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.group_excel_set.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(953, 559);
            this.tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.group_excel_set);
            this.tabPage1.Controls.Add(this.btn_export);
            this.tabPage1.Controls.Add(this.LV_MSG);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(945, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Excel Export Strct";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // group_excel_set
            // 
            this.group_excel_set.Controls.Add(this.edit_star_column);
            this.group_excel_set.Controls.Add(this.label3);
            this.group_excel_set.Controls.Add(this.edit_star_raw);
            this.group_excel_set.Controls.Add(this.pictureBox1);
            this.group_excel_set.Controls.Add(this.edit_star_sheet);
            this.group_excel_set.Controls.Add(this.label2);
            this.group_excel_set.Controls.Add(this.label1);
            this.group_excel_set.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_excel_set.Location = new System.Drawing.Point(643, 16);
            this.group_excel_set.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_excel_set.Name = "group_excel_set";
            this.group_excel_set.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_excel_set.Size = new System.Drawing.Size(296, 131);
            this.group_excel_set.TabIndex = 38;
            this.group_excel_set.TabStop = false;
            this.group_excel_set.Text = "Readding Setting";
            // 
            // edit_star_column
            // 
            this.edit_star_column.Location = new System.Drawing.Point(210, 87);
            this.edit_star_column.Name = "edit_star_column";
            this.edit_star_column.Size = new System.Drawing.Size(71, 22);
            this.edit_star_column.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 14);
            this.label3.TabIndex = 31;
            this.label3.Text = "START COLUMN";
            // 
            // edit_star_raw
            // 
            this.edit_star_raw.Location = new System.Drawing.Point(210, 59);
            this.edit_star_raw.Name = "edit_star_raw";
            this.edit_star_raw.Size = new System.Drawing.Size(71, 22);
            this.edit_star_raw.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // edit_star_sheet
            // 
            this.edit_star_sheet.Location = new System.Drawing.Point(210, 28);
            this.edit_star_sheet.Name = "edit_star_sheet";
            this.edit_star_sheet.Size = new System.Drawing.Size(71, 22);
            this.edit_star_sheet.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 30;
            this.label2.Text = "START RAW";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.TabIndex = 29;
            this.label1.Text = "START SHEET";
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_export.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_export.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_export.Location = new System.Drawing.Point(798, 152);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(130, 60);
            this.btn_export.TabIndex = 37;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // LV_MSG
            // 
            this.LV_MSG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LV_MSG.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.LV_MSG.FullRowSelect = true;
            this.LV_MSG.GridLines = true;
            this.LV_MSG.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LV_MSG.HideSelection = false;
            this.LV_MSG.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.LV_MSG.Location = new System.Drawing.Point(16, 251);
            this.LV_MSG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LV_MSG.MultiSelect = false;
            this.LV_MSG.Name = "LV_MSG";
            this.LV_MSG.ShowItemToolTips = true;
            this.LV_MSG.Size = new System.Drawing.Size(912, 277);
            this.LV_MSG.TabIndex = 35;
            this.LV_MSG.UseCompatibleStateImageBehavior = false;
            this.LV_MSG.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Event";
            this.columnHeader2.Width = 934;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Tb_OutputFileName);
            this.groupBox2.Controls.Add(this.btn_save_path);
            this.groupBox2.Controls.Add(this.cbx_export_format);
            this.groupBox2.Controls.Add(this.btn_select_path);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_save_path);
            this.groupBox2.Controls.Add(this.tb_select_path);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(603, 196);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ExcelPathSetting";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 14);
            this.label8.TabIndex = 39;
            this.label8.Text = "OutPut File Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 14);
            this.label4.TabIndex = 32;
            this.label4.Text = "Export Format:";
            // 
            // Tb_OutputFileName
            // 
            this.Tb_OutputFileName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_OutputFileName.Location = new System.Drawing.Point(148, 155);
            this.Tb_OutputFileName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tb_OutputFileName.Name = "Tb_OutputFileName";
            this.Tb_OutputFileName.Size = new System.Drawing.Size(135, 22);
            this.Tb_OutputFileName.TabIndex = 40;
            // 
            // btn_save_path
            // 
            this.btn_save_path.Location = new System.Drawing.Point(501, 73);
            this.btn_save_path.Name = "btn_save_path";
            this.btn_save_path.Size = new System.Drawing.Size(96, 23);
            this.btn_save_path.TabIndex = 10;
            this.btn_save_path.Text = "Save Path";
            this.btn_save_path.UseVisualStyleBackColor = true;
            this.btn_save_path.Click += new System.EventHandler(this.btn_save_path_Click);
            // 
            // cbx_export_format
            // 
            this.cbx_export_format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_export_format.FormattingEnabled = true;
            this.cbx_export_format.Location = new System.Drawing.Point(138, 114);
            this.cbx_export_format.Name = "cbx_export_format";
            this.cbx_export_format.Size = new System.Drawing.Size(162, 22);
            this.cbx_export_format.TabIndex = 30;
            // 
            // btn_select_path
            // 
            this.btn_select_path.Location = new System.Drawing.Point(501, 40);
            this.btn_select_path.Name = "btn_select_path";
            this.btn_select_path.Size = new System.Drawing.Size(96, 23);
            this.btn_select_path.TabIndex = 9;
            this.btn_select_path.Text = "Select File";
            this.btn_select_path.UseVisualStyleBackColor = true;
            this.btn_select_path.Click += new System.EventHandler(this.btn_select_path_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "Source Path:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Export Path:";
            // 
            // tb_save_path
            // 
            this.tb_save_path.Enabled = false;
            this.tb_save_path.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_save_path.Location = new System.Drawing.Point(119, 74);
            this.tb_save_path.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_save_path.Name = "tb_save_path";
            this.tb_save_path.Size = new System.Drawing.Size(376, 22);
            this.tb_save_path.TabIndex = 1;
            // 
            // tb_select_path
            // 
            this.tb_select_path.Enabled = false;
            this.tb_select_path.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_select_path.Location = new System.Drawing.Point(119, 41);
            this.tb_select_path.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_select_path.Name = "tb_select_path";
            this.tb_select_path.Size = new System.Drawing.Size(376, 22);
            this.tb_select_path.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 612);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.group_excel_set.ResumeLayout(false);
            this.group_excel_set.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Tb_OutputFileName;
        private System.Windows.Forms.GroupBox group_excel_set;
        private System.Windows.Forms.TextBox edit_star_column;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edit_star_raw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox edit_star_sheet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.ListView LV_MSG;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_save_path;
        private System.Windows.Forms.ComboBox cbx_export_format;
        private System.Windows.Forms.Button btn_select_path;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_save_path;
        private System.Windows.Forms.TextBox tb_select_path;
    }
}


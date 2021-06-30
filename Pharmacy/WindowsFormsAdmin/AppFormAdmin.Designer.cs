
namespace WindowsFormsAdmin
{
    partial class AppFormAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.med_refresh = new System.Windows.Forms.Button();
            this.med_details = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.med_delete = new System.Windows.Forms.Button();
            this.med_create = new System.Windows.Forms.Button();
            this.med_storageTemperature = new System.Windows.Forms.TextBox();
            this.med_amount = new System.Windows.Forms.TextBox();
            this.med_expirationDate = new System.Windows.Forms.TextBox();
            this.med_name = new System.Windows.Forms.TextBox();
            this.med_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cos_storageTemperature = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cos_refresh = new System.Windows.Forms.Button();
            this.cos_details = new System.Windows.Forms.Button();
            this.cos_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cos_create = new System.Windows.Forms.Button();
            this.cos_capacity = new System.Windows.Forms.TextBox();
            this.cos_amount = new System.Windows.Forms.TextBox();
            this.cos_expirationDate = new System.Windows.Forms.TextBox();
            this.cos_name = new System.Windows.Forms.TextBox();
            this.cos_Id = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1188, 750);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.Form_Load);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SandyBrown;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(1180, 712);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MedicineTable";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.med_refresh);
            this.panel2.Controls.Add(this.med_details);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.med_delete);
            this.panel2.Controls.Add(this.med_create);
            this.panel2.Controls.Add(this.med_storageTemperature);
            this.panel2.Controls.Add(this.med_amount);
            this.panel2.Controls.Add(this.med_expirationDate);
            this.panel2.Controls.Add(this.med_name);
            this.panel2.Controls.Add(this.med_Id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(32, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1106, 171);
            this.panel2.TabIndex = 1;
            // 
            // med_refresh
            // 
            this.med_refresh.BackColor = System.Drawing.Color.Chocolate;
            this.med_refresh.Location = new System.Drawing.Point(940, 115);
            this.med_refresh.Name = "med_refresh";
            this.med_refresh.Size = new System.Drawing.Size(137, 34);
            this.med_refresh.TabIndex = 18;
            this.med_refresh.Text = "Refresh";
            this.med_refresh.UseVisualStyleBackColor = false;
            this.med_refresh.Click += new System.EventHandler(this.Med_Refresh_Click);
            // 
            // med_details
            // 
            this.med_details.BackColor = System.Drawing.Color.Chocolate;
            this.med_details.Location = new System.Drawing.Point(20, 115);
            this.med_details.Name = "med_details";
            this.med_details.Size = new System.Drawing.Size(223, 34);
            this.med_details.TabIndex = 17;
            this.med_details.Text = "Current Product Details";
            this.med_details.UseVisualStyleBackColor = false;
            this.med_details.Click += new System.EventHandler(this.Med_Product_Details_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(621, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Temper. :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(473, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Amount :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Exp. Date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Id :";
            // 
            // med_delete
            // 
            this.med_delete.BackColor = System.Drawing.Color.Chocolate;
            this.med_delete.Location = new System.Drawing.Point(267, 115);
            this.med_delete.Name = "med_delete";
            this.med_delete.Size = new System.Drawing.Size(239, 34);
            this.med_delete.TabIndex = 10;
            this.med_delete.Text = "Delete Current Product";
            this.med_delete.UseVisualStyleBackColor = false;
            this.med_delete.Click += new System.EventHandler(this.Med_Delete_Product_Click);
            // 
            // med_create
            // 
            this.med_create.BackColor = System.Drawing.Color.Chocolate;
            this.med_create.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.med_create.Location = new System.Drawing.Point(923, 13);
            this.med_create.Margin = new System.Windows.Forms.Padding(0);
            this.med_create.Name = "med_create";
            this.med_create.Size = new System.Drawing.Size(154, 34);
            this.med_create.TabIndex = 9;
            this.med_create.Text = "Create Product";
            this.med_create.UseVisualStyleBackColor = false;
            this.med_create.Click += new System.EventHandler(this.Med_Create_Click);
            // 
            // med_storageTemperature
            // 
            this.med_storageTemperature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.med_storageTemperature.Location = new System.Drawing.Point(713, 15);
            this.med_storageTemperature.Name = "med_storageTemperature";
            this.med_storageTemperature.Size = new System.Drawing.Size(50, 31);
            this.med_storageTemperature.TabIndex = 8;
            // 
            // med_amount
            // 
            this.med_amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.med_amount.Location = new System.Drawing.Point(568, 15);
            this.med_amount.Name = "med_amount";
            this.med_amount.Size = new System.Drawing.Size(47, 31);
            this.med_amount.TabIndex = 7;
            // 
            // med_expirationDate
            // 
            this.med_expirationDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.med_expirationDate.Location = new System.Drawing.Point(380, 15);
            this.med_expirationDate.Name = "med_expirationDate";
            this.med_expirationDate.Size = new System.Drawing.Size(87, 31);
            this.med_expirationDate.TabIndex = 6;
            // 
            // med_name
            // 
            this.med_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.med_name.Location = new System.Drawing.Point(187, 15);
            this.med_name.Name = "med_name";
            this.med_name.Size = new System.Drawing.Size(83, 31);
            this.med_name.TabIndex = 5;
            // 
            // med_Id
            // 
            this.med_Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.med_Id.Location = new System.Drawing.Point(47, 15);
            this.med_Id.Name = "med_Id";
            this.med_Id.Size = new System.Drawing.Size(58, 31);
            this.med_Id.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-415, -127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add Product";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1106, 482);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.tabPage2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1180, 712);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CosmeticTable";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cos_storageTemperature);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cos_refresh);
            this.panel1.Controls.Add(this.cos_details);
            this.panel1.Controls.Add(this.cos_delete);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cos_create);
            this.panel1.Controls.Add(this.cos_capacity);
            this.panel1.Controls.Add(this.cos_amount);
            this.panel1.Controls.Add(this.cos_expirationDate);
            this.panel1.Controls.Add(this.cos_name);
            this.panel1.Controls.Add(this.cos_Id);
            this.panel1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(27, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 166);
            this.panel1.TabIndex = 1;
            // 
            // cos_storageTemperature
            // 
            this.cos_storageTemperature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cos_storageTemperature.Location = new System.Drawing.Point(876, 13);
            this.cos_storageTemperature.Name = "cos_storageTemperature";
            this.cos_storageTemperature.Size = new System.Drawing.Size(57, 31);
            this.cos_storageTemperature.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(784, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 25);
            this.label12.TabIndex = 32;
            this.label12.Text = "Temper. :";
            // 
            // cos_refresh
            // 
            this.cos_refresh.BackColor = System.Drawing.Color.Teal;
            this.cos_refresh.Location = new System.Drawing.Point(967, 118);
            this.cos_refresh.Name = "cos_refresh";
            this.cos_refresh.Size = new System.Drawing.Size(137, 34);
            this.cos_refresh.TabIndex = 31;
            this.cos_refresh.Text = "Refresh";
            this.cos_refresh.UseVisualStyleBackColor = false;
            this.cos_refresh.Click += new System.EventHandler(this.Cos_Refresh_Click);
            // 
            // cos_details
            // 
            this.cos_details.BackColor = System.Drawing.Color.Teal;
            this.cos_details.Location = new System.Drawing.Point(14, 118);
            this.cos_details.Name = "cos_details";
            this.cos_details.Size = new System.Drawing.Size(223, 34);
            this.cos_details.TabIndex = 30;
            this.cos_details.Text = "Current Product Details";
            this.cos_details.UseVisualStyleBackColor = false;
            this.cos_details.Click += new System.EventHandler(this.Cos_Product_Details_Click);
            // 
            // cos_delete
            // 
            this.cos_delete.BackColor = System.Drawing.Color.Teal;
            this.cos_delete.Location = new System.Drawing.Point(259, 118);
            this.cos_delete.Name = "cos_delete";
            this.cos_delete.Size = new System.Drawing.Size(239, 34);
            this.cos_delete.TabIndex = 28;
            this.cos_delete.Text = "Delete Current Product";
            this.cos_delete.UseVisualStyleBackColor = false;
            this.cos_delete.Click += new System.EventHandler(this.Cos_Delete_Product_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(636, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Capacity :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Amount :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Exp. Date :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(126, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "Name :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "Id :";
            // 
            // cos_create
            // 
            this.cos_create.BackColor = System.Drawing.Color.Teal;
            this.cos_create.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cos_create.Location = new System.Drawing.Point(950, 11);
            this.cos_create.Name = "cos_create";
            this.cos_create.Size = new System.Drawing.Size(154, 34);
            this.cos_create.TabIndex = 22;
            this.cos_create.Text = "Create Product";
            this.cos_create.UseVisualStyleBackColor = false;
            this.cos_create.Click += new System.EventHandler(this.Cos_Create_Click);
            // 
            // cos_capacity
            // 
            this.cos_capacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cos_capacity.Location = new System.Drawing.Point(728, 13);
            this.cos_capacity.Name = "cos_capacity";
            this.cos_capacity.Size = new System.Drawing.Size(50, 31);
            this.cos_capacity.TabIndex = 21;
            // 
            // cos_amount
            // 
            this.cos_amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cos_amount.Location = new System.Drawing.Point(583, 13);
            this.cos_amount.Name = "cos_amount";
            this.cos_amount.Size = new System.Drawing.Size(47, 31);
            this.cos_amount.TabIndex = 20;
            // 
            // cos_expirationDate
            // 
            this.cos_expirationDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cos_expirationDate.Location = new System.Drawing.Point(395, 13);
            this.cos_expirationDate.Name = "cos_expirationDate";
            this.cos_expirationDate.Size = new System.Drawing.Size(87, 31);
            this.cos_expirationDate.TabIndex = 19;
            // 
            // cos_name
            // 
            this.cos_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cos_name.Location = new System.Drawing.Point(202, 13);
            this.cos_name.Name = "cos_name";
            this.cos_name.Size = new System.Drawing.Size(83, 31);
            this.cos_name.TabIndex = 18;
            // 
            // cos_Id
            // 
            this.cos_Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cos_Id.Location = new System.Drawing.Point(57, 13);
            this.cos_Id.Name = "cos_Id";
            this.cos_Id.Size = new System.Drawing.Size(63, 31);
            this.cos_Id.TabIndex = 17;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(27, 208);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(1115, 480);
            this.dataGridView2.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(548, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 28);
            this.label13.TabIndex = 1;
            this.label13.Text = "My Pharmacy";
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Name = "AppForm";
            this.Text = "WinAppAdmin";
            this.Load += new System.EventHandler(this.Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button med_delete;
        private System.Windows.Forms.Button med_create;
        private System.Windows.Forms.TextBox med_storageTemperature;
        private System.Windows.Forms.TextBox med_amount;
        private System.Windows.Forms.TextBox med_expirationDate;
        private System.Windows.Forms.TextBox med_name;
        private System.Windows.Forms.TextBox med_Id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button med_details;
        private System.Windows.Forms.Button med_refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cos_create;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox cos_amount;
        private System.Windows.Forms.TextBox cos_expirationDate;
        private System.Windows.Forms.TextBox cos_name;
        private System.Windows.Forms.TextBox cos_Id;
        private System.Windows.Forms.Button cos_refresh;
        private System.Windows.Forms.Button cos_details;
        private System.Windows.Forms.Button cos_delete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cos_storageTemperature;
        private System.Windows.Forms.TextBox cos;
        private System.Windows.Forms.TextBox cos_capacity;
        private System.Windows.Forms.Label label13;
    }
}


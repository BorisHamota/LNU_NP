
namespace WindowsFormsUser
{
    partial class AppFormUser
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
            this.label8 = new System.Windows.Forms.Label();
            this.med_open_cart = new System.Windows.Forms.Button();
            this.med_add_to_cart = new System.Windows.Forms.Button();
            this.med_amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cos_refresh = new System.Windows.Forms.Button();
            this.cos_open_cart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cos_add_to_cart = new System.Windows.Forms.Button();
            this.cos_amount = new System.Windows.Forms.TextBox();
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
            this.tabControl1.Size = new System.Drawing.Size(1191, 719);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SandyBrown;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(1183, 681);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MedicineTable";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.med_refresh);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.med_open_cart);
            this.panel2.Controls.Add(this.med_add_to_cart);
            this.panel2.Controls.Add(this.med_amount);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(32, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 171);
            this.panel2.TabIndex = 1;
            // 
            // med_refresh
            // 
            this.med_refresh.BackColor = System.Drawing.Color.Chocolate;
            this.med_refresh.Location = new System.Drawing.Point(281, 115);
            this.med_refresh.Name = "med_refresh";
            this.med_refresh.Size = new System.Drawing.Size(137, 34);
            this.med_refresh.TabIndex = 18;
            this.med_refresh.Text = "Refresh";
            this.med_refresh.UseVisualStyleBackColor = false;
            this.med_refresh.Click += new System.EventHandler(this.med_refresh_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Amount :";
            // 
            // med_open_cart
            // 
            this.med_open_cart.BackColor = System.Drawing.Color.Chocolate;
            this.med_open_cart.Location = new System.Drawing.Point(20, 115);
            this.med_open_cart.Name = "med_open_cart";
            this.med_open_cart.Size = new System.Drawing.Size(239, 34);
            this.med_open_cart.TabIndex = 10;
            this.med_open_cart.Text = "Open Cart";
            this.med_open_cart.UseVisualStyleBackColor = false;
            this.med_open_cart.Click += new System.EventHandler(this.med_open_cart_Click);
            // 
            // med_add_to_cart
            // 
            this.med_add_to_cart.BackColor = System.Drawing.Color.Chocolate;
            this.med_add_to_cart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.med_add_to_cart.Location = new System.Drawing.Point(178, 13);
            this.med_add_to_cart.Name = "med_add_to_cart";
            this.med_add_to_cart.Size = new System.Drawing.Size(154, 34);
            this.med_add_to_cart.TabIndex = 9;
            this.med_add_to_cart.Text = "Add To Cart";
            this.med_add_to_cart.UseVisualStyleBackColor = false;
            this.med_add_to_cart.Click += new System.EventHandler(this.med_add_to_cart_Click);
            // 
            // med_amount
            // 
            this.med_amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.med_amount.Location = new System.Drawing.Point(115, 15);
            this.med_amount.Name = "med_amount";
            this.med_amount.Size = new System.Drawing.Size(47, 31);
            this.med_amount.TabIndex = 7;
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
            this.dataGridView1.Location = new System.Drawing.Point(32, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1106, 345);
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
            this.tabPage2.Size = new System.Drawing.Size(1183, 681);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CosmeticTable";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cos_refresh);
            this.panel1.Controls.Add(this.cos_open_cart);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cos_add_to_cart);
            this.panel1.Controls.Add(this.cos_amount);
            this.panel1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(27, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 166);
            this.panel1.TabIndex = 1;
            // 
            // cos_refresh
            // 
            this.cos_refresh.BackColor = System.Drawing.Color.Teal;
            this.cos_refresh.Location = new System.Drawing.Point(284, 118);
            this.cos_refresh.Name = "cos_refresh";
            this.cos_refresh.Size = new System.Drawing.Size(137, 34);
            this.cos_refresh.TabIndex = 31;
            this.cos_refresh.Text = "Refresh";
            this.cos_refresh.UseVisualStyleBackColor = false;
            this.cos_refresh.Click += new System.EventHandler(this.cos_refresh_Click);
            // 
            // cos_open_cart
            // 
            this.cos_open_cart.BackColor = System.Drawing.Color.Teal;
            this.cos_open_cart.Location = new System.Drawing.Point(14, 118);
            this.cos_open_cart.Name = "cos_open_cart";
            this.cos_open_cart.Size = new System.Drawing.Size(223, 34);
            this.cos_open_cart.TabIndex = 30;
            this.cos_open_cart.Text = "Open Cart";
            this.cos_open_cart.UseVisualStyleBackColor = false;
            this.cos_open_cart.Click += new System.EventHandler(this.cos_open_cart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Amount :";
            // 
            // cos_add_to_cart
            // 
            this.cos_add_to_cart.BackColor = System.Drawing.Color.Teal;
            this.cos_add_to_cart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cos_add_to_cart.Location = new System.Drawing.Point(217, 11);
            this.cos_add_to_cart.Name = "cos_add_to_cart";
            this.cos_add_to_cart.Size = new System.Drawing.Size(154, 34);
            this.cos_add_to_cart.TabIndex = 22;
            this.cos_add_to_cart.Text = "Add to Cart";
            this.cos_add_to_cart.UseVisualStyleBackColor = false;
            this.cos_add_to_cart.Click += new System.EventHandler(this.cos_add_to_cart_Click);
            // 
            // cos_amount
            // 
            this.cos_amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cos_amount.Location = new System.Drawing.Point(122, 13);
            this.cos_amount.Name = "cos_amount";
            this.cos_amount.Size = new System.Drawing.Size(47, 31);
            this.cos_amount.TabIndex = 20;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(27, 207);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(1115, 384);
            this.dataGridView2.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(523, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 28);
            this.label13.TabIndex = 2;
            this.label13.Text = "My Pharmacy";
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1186, 638);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tabControl1);
            this.Name = "AppForm";
            this.Text = "WinAppUser";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button med_refresh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button med_open_cart;
        private System.Windows.Forms.Button med_add_to_cart;
        private System.Windows.Forms.TextBox med_amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cos_refresh;
        private System.Windows.Forms.Button cos_open_cart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cos_add_to_cart;
        private System.Windows.Forms.TextBox cos_amount;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label13;
    }
}


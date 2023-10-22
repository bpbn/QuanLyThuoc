namespace QLThuoc
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.qLNHATHUOCDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NHATHUOCDataSet = new QLThuoc.QL_NHATHUOCDataSet();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btn_Category = new System.Windows.Forms.Button();
            this.btn_ImportGoods = new System.Windows.Forms.Button();
            this.btn_Sell = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHATHUOCDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHATHUOCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Report
            // 
            this.btn_Report.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Report.FlatAppearance.BorderSize = 0;
            this.btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Report.Font = new System.Drawing.Font("HJ Manga 6", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_Report.Image = global::QLThuoc.Properties.Resources.icons8_revenue_40;
            this.btn_Report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Report.Location = new System.Drawing.Point(12, 453);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(221, 67);
            this.btn_Report.TabIndex = 4;
            this.btn_Report.Text = "Báo cáo";
            this.btn_Report.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Report.UseVisualStyleBackColor = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("HJ Manga 6", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_Exit.Image = global::QLThuoc.Properties.Resources.icons8_exit_40;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(12, 526);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(221, 67);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exit.UseVisualStyleBackColor = false;
            // 
            // qLNHATHUOCDataSetBindingSource
            // 
            this.qLNHATHUOCDataSetBindingSource.DataSource = this.qL_NHATHUOCDataSet;
            this.qLNHATHUOCDataSetBindingSource.Position = 0;
            // 
            // qL_NHATHUOCDataSet
            // 
            this.qL_NHATHUOCDataSet.DataSetName = "QL_NHATHUOCDataSet";
            this.qL_NHATHUOCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logo
            // 
            this.logo.Image = global::QLThuoc.Properties.Resources.logo1;
            this.logo.ImageLocation = "";
            this.logo.InitialImage = null;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(221, 93);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 6;
            this.logo.TabStop = false;
            // 
            // btn_Category
            // 
            this.btn_Category.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Category.FlatAppearance.BorderSize = 0;
            this.btn_Category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Category.Font = new System.Drawing.Font("HJ Manga 6", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Category.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_Category.Image = ((System.Drawing.Image)(resources.GetObject("btn_Category.Image")));
            this.btn_Category.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Category.Location = new System.Drawing.Point(12, 380);
            this.btn_Category.Name = "btn_Category";
            this.btn_Category.Size = new System.Drawing.Size(221, 67);
            this.btn_Category.TabIndex = 1;
            this.btn_Category.Text = "Danh Mục";
            this.btn_Category.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Category.UseVisualStyleBackColor = false;
            this.btn_Category.Click += new System.EventHandler(this.btn_Category_Click);
            // 
            // btn_ImportGoods
            // 
            this.btn_ImportGoods.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_ImportGoods.FlatAppearance.BorderSize = 0;
            this.btn_ImportGoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ImportGoods.Font = new System.Drawing.Font("HJ Manga 6", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImportGoods.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_ImportGoods.Image = global::QLThuoc.Properties.Resources.icons8_import_goods_40;
            this.btn_ImportGoods.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ImportGoods.Location = new System.Drawing.Point(12, 307);
            this.btn_ImportGoods.Name = "btn_ImportGoods";
            this.btn_ImportGoods.Size = new System.Drawing.Size(221, 67);
            this.btn_ImportGoods.TabIndex = 2;
            this.btn_ImportGoods.Text = "nhập hàng";
            this.btn_ImportGoods.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ImportGoods.UseVisualStyleBackColor = false;
            // 
            // btn_Sell
            // 
            this.btn_Sell.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Sell.FlatAppearance.BorderSize = 0;
            this.btn_Sell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sell.Font = new System.Drawing.Font("HJ Manga 6", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sell.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_Sell.Image = global::QLThuoc.Properties.Resources.icons8_sell_40;
            this.btn_Sell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sell.Location = new System.Drawing.Point(12, 234);
            this.btn_Sell.Name = "btn_Sell";
            this.btn_Sell.Size = new System.Drawing.Size(221, 67);
            this.btn_Sell.TabIndex = 3;
            this.btn_Sell.Text = "Bán hàng";
            this.btn_Sell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sell.UseVisualStyleBackColor = false;
            this.btn_Sell.Click += new System.EventHandler(this.btn_Sell_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("HJ Manga 6", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_Home.Image = global::QLThuoc.Properties.Resources.icons8_home_40;
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(12, 161);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(221, 67);
            this.btn_Home.TabIndex = 5;
            this.btn_Home.Text = "Trang chủ";
            this.btn_Home.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Home.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1428, 713);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Category);
            this.Controls.Add(this.btn_ImportGoods);
            this.Controls.Add(this.btn_Sell);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.btn_Home);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Trang chủ";
            ((System.ComponentModel.ISupportInitialize)(this.qLNHATHUOCDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHATHUOCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Category;
        private System.Windows.Forms.Button btn_ImportGoods;
        private System.Windows.Forms.Button btn_Sell;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.BindingSource qLNHATHUOCDataSetBindingSource;
        private QL_NHATHUOCDataSet qL_NHATHUOCDataSet;
    }
}
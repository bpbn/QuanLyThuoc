﻿namespace QLThuoc
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            this.qLNHATHUOCDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NHATHUOCDataSet = new QLThuoc.QL_NHATHUOCDataSet();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btn_BaoCao = new System.Windows.Forms.Button();
            this.btn_TrangChu = new System.Windows.Forms.Button();
            this.btn_DanhMuc = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_NhapHang = new System.Windows.Forms.Button();
            this.btn_BanHang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHATHUOCDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHATHUOCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
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
            // btn_BaoCao
            // 
            this.btn_BaoCao.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_BaoCao.FlatAppearance.BorderSize = 0;
            this.btn_BaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BaoCao.Font = new System.Drawing.Font("HJ Manga 6", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BaoCao.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_BaoCao.Image = global::QLThuoc.Properties.Resources.icons8_revenue_40;
            this.btn_BaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BaoCao.Location = new System.Drawing.Point(12, 453);
            this.btn_BaoCao.Name = "btn_BaoCao";
            this.btn_BaoCao.Size = new System.Drawing.Size(221, 67);
            this.btn_BaoCao.TabIndex = 4;
            this.btn_BaoCao.Text = "Báo cáo";
            this.btn_BaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_BaoCao.UseVisualStyleBackColor = false;
            // 
            // btn_TrangChu
            // 
            this.btn_TrangChu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_TrangChu.FlatAppearance.BorderSize = 0;
            this.btn_TrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TrangChu.Font = new System.Drawing.Font("HJ Manga 6", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TrangChu.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_TrangChu.Image = global::QLThuoc.Properties.Resources.icons8_home_40;
            this.btn_TrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TrangChu.Location = new System.Drawing.Point(12, 161);
            this.btn_TrangChu.Name = "btn_TrangChu";
            this.btn_TrangChu.Size = new System.Drawing.Size(221, 67);
            this.btn_TrangChu.TabIndex = 5;
            this.btn_TrangChu.Text = "Trang chủ";
            this.btn_TrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TrangChu.UseVisualStyleBackColor = false;
            // 
            // btn_DanhMuc
            // 
            this.btn_DanhMuc.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_DanhMuc.FlatAppearance.BorderSize = 0;
            this.btn_DanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DanhMuc.Font = new System.Drawing.Font("HJ Manga 6", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DanhMuc.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_DanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("btn_DanhMuc.Image")));
            this.btn_DanhMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DanhMuc.Location = new System.Drawing.Point(12, 380);
            this.btn_DanhMuc.Name = "btn_DanhMuc";
            this.btn_DanhMuc.Size = new System.Drawing.Size(221, 67);
            this.btn_DanhMuc.TabIndex = 1;
            this.btn_DanhMuc.Text = "Danh Mục";
            this.btn_DanhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DanhMuc.UseVisualStyleBackColor = false;
            this.btn_DanhMuc.Click += new System.EventHandler(this.btn_DanhMuc_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Thoat.FlatAppearance.BorderSize = 0;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Font = new System.Drawing.Font("HJ Manga 6", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_Thoat.Image = global::QLThuoc.Properties.Resources.icons8_exit_40;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(12, 526);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(221, 67);
            this.btn_Thoat.TabIndex = 1;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            // 
            // btn_NhapHang
            // 
            this.btn_NhapHang.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_NhapHang.FlatAppearance.BorderSize = 0;
            this.btn_NhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhapHang.Font = new System.Drawing.Font("HJ Manga 6", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhapHang.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_NhapHang.Image = global::QLThuoc.Properties.Resources.icons8_import_goods_40;
            this.btn_NhapHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhapHang.Location = new System.Drawing.Point(12, 307);
            this.btn_NhapHang.Name = "btn_NhapHang";
            this.btn_NhapHang.Size = new System.Drawing.Size(221, 67);
            this.btn_NhapHang.TabIndex = 2;
            this.btn_NhapHang.Text = "nhập hàng";
            this.btn_NhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NhapHang.UseVisualStyleBackColor = false;
            // 
            // btn_BanHang
            // 
            this.btn_BanHang.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_BanHang.FlatAppearance.BorderSize = 0;
            this.btn_BanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BanHang.Font = new System.Drawing.Font("HJ Manga 6", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BanHang.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_BanHang.Image = global::QLThuoc.Properties.Resources.icons8_sell_40;
            this.btn_BanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BanHang.Location = new System.Drawing.Point(12, 234);
            this.btn_BanHang.Name = "btn_BanHang";
            this.btn_BanHang.Size = new System.Drawing.Size(221, 67);
            this.btn_BanHang.TabIndex = 3;
            this.btn_BanHang.Text = "Bán hàng";
            this.btn_BanHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_BanHang.UseVisualStyleBackColor = false;
            this.btn_BanHang.Click += new System.EventHandler(this.btn_BanHang_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1428, 713);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DanhMuc);
            this.Controls.Add(this.btn_NhapHang);
            this.Controls.Add(this.btn_BanHang);
            this.Controls.Add(this.btn_BaoCao);
            this.Controls.Add(this.btn_TrangChu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Trang chủ";
            ((System.ComponentModel.ISupportInitialize)(this.qLNHATHUOCDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHATHUOCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.BindingSource qLNHATHUOCDataSetBindingSource;
        private QL_NHATHUOCDataSet qL_NHATHUOCDataSet;
        private System.Windows.Forms.Button btn_BaoCao;
        private System.Windows.Forms.Button btn_TrangChu;
        private System.Windows.Forms.Button btn_DanhMuc;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_NhapHang;
        private System.Windows.Forms.Button btn_BanHang;
    }
}
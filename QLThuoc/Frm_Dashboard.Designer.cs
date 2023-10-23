namespace QLThuoc
{
    partial class Frm_Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.btn_ThisMonth = new System.Windows.Forms.Button();
            this.btn_Last30Day = new System.Windows.Forms.Button();
            this.btn_Last7Day = new System.Windows.Forms.Button();
            this.btn_Today = new System.Windows.Forms.Button();
            this.btn_CustomDate = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lb_NumOfOrders = new System.Windows.Forms.Label();
            this.lb_TotalRevenue = new System.Windows.Forms.Label();
            this.lb_TotalProfit = new System.Windows.Forms.Label();
            this.lb_NumOfCustomers = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_NumOfSuppliers = new System.Windows.Forms.Label();
            this.lb_NumOfProducts = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lb_TongSoDonNhap = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lb_TongChi = new System.Windows.Forms.Label();
            this.lb_StartDate = new System.Windows.Forms.Label();
            this.lb_EndDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Chart_Top5Products = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Chart_GrossRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_Chi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Top5Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_GrossRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Chi)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.CustomFormat = "MMM dd, yyyy";
            this.dtp_StartDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_StartDate.Location = new System.Drawing.Point(287, 16);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(162, 30);
            this.dtp_StartDate.TabIndex = 0;
            this.dtp_StartDate.ValueChanged += new System.EventHandler(this.dtp_StartDate_ValueChanged);
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.CustomFormat = "MMM dd, yyyy";
            this.dtp_EndDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_EndDate.Location = new System.Drawing.Point(504, 16);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(152, 30);
            this.dtp_EndDate.TabIndex = 0;
            this.dtp_EndDate.Value = new System.DateTime(2023, 10, 29, 19, 15, 0, 0);
            this.dtp_EndDate.ValueChanged += new System.EventHandler(this.dtp_EndDate_ValueChanged);
            // 
            // btn_ThisMonth
            // 
            this.btn_ThisMonth.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_ThisMonth.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btn_ThisMonth.FlatAppearance.BorderSize = 2;
            this.btn_ThisMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThisMonth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThisMonth.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_ThisMonth.Location = new System.Drawing.Point(1283, 14);
            this.btn_ThisMonth.Name = "btn_ThisMonth";
            this.btn_ThisMonth.Size = new System.Drawing.Size(130, 45);
            this.btn_ThisMonth.TabIndex = 1;
            this.btn_ThisMonth.Text = "Tháng này";
            this.btn_ThisMonth.UseVisualStyleBackColor = false;
            this.btn_ThisMonth.Click += new System.EventHandler(this.btn_ThisMonth_Click);
            // 
            // btn_Last30Day
            // 
            this.btn_Last30Day.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Last30Day.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Last30Day.FlatAppearance.BorderSize = 2;
            this.btn_Last30Day.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Last30Day.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Last30Day.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Last30Day.Location = new System.Drawing.Point(1122, 14);
            this.btn_Last30Day.Name = "btn_Last30Day";
            this.btn_Last30Day.Size = new System.Drawing.Size(159, 45);
            this.btn_Last30Day.TabIndex = 1;
            this.btn_Last30Day.Text = "Trong 30 ngày";
            this.btn_Last30Day.UseVisualStyleBackColor = false;
            this.btn_Last30Day.Click += new System.EventHandler(this.btn_Last30Day_Click);
            // 
            // btn_Last7Day
            // 
            this.btn_Last7Day.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Last7Day.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Last7Day.FlatAppearance.BorderSize = 2;
            this.btn_Last7Day.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Last7Day.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Last7Day.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Last7Day.Location = new System.Drawing.Point(973, 14);
            this.btn_Last7Day.Name = "btn_Last7Day";
            this.btn_Last7Day.Size = new System.Drawing.Size(147, 45);
            this.btn_Last7Day.TabIndex = 1;
            this.btn_Last7Day.Text = "Trong 7 ngày";
            this.btn_Last7Day.UseVisualStyleBackColor = false;
            this.btn_Last7Day.Click += new System.EventHandler(this.btn_Last7Day_Click);
            // 
            // btn_Today
            // 
            this.btn_Today.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Today.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Today.FlatAppearance.BorderSize = 2;
            this.btn_Today.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Today.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Today.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Today.Location = new System.Drawing.Point(860, 14);
            this.btn_Today.Name = "btn_Today";
            this.btn_Today.Size = new System.Drawing.Size(111, 45);
            this.btn_Today.TabIndex = 1;
            this.btn_Today.Text = "Hôm nay";
            this.btn_Today.UseVisualStyleBackColor = false;
            this.btn_Today.Click += new System.EventHandler(this.btn_Today_Click);
            // 
            // btn_CustomDate
            // 
            this.btn_CustomDate.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_CustomDate.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btn_CustomDate.FlatAppearance.BorderSize = 2;
            this.btn_CustomDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CustomDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CustomDate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_CustomDate.Location = new System.Drawing.Point(758, 14);
            this.btn_CustomDate.Name = "btn_CustomDate";
            this.btn_CustomDate.Size = new System.Drawing.Size(100, 45);
            this.btn_CustomDate.TabIndex = 1;
            this.btn_CustomDate.Text = "Chọn";
            this.btn_CustomDate.UseVisualStyleBackColor = false;
            this.btn_CustomDate.Click += new System.EventHandler(this.btn_CustomDate_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnOK.FlatAppearance.BorderSize = 2;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnOK.Location = new System.Drawing.Point(697, 14);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(61, 45);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lb_NumOfOrders
            // 
            this.lb_NumOfOrders.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NumOfOrders.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lb_NumOfOrders.Location = new System.Drawing.Point(63, 22);
            this.lb_NumOfOrders.Name = "lb_NumOfOrders";
            this.lb_NumOfOrders.Size = new System.Drawing.Size(188, 34);
            this.lb_NumOfOrders.TabIndex = 0;
            this.lb_NumOfOrders.Text = "0";
            // 
            // lb_TotalRevenue
            // 
            this.lb_TotalRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_TotalRevenue.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TotalRevenue.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lb_TotalRevenue.Location = new System.Drawing.Point(56, 18);
            this.lb_TotalRevenue.Name = "lb_TotalRevenue";
            this.lb_TotalRevenue.Size = new System.Drawing.Size(223, 34);
            this.lb_TotalRevenue.TabIndex = 0;
            this.lb_TotalRevenue.Text = "0đ";
            this.lb_TotalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_TotalProfit
            // 
            this.lb_TotalProfit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TotalProfit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lb_TotalProfit.Location = new System.Drawing.Point(49, 21);
            this.lb_TotalProfit.Name = "lb_TotalProfit";
            this.lb_TotalProfit.Size = new System.Drawing.Size(199, 34);
            this.lb_TotalProfit.TabIndex = 0;
            this.lb_TotalProfit.Text = "0đ";
            // 
            // lb_NumOfCustomers
            // 
            this.lb_NumOfCustomers.AutoSize = true;
            this.lb_NumOfCustomers.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NumOfCustomers.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lb_NumOfCustomers.Location = new System.Drawing.Point(10, 42);
            this.lb_NumOfCustomers.Name = "lb_NumOfCustomers";
            this.lb_NumOfCustomers.Size = new System.Drawing.Size(34, 37);
            this.lb_NumOfCustomers.TabIndex = 1;
            this.lb_NumOfCustomers.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(6, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(436, 196);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lb_NumOfOrders);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(17, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 60);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tổng số đơn xuất";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lb_TotalProfit);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(1149, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 60);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lợi nhuận";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.lb_TotalRevenue);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox4.Location = new System.Drawing.Point(583, 73);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 60);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Doanh thu";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(809, 471);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(448, 233);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sản phẩm gần hết hàng";
            // 
            // lb_NumOfSuppliers
            // 
            this.lb_NumOfSuppliers.AutoSize = true;
            this.lb_NumOfSuppliers.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NumOfSuppliers.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lb_NumOfSuppliers.Location = new System.Drawing.Point(10, 113);
            this.lb_NumOfSuppliers.Name = "lb_NumOfSuppliers";
            this.lb_NumOfSuppliers.Size = new System.Drawing.Size(34, 37);
            this.lb_NumOfSuppliers.TabIndex = 1;
            this.lb_NumOfSuppliers.Text = "0";
            // 
            // lb_NumOfProducts
            // 
            this.lb_NumOfProducts.AutoSize = true;
            this.lb_NumOfProducts.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NumOfProducts.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lb_NumOfProducts.Location = new System.Drawing.Point(10, 184);
            this.lb_NumOfProducts.Name = "lb_NumOfProducts";
            this.lb_NumOfProducts.Size = new System.Drawing.Size(34, 37);
            this.lb_NumOfProducts.TabIndex = 1;
            this.lb_NumOfProducts.Text = "0";
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Transparent;
            this.groupBox8.Controls.Add(this.lb_TongSoDonNhap);
            this.groupBox8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox8.Location = new System.Drawing.Point(300, 73);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(272, 60);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Tổng số đơn nhập";
            // 
            // lb_TongSoDonNhap
            // 
            this.lb_TongSoDonNhap.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongSoDonNhap.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lb_TongSoDonNhap.Location = new System.Drawing.Point(63, 22);
            this.lb_TongSoDonNhap.Name = "lb_TongSoDonNhap";
            this.lb_TongSoDonNhap.Size = new System.Drawing.Size(188, 34);
            this.lb_TongSoDonNhap.TabIndex = 0;
            this.lb_TongSoDonNhap.Text = "0";
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.Transparent;
            this.groupBox9.Controls.Add(this.lb_TongChi);
            this.groupBox9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox9.Location = new System.Drawing.Point(866, 73);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(272, 60);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Tổng chi";
            // 
            // lb_TongChi
            // 
            this.lb_TongChi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongChi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lb_TongChi.Location = new System.Drawing.Point(49, 21);
            this.lb_TongChi.Name = "lb_TongChi";
            this.lb_TongChi.Size = new System.Drawing.Size(199, 34);
            this.lb_TongChi.TabIndex = 0;
            this.lb_TongChi.Text = "0đ";
            // 
            // lb_StartDate
            // 
            this.lb_StartDate.BackColor = System.Drawing.Color.AliceBlue;
            this.lb_StartDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_StartDate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lb_StartDate.Location = new System.Drawing.Point(284, 16);
            this.lb_StartDate.Name = "lb_StartDate";
            this.lb_StartDate.Size = new System.Drawing.Size(166, 39);
            this.lb_StartDate.TabIndex = 5;
            this.lb_StartDate.Text = "May 29, 2023";
            this.lb_StartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_StartDate.Click += new System.EventHandler(this.lb_StartDate_Click);
            // 
            // lb_EndDate
            // 
            this.lb_EndDate.BackColor = System.Drawing.Color.AliceBlue;
            this.lb_EndDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EndDate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lb_EndDate.Location = new System.Drawing.Point(504, 16);
            this.lb_EndDate.Name = "lb_EndDate";
            this.lb_EndDate.Size = new System.Drawing.Size(154, 39);
            this.lb_EndDate.TabIndex = 5;
            this.lb_EndDate.Text = "Oct 29, 2023";
            this.lb_EndDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_EndDate.Click += new System.EventHandler(this.lb_EndDate_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "-";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lb_NumOfProducts);
            this.panel1.Controls.Add(this.lb_NumOfSuppliers);
            this.panel1.Controls.Add(this.lb_NumOfCustomers);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1263, 471);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 232);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(13, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mặt hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(13, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khách hàng";
            // 
            // Chart_Top5Products
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart_Top5Products.ChartAreas.Add(chartArea1);
            legend1.ForeColor = System.Drawing.Color.MidnightBlue;
            legend1.Name = "Legend1";
            this.Chart_Top5Products.Legends.Add(legend1);
            this.Chart_Top5Products.Location = new System.Drawing.Point(17, 139);
            this.Chart_Top5Products.Name = "Chart_Top5Products";
            this.Chart_Top5Products.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderColor = System.Drawing.Color.White;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart_Top5Products.Series.Add(series1);
            this.Chart_Top5Products.Size = new System.Drawing.Size(534, 326);
            this.Chart_Top5Products.TabIndex = 7;
            this.Chart_Top5Products.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.SystemColors.HotTrack;
            title1.Name = "Title1";
            title1.Text = "Top 5 sản phẩm bán chạy";
            this.Chart_Top5Products.Titles.Add(title1);
            // 
            // Chart_GrossRevenue
            // 
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.MidnightBlue;
            chartArea2.AxisX.LineColor = System.Drawing.Color.MidnightBlue;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.MajorGrid.LineWidth = 0;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.MidnightBlue;
            chartArea2.AxisY.LineWidth = 0;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.MidnightBlue;
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.MidnightBlue;
            chartArea2.Name = "ChartArea1";
            this.Chart_GrossRevenue.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.ForeColor = System.Drawing.Color.MidnightBlue;
            legend2.Name = "Legend1";
            this.Chart_GrossRevenue.Legends.Add(legend2);
            this.Chart_GrossRevenue.Location = new System.Drawing.Point(557, 139);
            this.Chart_GrossRevenue.Name = "Chart_GrossRevenue";
            this.Chart_GrossRevenue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series2.BackSecondaryColor = System.Drawing.Color.Aquamarine;
            series2.BorderColor = System.Drawing.Color.Aquamarine;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.Color = System.Drawing.Color.CornflowerBlue;
            series2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.Chart_GrossRevenue.Series.Add(series2);
            this.Chart_GrossRevenue.Size = new System.Drawing.Size(856, 326);
            this.Chart_GrossRevenue.TabIndex = 7;
            this.Chart_GrossRevenue.Text = "chart1";
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.SystemColors.HotTrack;
            title2.Name = "Title1";
            title2.Text = "Tình hình doanh thu";
            this.Chart_GrossRevenue.Titles.Add(title2);
            // 
            // chart_Chi
            // 
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.MidnightBlue;
            chartArea3.AxisX.LineColor = System.Drawing.Color.MidnightBlue;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.MajorGrid.LineWidth = 0;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.MidnightBlue;
            chartArea3.AxisY.LineWidth = 0;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.MidnightBlue;
            chartArea3.AxisY.TitleForeColor = System.Drawing.Color.MidnightBlue;
            chartArea3.Name = "ChartArea1";
            this.chart_Chi.ChartAreas.Add(chartArea3);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.ForeColor = System.Drawing.Color.MidnightBlue;
            legend3.Name = "Legend1";
            this.chart_Chi.Legends.Add(legend3);
            this.chart_Chi.Location = new System.Drawing.Point(12, 471);
            this.chart_Chi.Name = "chart_Chi";
            this.chart_Chi.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series3.BackSecondaryColor = System.Drawing.Color.Aquamarine;
            series3.BorderColor = System.Drawing.Color.Aquamarine;
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series3.Color = System.Drawing.Color.CornflowerBlue;
            series3.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart_Chi.Series.Add(series3);
            this.chart_Chi.Size = new System.Drawing.Size(791, 233);
            this.chart_Chi.TabIndex = 7;
            this.chart_Chi.Text = "chart1";
            title3.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.ForeColor = System.Drawing.SystemColors.HotTrack;
            title3.Name = "Title1";
            title3.Text = "Tình hình chi";
            this.chart_Chi.Titles.Add(title3);
            // 
            // Frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1428, 713);
            this.Controls.Add(this.chart_Chi);
            this.Controls.Add(this.Chart_GrossRevenue);
            this.Controls.Add(this.Chart_Top5Products);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_EndDate);
            this.Controls.Add(this.lb_StartDate);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btn_CustomDate);
            this.Controls.Add(this.btn_Today);
            this.Controls.Add(this.btn_Last7Day);
            this.Controls.Add(this.btn_Last30Day);
            this.Controls.Add(this.btn_ThisMonth);
            this.Controls.Add(this.dtp_EndDate);
            this.Controls.Add(this.dtp_StartDate);
            this.Name = "Frm_Dashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Top5Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_GrossRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Chi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.Button btn_ThisMonth;
        private System.Windows.Forms.Button btn_Last30Day;
        private System.Windows.Forms.Button btn_Last7Day;
        private System.Windows.Forms.Button btn_Today;
        private System.Windows.Forms.Button btn_CustomDate;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lb_NumOfOrders;
        private System.Windows.Forms.Label lb_TotalRevenue;
        private System.Windows.Forms.Label lb_TotalProfit;
        private System.Windows.Forms.Label lb_NumOfCustomers;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb_NumOfSuppliers;
        private System.Windows.Forms.Label lb_NumOfProducts;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lb_TongSoDonNhap;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lb_TongChi;
        private System.Windows.Forms.Label lb_StartDate;
        private System.Windows.Forms.Label lb_EndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Top5Products;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_GrossRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Chi;
    }
}
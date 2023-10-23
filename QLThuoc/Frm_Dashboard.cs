using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLThuoc.Database;
using QLThuoc.Models;

namespace QLThuoc
{
    public partial class Frm_Dashboard : Form
    {
        //Fields
        private Dashboard model;
        private Button currentButton;

        //Constructor
        public Frm_Dashboard()
        {
            InitializeComponent();
            //Default 7 days
            dtp_StartDate.Value = DateTime.Today.AddDays(-7);
            dtp_EndDate.Value = DateTime.Now;
            btn_Last7Day.Select();
            SetDateMenuButtonUI(btn_Last7Day);
            model = new Dashboard();
            LoadData();
        }

        private void LoadData()
        {
            var refreshData = model.LoadData(dtp_StartDate.Value, dtp_EndDate.Value);
            if(refreshData)
            {
                lb_NumOfOrders.Text = model.NumOrders.ToString();
                lb_TongSoDonNhap.Text = model.NumDonNhap.ToString();
                lb_TotalRevenue.Text = model.TotalRevenue.ToString() + "đ";
                lb_TongChi.Text = model.TotalExpenditure.ToString() + "đ";
                lb_TotalProfit.Text = (model.TotalRevenue - model.TotalExpenditure).ToString() + "đ";

                lb_NumOfCustomers.Text = model.numCustomers.ToString();
                lb_NumOfSuppliers.Text = model.numSuppliers.ToString();
                lb_NumOfProducts.Text = model.numProducts.ToString();

                Chart_GrossRevenue.DataSource = model.GrossRevenueList;
                Chart_GrossRevenue.Series[0].XValueMember = "Date";
                Chart_GrossRevenue.Series[0].YValueMembers = "TotalAmount";
                Chart_GrossRevenue.DataBind();

                chart_Chi.DataSource = model.GrossExpenditureList;
                chart_Chi.Series[0].XValueMember = "Date";
                chart_Chi.Series[0].YValueMembers = "TotalAmount";
                chart_Chi.DataBind();

                Chart_Top5Products.DataSource = model.TopProductsList;
                Chart_Top5Products.Series[0].XValueMember = "Key";
                Chart_Top5Products.Series[0].YValueMembers = "Value";
                Chart_Top5Products.DataBind();

                dataGridView1.DataSource = model.UnderstockList;
                dataGridView1.Columns[0].HeaderText = "Tên sản phẩm";
                dataGridView1.Columns[1].HeaderText = "Sl";
            }
        }

        private void SetDateMenuButtonUI(object button)
        {
            var btn = (Button)button;
            btn.BackColor = btn_Last30Day.FlatAppearance.BorderColor;
            btn.ForeColor = Color.White;

            if(currentButton != null&& currentButton != btn)
            {
                currentButton.BackColor = this.BackColor;
                currentButton.ForeColor = Color.MidnightBlue;
            }
            currentButton = btn;

            if (btn == btn_CustomDate)
            {
                dtp_StartDate.Enabled = true;
                dtp_EndDate.Enabled = true;
                btnOK.Visible = true;
                lb_StartDate.Cursor = Cursors.Hand;
                lb_EndDate.Cursor = Cursors.Hand;
            }
            else
            {
                dtp_StartDate.Enabled = false;
                dtp_EndDate.Enabled = false;
                btnOK.Visible = false;
                lb_StartDate.Cursor = Cursors.Default;
                lb_EndDate.Cursor = Cursors.Default;
            }
        }
        //Event methods
        private void btn_Today_Click(object sender, EventArgs e)
        {
            dtp_StartDate.Value = DateTime.Today;
            dtp_EndDate.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonUI(sender);
        }

        private void btn_Last7Day_Click(object sender, EventArgs e)
        {
            dtp_StartDate.Value = DateTime.Today.AddDays(-7);
            dtp_EndDate.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonUI(sender);
        }

        private void btn_Last30Day_Click(object sender, EventArgs e)
        {
            dtp_StartDate.Value = DateTime.Today.AddDays(-30);
            dtp_EndDate.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonUI(sender);
        }

        private void btn_ThisMonth_Click(object sender, EventArgs e)
        {
            dtp_StartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtp_EndDate.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonUI(sender);
        }

        private void btn_CustomDate_Click(object sender, EventArgs e)
        {
            SetDateMenuButtonUI(sender);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lb_StartDate_Click(object sender, EventArgs e)
        {
            if(currentButton == btn_CustomDate)
            {
                dtp_StartDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void lb_EndDate_Click(object sender, EventArgs e)
        {
            if (currentButton == btn_CustomDate)
            {
                dtp_EndDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void dtp_StartDate_ValueChanged(object sender, EventArgs e)
        {
            lb_StartDate.Text = dtp_StartDate.Text;
        }

        private void dtp_EndDate_ValueChanged(object sender, EventArgs e)
        {
            lb_EndDate.Text = dtp_EndDate.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_StartDate.Text = dtp_StartDate.Text;
            lb_EndDate.Text = dtp_EndDate.Text;
            dataGridView1.Columns[1].Width = 50;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuoc.Database;
using System.Data.SqlClient;
using System.Globalization;

namespace QLThuoc.Models
{
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }
    public struct expenditureByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public class Dashboard : DbConnection
    {
        //Fields & Properties
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public int numCustomers { get; private set; }
        public int numSuppliers { get; private set; }
        public int numProducts { get; private set; }
        public List<KeyValuePair<String, int>> TopProductsList { get; private set; }
        public List<KeyValuePair<String, int>> UnderstockList { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public List<expenditureByDate> GrossExpenditureList { get; private set; }
        public int NumOrders { get; set; }
        public int NumDonNhap { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalExpenditure { get; set; }

        //Constructor
        public Dashboard()
        {
        }

        //private methods
        private void GetNumberItems()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    //Get ToTal Number of Customer
                    command.CommandText = "SELECT Count(*) from KHACHHANG";
                    numCustomers = (int)command.ExecuteScalar();

                    //Get ToTal Number of Supplier
                    command.CommandText = "SELECT Count(*) from NHACUNGCAP";
                    numSuppliers = (int)command.ExecuteScalar();

                    //Get ToTal Number of Products
                    command.CommandText = "SELECT Count(*) from SANPHAM";
                    numProducts = (int)command.ExecuteScalar();

                    //Get ToTal Number of Orders
                    command.CommandText = @"SELECT Count(*) FROM DONHANGXUAT WHERE NGAYLAP BETWEEN @fromDate AND @toDate";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    NumOrders = (int)command.ExecuteScalar();

                    //Get ToTal Number of Chi
                    command.CommandText = @"SELECT Count(*) FROM DONHANGNHAP WHERE NGAYLAP BETWEEN @fromDate AND @toDate";
                    NumDonNhap = (int)command.ExecuteScalar();
                }
            }
        }
        private void GetOrderAnalisys()
        {
            GrossRevenueList = new List<RevenueByDate>();
            TotalRevenue = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT NGAYLAP, SUM(TONGTIEN) from DONHANGXUAT WHERE NGAYLAP BETWEEN @fromDate AND @toDate GROUP BY NGAYLAP";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read())
                    {
                        string b = reader[1].ToString();
                        resultTable.Add(new KeyValuePair<DateTime, decimal>((DateTime)reader[0], decimal.Parse(b)));
                        TotalRevenue += decimal.Parse(b);
                    }
                    reader.Close();

                    //Group by day
                    if (numberDays <= 30)
                    {
                        foreach (var item in resultTable)
                        {
                            GrossRevenueList.Add(new RevenueByDate()
                            {
                                Date = item.Key.ToString("dd MMM"),
                                TotalAmount = item.Value
                            });
                        }
                    }

                    //Group by weeks
                    else if (numberDays <= 92)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                            orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                                into order
                                                select new RevenueByDate
                                                {
                                                    Date = "Week " + order.Key.ToString(),
                                                    TotalAmount = order.Sum(amount => amount.Value)
                                                }).ToList();
                    }

                    //Group by months
                    else if (numberDays <= (365 * 2))
                    {
                        bool isYear = numberDays <= 365 ? true : false;
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("MMM yyyy")
                                                into order
                                                select new RevenueByDate
                                                {
                                                    Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                                    TotalAmount = order.Sum(amount => amount.Value)
                                                }).ToList();
                    }

                    //Group by years
                    else
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("yyyy")
                                                into order
                                                select new RevenueByDate
                                                {
                                                    Date = order.Key,
                                                    TotalAmount = order.Sum(amount => amount.Value)
                                                }).ToList();
                    }
                }
            }
        }
        private void GetNhapHangAnalisys()
        {
            GrossExpenditureList = new List<expenditureByDate>();
            TotalExpenditure = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT NGAYLAP, SUM(TONGTIEN) from DONHANGNHAP WHERE NGAYLAP BETWEEN @fromDate AND @toDate GROUP BY NGAYLAP";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read())
                    {
                        string b = reader[1].ToString();
                        resultTable.Add(new KeyValuePair<DateTime, decimal>((DateTime)reader[0], decimal.Parse(b)));
                        TotalExpenditure += decimal.Parse(b);
                    }
                    reader.Close();

                    //Group by day
                    if (numberDays <= 30)
                    {
                        foreach (var item in resultTable)
                        {
                            GrossExpenditureList.Add(new expenditureByDate()
                            {
                                Date = item.Key.ToString("dd MMM"),
                                TotalAmount = item.Value
                            });
                        }
                    }

                    //Group by weeks
                    else if (numberDays <= 92)
                    {
                        GrossExpenditureList = (from orderList in resultTable
                                                group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                                    into order
                                                    select new expenditureByDate
                                                    {
                                                        Date = "Week " + order.Key.ToString(),
                                                        TotalAmount = order.Sum(amount => amount.Value)
                                                    }).ToList();
                    }

                    //Group by months
                    else if (numberDays <= (365 * 2))
                    {
                        bool isYear = numberDays <= 365 ? true : false;
                        GrossExpenditureList = (from orderList in resultTable
                                                group orderList by orderList.Key.ToString("MMM yyyy")
                                                    into order
                                                    select new expenditureByDate
                                                    {
                                                        Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                                        TotalAmount = order.Sum(amount => amount.Value)
                                                    }).ToList();
                    }

                    //Group by years
                    else
                    {
                        GrossExpenditureList = (from orderList in resultTable
                                                group orderList by orderList.Key.ToString("yyyy")
                                                    into order
                                                    select new expenditureByDate
                                                    {
                                                        Date = order.Key,
                                                        TotalAmount = order.Sum(amount => amount.Value)
                                                    }).ToList();
                    }
                }
            }
        }
        private void GetProductAnalisys()
        {
            TopProductsList = new List<KeyValuePair<string, int>>();
            UnderstockList = new List<KeyValuePair<string, int>>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = connection;
                    command.CommandText = @"SELECT TOP 5 S.TENSP, SUM(C.SOLUONG) AS SL FROM CHITIETDONXUAT C JOIN SANPHAM S ON C.SANPHAM = S.MASP JOIN DONHANGXUAT D ON C.MADONHANG = D.MADONHANG WHERE NGAYLAP BETWEEN @fromDate AND @toDate GROUP BY S.TENSP ORDER BY SL DESC";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TopProductsList.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();

                    //Get Understock
                    command.CommandText = @"SELECT TENSP, TONKHO FROM SANPHAM WHERE TONKHO <= 20";
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        UnderstockList.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();
                }
            }
        }

        //public methods
        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                GetNumberItems();
                GetOrderAnalisys();
                GetProductAnalisys();
                GetNhapHangAnalisys();

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

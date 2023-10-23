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
    public struct DoanhThuTheoNgay
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }
    public struct ChiTienTheoNgay
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public class Dashboard : DbConnection
    {
        //Fields & Properties
        private DateTime NgayBD;
        private DateTime NgayKT;
        private int SoNgay;

        public int SoKhachHang { get; private set; }
        public int SoNCC { get; private set; }
        public int SoSP { get; private set; }
        public List<KeyValuePair<String, int>> ListTopSP { get; private set; }
        public List<KeyValuePair<String, int>> ListSPSapHetHang { get; private set; }
        public List<DoanhThuTheoNgay> ListDoanhThu { get; private set; }
        public List<ChiTienTheoNgay> ListChiTien { get; private set; }
        public int SoDHX { get; set; }
        public int SoDHN { get; set; }
        public decimal TongDoanhThu { get; set; }
        public decimal TongChiTien { get; set; }

        //Constructor
        public Dashboard()
        {
        }

        //private methods
        private void GetSoLuong()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    //Get ToTal Number of Customer
                    command.CommandText = "SELECT Count(*) from KHACHHANG";
                    SoKhachHang = (int)command.ExecuteScalar();

                    //Get ToTal Number of Supplier
                    command.CommandText = "SELECT Count(*) from NHACUNGCAP";
                    SoNCC = (int)command.ExecuteScalar();

                    //Get ToTal Number of Products
                    command.CommandText = "SELECT Count(*) from SANPHAM";
                    SoSP = (int)command.ExecuteScalar();

                    //Get ToTal Number of Orders
                    command.CommandText = @"SELECT Count(*) FROM DONHANGXUAT WHERE NGAYLAP BETWEEN @fromDate AND @toDate";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = NgayBD;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = NgayKT;
                    SoDHX = (int)command.ExecuteScalar();

                    //Get ToTal Number of Chi
                    command.CommandText = @"SELECT Count(*) FROM DONHANGNHAP WHERE NGAYLAP BETWEEN @fromDate AND @toDate";
                    SoDHN = (int)command.ExecuteScalar();
                }
            }
        }
        private void GetQLDonHangXuat()
        {
            ListDoanhThu = new List<DoanhThuTheoNgay>();
            TongDoanhThu = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT NGAYLAP, SUM(TONGTIEN) from DONHANGXUAT WHERE NGAYLAP BETWEEN @fromDate AND @toDate GROUP BY NGAYLAP";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = NgayBD;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = NgayKT;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read())
                    {
                        string b = reader[1].ToString();
                        resultTable.Add(new KeyValuePair<DateTime, decimal>((DateTime)reader[0], decimal.Parse(b)));
                        TongDoanhThu += decimal.Parse(b);
                    }
                    reader.Close();

                    //Group by day
                    if (SoNgay <= 30)
                    {
                        foreach (var item in resultTable)
                        {
                            ListDoanhThu.Add(new DoanhThuTheoNgay()
                            {
                                Date = item.Key.ToString("dd MMM"),
                                TotalAmount = item.Value
                            });
                        }
                    }

                    //Group by weeks
                    else if (SoNgay <= 92)
                    {
                        ListDoanhThu = (from orderList in resultTable
                                            group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                            orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                                into order
                                                select new DoanhThuTheoNgay
                                                {
                                                    Date = "Week " + order.Key.ToString(),
                                                    TotalAmount = order.Sum(amount => amount.Value)
                                                }).ToList();
                    }

                    //Group by months
                    else if (SoNgay <= (365 * 2))
                    {
                        bool isYear = SoNgay <= 365 ? true : false;
                        ListDoanhThu = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("MMM yyyy")
                                                into order
                                                select new DoanhThuTheoNgay
                                                {
                                                    Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                                    TotalAmount = order.Sum(amount => amount.Value)
                                                }).ToList();
                    }

                    //Group by years
                    else
                    {
                        ListDoanhThu = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("yyyy")
                                                into order
                                                select new DoanhThuTheoNgay
                                                {
                                                    Date = order.Key,
                                                    TotalAmount = order.Sum(amount => amount.Value)
                                                }).ToList();
                    }
                }
            }
        }
        private void GetQLDonHangNhap()
        {
            ListChiTien = new List<ChiTienTheoNgay>();
            TongChiTien = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT NGAYLAP, SUM(TONGTIEN) from DONHANGNHAP WHERE NGAYLAP BETWEEN @fromDate AND @toDate GROUP BY NGAYLAP";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = NgayBD;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = NgayKT;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read())
                    {
                        string b = reader[1].ToString();
                        resultTable.Add(new KeyValuePair<DateTime, decimal>((DateTime)reader[0], decimal.Parse(b)));
                        TongChiTien += decimal.Parse(b);
                    }
                    reader.Close();

                    //Group by day
                    if (SoNgay <= 30)
                    {
                        foreach (var item in resultTable)
                        {
                            ListChiTien.Add(new ChiTienTheoNgay()
                            {
                                Date = item.Key.ToString("dd MMM"),
                                TotalAmount = item.Value
                            });
                        }
                    }

                    //Group by weeks
                    else if (SoNgay <= 92)
                    {
                        ListChiTien = (from orderList in resultTable
                                                group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                                    into order
                                                    select new ChiTienTheoNgay
                                                    {
                                                        Date = "Week " + order.Key.ToString(),
                                                        TotalAmount = order.Sum(amount => amount.Value)
                                                    }).ToList();
                    }

                    //Group by months
                    else if (SoNgay <= (365 * 2))
                    {
                        bool isYear = SoNgay <= 365 ? true : false;
                        ListChiTien = (from orderList in resultTable
                                                group orderList by orderList.Key.ToString("MMM yyyy")
                                                    into order
                                                    select new ChiTienTheoNgay
                                                    {
                                                        Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                                        TotalAmount = order.Sum(amount => amount.Value)
                                                    }).ToList();
                    }

                    //Group by years
                    else
                    {
                        ListChiTien = (from orderList in resultTable
                                                group orderList by orderList.Key.ToString("yyyy")
                                                    into order
                                                    select new ChiTienTheoNgay
                                                    {
                                                        Date = order.Key,
                                                        TotalAmount = order.Sum(amount => amount.Value)
                                                    }).ToList();
                    }
                }
            }
        }
        private void GetQLSanPham()
        {
            ListTopSP = new List<KeyValuePair<string, int>>();
            ListSPSapHetHang = new List<KeyValuePair<string, int>>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = connection;
                    command.CommandText = @"SELECT TOP 5 S.TENSP, SUM(C.SOLUONG) AS SL FROM CHITIETDONXUAT C JOIN SANPHAM S ON C.SANPHAM = S.MASP JOIN DONHANGXUAT D ON C.MADONHANG = D.MADONHANG WHERE NGAYLAP BETWEEN @fromDate AND @toDate GROUP BY S.TENSP ORDER BY SL DESC";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = NgayBD;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = NgayKT;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ListTopSP.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();

                    //Get Understock
                    command.CommandText = @"SELECT TENSP, TONKHO FROM SANPHAM WHERE TONKHO <= 20";
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ListSPSapHetHang.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();
                }
            }
        }

        //public methods
        public bool LoadData(DateTime NgayBD, DateTime NgayKT)
        {
            NgayKT = new DateTime(NgayKT.Year, NgayKT.Month, NgayKT.Day);
            if (NgayBD != this.NgayBD || NgayKT != this.NgayKT)
            {
                this.NgayBD = NgayBD;
                this.NgayKT = NgayKT;
                this.SoNgay = (NgayKT - NgayBD).Days;

                GetSoLuong();
                GetQLDonHangXuat();
                GetQLSanPham();
                GetQLDonHangNhap();

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dùng mảng
            //Staff.NextID_NV = 100;
            //Customer.NextID_KH = 1000;
            //Console.Write("Nhap so luong nhan vien: ");
            //int n = int.Parse(Console.ReadLine());

            //Console.Write("Nhap so luong khach hang: ");
            //int m = int.Parse(Console.ReadLine());

            //Staff[] nv = new Staff[100];
            //Customer[] kh = new Customer[1000];

      
            //// string s;
            
            //Console.WriteLine("ae-them nhan vien\nac-them khach hang\ndae-hien thi thong tin nhan vien\ndac-hien thi thong tin khach hang\nno-thoat khoi chuong trinh");
            //Loop:
            //Console.Write("\nMoi ban nhap lua chon: ");
            //string option = Console.ReadLine();
            //if (option == "ae")
            //{
            //    Console.WriteLine("-- Nhap thong tin nhan vien --");
            //    for (int i=0; i<n; i++)
            //    {
            //        Console.WriteLine("-- Nhap thong tin nhan vien thu {0}--", i);
            //        nv[i] = new Staff();
            //        nv[i].input();
            //    }
            //    goto Loop;
            //}
            //if (option == "ac")
            //{

            //    Console.WriteLine("-- Nhap thong tin khach hang --");
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.WriteLine("-- Nhap thong tin khach hang thu {0}--", j);
            //        kh[j] = new Customer();
            //        kh[j].input();
            //    }
            //    goto Loop;
            //}
            //if (option == "dae")
            //{
            //    Console.WriteLine("-- Thong tin nhan vien --");
            //    Console.WriteLine("\tID\tHo ten\tGioi tinh\tNgay sinh\tBang cap");
            //    for (int i = 0; i < n; i++)
            //       nv[i].output();
            //    goto Loop;
            //}
            //if (option == "dac")
            //{
            //    Console.WriteLine("-- Thong tin khach hang --");
            //    Console.WriteLine("\tID\tHo ten\tGioi tinh\tNgay sinh\tLoai khach hang");
            //    for (int j = 0; j < m; j++)
            //    {
            //       kh[j].output();
            //    }
            //    goto Loop;
            //}
            //if (option == "no")
            //    Console.Write("\nNhan phim enter để thoat khoi chuong trinh");
            #endregion

            #region Dùng List
            Staff.NextID_NV = 100;
            Customer.NextID_KH = 1000;
            
            List <Staff> nhanvien = new List<Staff>();
            List<Customer> khachhang = new List<Customer>();

            // string s;

            Console.WriteLine("ae-them nhan vien\nac-them khach hang\ndae-hien thi thong tin nhan vien\ndac-hien thi thong tin khach hang\ncs-thong ke khach hang\nno-thoat khoi chuong trinh");
            Loop:
            Console.Write("\nMoi ban nhap lua chon: ");
            string option = Console.ReadLine();
            if (option == "ae")
            {
                Console.WriteLine("-- Nhap thong tin nhan vien --");
                Staff nv = new Staff();
                nv.input();
                nhanvien.Add(nv);
                goto Loop;
            }

            if (option == "ac")
            {
                Console.WriteLine("-- Nhap thong tin nhan vien --");
                Customer kh = new Customer();
                kh.input();
                khachhang.Add(kh);
                goto Loop;
            }

            if (option == "dae")
            {
                Console.WriteLine("-- Thong tin nhan vien --");
                Console.WriteLine("\tID\tHo ten\tGioi tinh\tNgay sinh\tBang cap");
                foreach (var nv in nhanvien)
                    nv.output();
                goto Loop;
            }

            if (option == "dac")
            {
                Console.WriteLine("-- Thong tin khach hang --");
                Console.WriteLine("\tID\tHo ten\tGioi tinh\tNgay sinh\tLoai KH");
                foreach (var kh in khachhang)
                    kh.output();
                goto Loop;
            }

            if (option=="cs")
            { 
                int cNew = 0;
                int cMem = 0;
                int cVip = 0;
                foreach (var item in khachhang)
                {
                    if (item.LoaiKH == "moi")
                        cNew++;
                    else if (item.LoaiKH == "thanh vien")
                        cMem++;
                    else
                        cVip++;
                }
                Console.WriteLine("So luong khach hang moi: {0}\nSo lượng khach hang thanh vien: {1}\nSo luong khach hang Vip: {2}", cNew, cMem, cVip);
            }

            if (option == "no")
                Console.Write("\nNhan phim enter để thoat khoi chuong trinh");
            #endregion
            Console.ReadKey();
        }
    }
}

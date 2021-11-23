using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    class Customer:Person
    {
        private string loaiKH;
        public static int NextID_KH;

        public string LoaiKH
        {
            get{return loaiKH;}
            set{loaiKH = value;}
        }

        public Customer()
        {
            Id = NextID_KH;
            NextID_KH++;
        }

        //public Customer(string ht, string gt, DateTime ns, string loai):base(ht, gt,ns)
        //{
        //    LoaiKH = loai;
        //}

        public override void input()
        {
            base.input();
            Console.Write("Loai khach hang: ");
            LoaiKH = Console.ReadLine();
        }
        public override void output()
        {
            base.output();
            Console.Write(LoaiKH);
        }
    }
}

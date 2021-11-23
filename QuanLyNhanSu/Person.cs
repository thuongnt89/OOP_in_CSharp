using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    class Person
    {
        private int id;
        private string hoten;
        private string gioitinh;
        private DateTime ngaysinh;

        protected int Id
        {
            get{return id;}
            set{id = value;}
        }

        protected string Hoten
        {
            get{return hoten;}
            set{hoten = value;}
        }

        protected string Gioitinh
        {
            get{return gioitinh;}
            set{gioitinh = value;}
        }

        protected DateTime Ngaysinh
        {
            get{return ngaysinh;}
            set{ngaysinh = value;}
        }

        protected Person()
        {
        }

        //public Person(string ht, string gt, DateTime ns)
        //{
        //    Hoten = ht;
        //    Gioitinh = gt;
        //    Ngaysinh = ns;
        //}


        public virtual void input()
        {
         
            Console.Write("Nhap ho ten: ");
            Hoten = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            Gioitinh = Console.ReadLine();
            Console.Write("Nhap ngay sinh:\n");
            Console.Write(" + Nhap ngay:");
            int day = int.Parse(Console.ReadLine());
            Console.Write(" + Nhap thang:");
            int month = int.Parse(Console.ReadLine());
            Console.Write(" + Nhap nam:");
            int year = int.Parse(Console.ReadLine());
            Ngaysinh = new DateTime(year, month, day);

        }

        public virtual void output()
        {
            Console.Write("\t{0}\t{1}\t{2}\t{3}\t", Id, Hoten, Gioitinh, Ngaysinh);
        }
    }
}

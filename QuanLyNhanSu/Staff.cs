using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    class Staff:Person
    {
        private string bangcap;

        public static int NextID_NV;
        
        public string Bangcap
        {
            get{return bangcap;}
            set{bangcap = value;}
        }
        public Staff()
        {
            Id = NextID_NV;
            NextID_NV++;
        }

        //public Staff(string ht, string gt, DateTime ns, string bc) : base(ht, gt, ns)
        //{
        //    Bangcap = bc;
        //}

        public override void input()
        {
            base.input();
            Console.Write("Bang cap: ");
            Bangcap = Console.ReadLine();
        }
        public override void output()
        {
            base.output();
            Console.WriteLine(Bangcap);
        }
    }
}

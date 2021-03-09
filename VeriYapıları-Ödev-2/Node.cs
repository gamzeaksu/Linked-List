using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapıları_Ödev_2
{
    class Node
    {
        public int num;
        public string isim;
        public double ort;
        public Node sonraki;
        public Node(int numara,string isim,double ortlama)
        {
            num = numara;
            this.isim = isim;
            ort = ortlama;
            sonraki = null;
        }
    }
}

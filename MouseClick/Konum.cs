using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseClick
{
    class Konum
    {
        int x;
        int y;
        int aralik;

        public Konum(int x,int y,int aralik) {
            this.x = x;
            this.y = y;
            this.aralik = aralik;
        }

        public int X
        {
            set { x = value; }
            get { return x; }
        }

        public int Y
        {
            set { y = value; }
            get { return y; }
        }

        public int Aralik
        {
            set { aralik = value; }
            get { return aralik; }
        }



    }
}

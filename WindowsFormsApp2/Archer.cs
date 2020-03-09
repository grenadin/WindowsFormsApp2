using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Archer
    {
        public int ArrowCount { get; set; }

        public Archer(int arrowCount)
        {
            this.ArrowCount = arrowCount;
        }

        public int Shoot()
        {
            if (ArrowCount <= 0)
                return 0;
            return --ArrowCount;
        }

        public int Reload()
        {
            
            return ArrowCount += 10;
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class BreakableWall : Curtis_sRect
    {
        public float X_Location;
        public float Y_Location;
        public bool Broken = false;

      
        public BreakableWall() : base(910, 0, 20, 1000, 20)
        {
            X_Location = 910;
            Y_Location = 0;
            
        }
    }
}

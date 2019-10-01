using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class Sword
    {
        public float X_Location { get; private set; }
        public float Y_Location { get; private set; }

        public bool Collected { get; private set; }

        public Sword()
        {
            X_Location = 750.0f;
            Y_Location = 400.0f;
            Collected = false;
        }

        public void Collect()
        {
            Collected = true;
        }
    }
}

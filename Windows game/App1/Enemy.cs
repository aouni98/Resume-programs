using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class Enemy
    {
        public float X_Location { get; private set; }
        public float Y_Location { get; private set; }

        public Enemy(float x = 200, float y = 100)
        {
            X_Location = x;
            Y_Location = y;
        }

        public void MoveToPlayer(float player_x, float player_y)
        {
            if (X_Location < player_x)
            {
                X_Location += 1;
            }
            if (X_Location > player_x)
            {
                X_Location -= 1;
            }
            if (Y_Location < player_y)
            {
                Y_Location += 1;
            }
            if (Y_Location > player_y)
            {
                Y_Location -= 1;
            }
        }

    }
}

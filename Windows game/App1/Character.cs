using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    static public class Character
    {
        static public bool swordCollected = false;
       static public float DAMPING = 0.2f;
       static public float MAXIMUMSPEED = 8f;
       static public float X_Location { get; set; } = 300.0f;
       static public float Y_Location { get; set; } = 300.0f;
       static public bool Attacking { get; private set; } 
       static  public List<float> xprev = new List<float>();
       static  public List<float> yprev = new List<float>();
  

        static public void MoveCharacter(float x, float y,List<Curtis_sRect> walls)
        {
            bool move = true;
            foreach (Curtis_sRect test in walls)
            {
                Double wallx = test.x;
                Double wally = test.y;
                Double wallwidth = test.width;
                Double wallheight = test.height;
                int wallBrush = test.brushSize / 2;
                if (!((X_Location + x * MAXIMUMSPEED - 25 < wallx + wallwidth + wallBrush) && (X_Location + x * MAXIMUMSPEED + 25 > wallx - wallBrush) && (Y_Location - y * MAXIMUMSPEED - 25 < wally + wallheight + wallBrush) && (Y_Location - y * MAXIMUMSPEED + 25 > wally - wallBrush)))
                {

                }

                else
                {
                    move = false;
                }
            }
            if (!move)
            {
                if ((x > DAMPING || x < -DAMPING) && (x * MAXIMUMSPEED > 0))
                {
                    X_Location += 0;//xprev[xprev.Count - 2];
                }
                if ((x > DAMPING || x < -DAMPING) && (x * MAXIMUMSPEED < 0))
                {
                    X_Location += 0;// xprev[xprev.Count - 2];
                }
                if ((y > DAMPING || y < -DAMPING) && (y * MAXIMUMSPEED > 0))
                {
                    Y_Location += 0;// yprev[xprev.Count - 2];
                }
                if ((y > DAMPING || y < -DAMPING) && (y * MAXIMUMSPEED < 0))
                {
                    Y_Location += 0;// yprev[xprev.Count - 2];
                }
            }
            else
            {
                if (x > DAMPING || x < -DAMPING) X_Location += x * MAXIMUMSPEED;
                if (y > DAMPING || y < -DAMPING) Y_Location -= y * MAXIMUMSPEED;
                xprev.Add(X_Location);
                yprev.Add(Y_Location);
                
            }
        }

        //public void Hurt()
        //{

        //}
    }
}

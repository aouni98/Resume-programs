using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class Curtis_sRect
    {
        public float x { private set; get; }
        public float y { private set; get; }
        public float width { private set; get; }
        public float height { private set; get; }
        public int brushSize { private set; get; }

       public Curtis_sRect(float x, float y, float width, float height, int brushSize)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.brushSize = brushSize;
        }
    }
}

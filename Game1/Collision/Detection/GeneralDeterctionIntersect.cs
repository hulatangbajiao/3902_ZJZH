using Game1.Collision;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Detection
{
    class GeneralDeterctionIntersect
    {
        public Rectangle rectangle1;
        public Rectangle rectangle2;
        public Rectangle intersectionRectangle;

        public GeneralDeterctionIntersect(Rectangle rectangle1, Rectangle rectagle2)
        {
            this.rectangle1 = rectangle1;
            this.rectangle2 = rectagle2;
        }

        public Rectangle GetRectangle()
        {
            intersectionRectangle = Rectangle.Intersect(rectangle1, rectangle2);
            return intersectionRectangle;
        }
    }
}


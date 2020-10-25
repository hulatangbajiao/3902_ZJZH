using Game1.Collision;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Detection
{
    class GeneralDetection
    {
        public Rectangle rectangle1;
        public Rectangle rectangle2;
        public Rectangle intersectionRectangle;

        public GeneralDetection(Rectangle rectangle1, Rectangle rectagle2)
        {
            this.rectangle1 = rectangle1;
            this.rectangle2 = rectagle2;
        }
        public ICollision ifCollision()
        {
            Rectangle intersectionRectangle = new Rectangle();
            intersectionRectangle = Rectangle.Intersect(rectangle1, rectangle2);


            if (!intersectionRectangle.IsEmpty)
            {
                if (intersectionRectangle.Height > intersectionRectangle.Width && rectangle1.X < rectangle2.X)
                {
                    return ICollision.Left;

                }
                else if (intersectionRectangle.Height > intersectionRectangle.Width && rectangle1.X > rectangle2.X)
                {
                    return ICollision.Right;
                }
                else if (intersectionRectangle.Height < intersectionRectangle.Width && rectangle1.Y > rectangle2.Y)
                {
                    return ICollision.Bottom;
                }
                else if (intersectionRectangle.Height < intersectionRectangle.Width && rectangle1.Y < rectangle2.Y)
                {
                    return ICollision.Top;
                }
            }
            return ICollision.Null;
        }
    }
}


using Game1.Collision;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Collision
{
    class BottomCollision : ICollision
    {
        private Rectangle rectangle;
        public BottomCollision(Rectangle rectangle)
        {
            this.rectangle = rectangle;
        }
        public String Getside()
        {
            return "Bottom";
        }
    }
}

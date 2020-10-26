using Game1.Collision.CollisionHandler;
using Game1.Block;
using Game1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game1.Sprite_;
using Game1.Collision;
using Microsoft.Xna.Framework;

namespace Game1.Collision.CollisionHandler
{
    class LinkBlockCollisionHandler :IHandler
    {
        private ICollision side;
        private IBlock block;
        private ILink Link;
        private Rectangle intersectRectangle;

        public LinkBlockCollisionHandler(ILink link, IBlock block, ICollision side, Rectangle intersectRectangle)
        {
            this.Link = link;
            this.block = block;
            this.side = side;
            this.intersectRectangle = intersectRectangle;
        }
        public void Execute()
        {

            if (side == ICollision.Left)
            {
                GlobalDefinitions.Position.X = GlobalDefinitions.Position.X - intersectRectangle.Width;
            }
            else if (side == ICollision.Right)
            {
                GlobalDefinitions.Position.X = GlobalDefinitions.Position.X + intersectRectangle.Width;
            }
            else if (side == ICollision.Bottom)
            {
                GlobalDefinitions.Position.Y = GlobalDefinitions.Position.Y + intersectRectangle.Height;
            }
            else if (side == ICollision.Top)
            {
                GlobalDefinitions.Position.Y = GlobalDefinitions.Position.Y - intersectRectangle.Height;
            }
        }

    }
}



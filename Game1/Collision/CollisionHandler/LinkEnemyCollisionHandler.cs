using Game1.CollisionHandler;
using Game1.Enemy_NPC;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Collision
{
    class LinkEnemyCollisionHandler : IHandler
    {
        public ICollision side;
        public ILink link;
        public IEnemy enemy;
        public Rectangle intersectRectangle;

        public LinkEnemyCollisionHandler(IEnemy enemy, ILink link, ICollision side, Rectangle intersectRectangle)
        {
            this.enemy = enemy;
            this.link = link;
            this.side = side;
            this.intersectRectangle = intersectRectangle;
        }
        public void Execute()
        {
            if (side == ICollision.Left)
            {
                GlobalDefinitions.Position.X = GlobalDefinitions.Position.X - intersectRectangle.Width;
                link.State.TakeDamage();
            }
            else if (side == ICollision.Right)
            {
                GlobalDefinitions.Position.X = GlobalDefinitions.Position.X + intersectRectangle.Width;
                link.State.TakeDamage();
            }
            else if (side == ICollision.Bottom)
            {
                GlobalDefinitions.Position.Y = GlobalDefinitions.Position.Y + intersectRectangle.Height;
                link.State.TakeDamage();
            }
            else if (side == ICollision.Top)
            {
                GlobalDefinitions.Position.Y = GlobalDefinitions.Position.Y - intersectRectangle.Height;
                link.State.TakeDamage();
            }
        }
    }
}

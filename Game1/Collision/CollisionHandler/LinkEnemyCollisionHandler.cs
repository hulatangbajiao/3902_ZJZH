using Game1.CollisionHandler;
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
                enemy.Hit();
                link.TakeDamage(new Vector2(1,0));
            }
            else if (side == ICollision.Right)
            {
                enemy.Hit();
                link.TakeDamage(new Vector2(-1, 0));
            }
            else if (side == ICollision.Bottom)
            {
                enemy.Hit();
                link.TakeDamage(new Vector2(0, -1));
            }
            else if (side == ICollision.Top)
            {
                enemy.Hit();
                link.TakeDamage(new Vector2(0, 1));
            }
        }
    }
}

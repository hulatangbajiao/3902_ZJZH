using Game1.CollisionHandler;
using Game1.Interfaces;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Collision
{
    class EnemyBlockCollisionHandler : IHandler
    {
        private ICollision side;
        private IEnemy enemy;
        private IBlock block;
        private Rectangle intersectRectangle;

        public EnemyBlockCollisionHandler(IEnemy enemy, IBlock block, ICollision side, Rectangle intersectRectangle)
        {
            this.enemy = enemy;
            this.block = block;
            this.side = side;
            this.intersectRectangle = intersectRectangle;
        }

        public void Execute()
        {
            if (side == ICollision.Left)
            {
                enemy.Position = enemy.Position - new Vector2(1, 0) * intersectRectangle.Width;
             
            }
            else if (side == ICollision.Right)
            {
                enemy.Position = enemy.Position + new Vector2(1, 0) * intersectRectangle.Width;
               
            }
            else if (side == ICollision.Bottom) {
                enemy.Position = enemy.Position + new Vector2(0, 1) * intersectRectangle.Height;
               
            } else if (side == ICollision.Top) {
                enemy.Position = enemy.Position - new Vector2(0, 1) * intersectRectangle.Height;
            
            }
        }
    }
}


using Game1.CollisionHandler;
using Game1.Enemy_NPC;
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
                enemy.position.X = enemy.position.X - intersectRectangle.Width;
                enemy.State.MoveLeft();
            }
            else if (side == ICollision.Right)
            {
                enemy.position.X = enemy.position.X + intersectRectangle.Width;
                enemy.State.MoveRight();
            }
            else if (side == ICollision.Bottom) {
                enemy.position.Y = enemy.position.Y + intersectRectangle.Height;
                enemy.State.MoveDown();
            } else if (side == ICollision.Top) {
                enemy.position.Y = enemy.position.Y - intersectRectangle.Height;
                enemy.State.MoveUp();
            }
        }
    }
}


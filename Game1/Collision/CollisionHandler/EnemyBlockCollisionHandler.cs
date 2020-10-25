using Game1.CollisionHandler;
using Game1.Enemy_NPC;
using Game1.Interfaces;
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

        public EnemyBlockCollisionHandler(IEnemy enemy, IBlock block, ICollision side)
        {
            this.enemy = enemy;
            this.block = block;
            this.side = side;
        }

        public void Execute()
        {
            if (side == ICollision.Left)
            {
                enemy.State.MoveLeft();
            }
            else if (side == ICollision.Right)
            {
                enemy.State.MoveRight();
            }
            else if (side == ICollision.Bottom)
            {
                enemy.State.MoveDown();
            } 
            else if (side == ICollision.Top) 
            {
                enemy.State.MoveUp();
            }
        }
    }
}


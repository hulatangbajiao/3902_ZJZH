using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Collision
{
    class EnemyBlockCollisionHandler 
    {
        
        private ICollision side;

        public LinkEnemyCollisionHandler(IEnemy enemy, IBlock block, ICollison side)
        {
            this.enemy = enemy;
            this.block = block;
            this.side = side;
        }

        public void Execute()
        {
            if (side == left)
            {
                enemy.State = new EnemyMovingRight();
            }

        }
    }
}

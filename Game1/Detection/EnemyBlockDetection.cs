using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Detection
{
    class EnemyBlockDetection : IDetection
    {
        private IEnemy enemy;
        private IBlock block;
        public EnemyBlockDetection()
        {
            this.enemy = enemy;
            this.block = block;
        }
        public void update()
        {
            Rectangle ifCollision = new Rectangle();
            ifCollision = Rectangle.Intersect(enemy.rectangle, block.rectangle);
            if (!ifCollision.IsEmpty)
            {
                new EnemyBlockCollisionHandler(enemy, block, side);
            }
        }
    }
}

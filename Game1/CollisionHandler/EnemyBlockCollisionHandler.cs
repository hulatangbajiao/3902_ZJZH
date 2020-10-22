using Game1.Interfaces;
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
            String s = side.Getside();
            if (side.Equals("Left"))
            {
                enemy.moveLeft();
            } else if (side.Equals("Right"))
            {
                enemy.moveRight();
            } else if (side.Equals("Bottom"))
            {
                enemy.movedown();
            } else if (side.Equals("Top"))
            {
                enemy.moveUp();
            } 
        }
    }
}

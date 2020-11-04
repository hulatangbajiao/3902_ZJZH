using Game1.Collision;
using Game1.Interfaces;
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
        public IEnemyList enemyList;
        public IBlockList blockList;

        public EnemyBlockDetection(IEnemyList enemyList, IBlockList blockList)
        {
            this.enemyList = enemyList;
            this.blockList = blockList;
        }
        public void update()
        {
            foreach (IEnemy enemy in enemyList)
            {
                foreach (IBlock block in blockList.blockList)
                {
                    Rectangle ifCollision = new Rectangle();
                    ifCollision = Rectangle.Intersect(enemy.rectangle, block.rectangle);
                    ICollision side = new NullCollision(ifCollision);
                    if (!ifCollision.IsEmpty)
                    {
                        if (ifCollision.Height > ifCollision.Width && enemy.X < block.X)
                        {
                            side = new LeftCollision(ifCollision);
                            new EnemyBlockCollisionHandler(enemy, block, side).Execute();
                        } else if (ifCollision.Height > ifCollision.Width && enemy.X > block.X)
                        {
                            side = new RightCollision(ifCollision);
                            new EnemyBlockCollisionHandler(enemy, block, side).Execute();
                        } else if (ifCollision.Height < ifCollision.Width && enemy.Y > block.Y)
                        {
                            side = new TopCollision(ifCollision);
                            new EnemyBlockCollisionHandler(enemy, block, side).Execute();
                        } else if (ifCollision.Height < ifCollision.Width && enemy.Y < block.Y)
                        {
                            side = new BottomCollision(ifCollision);
                            new EnemyBlockCollisionHandler(enemy, block, side).Execute();
                        } else
                        {
                            new EnemyBlockCollisionHandler(enemy, block, side).Execute();
                        }
                    }
                }
            }
        }
    }
}

using Game1.CollisionHandler;
using Game1.Enemy_NPC;
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

        public LinkEnemyCollisionHandler(IEnemy enemy, ILink link, ICollision side)
        {
            this.enemy = enemy;
            this.link = link;
            this.side = side;
        }
        public void Execute()
        { 
            if (side != ICollision.Null)
            {
                enemy.exist = false;
            }
        }
    }
}

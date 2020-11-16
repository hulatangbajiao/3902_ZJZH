using Game1.CollisionHandler;
using Game1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Collision
{
    class EnemyProjectileCollisonHandler : IHandler
    {
        private ICollision side;
        private IEnemy enemy;
        private IProjectile projectile;

        public EnemyProjectileCollisonHandler(IEnemy enemy, IProjectile projectile, ICollision side)
        {
            this.enemy = enemy;
            this.projectile = projectile;
            this.side = side;
        }

        public void Execute()
        {
            if (side != ICollision.Null&&enemy.exist&&projectile.exist)
            {
                enemy.exist = false;
                projectile.exist = false;
            }
        }
    }
}

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
            
            if (side == ICollision.Left)
            {
                enemy.TakeDamage(new Vector2(1, 0));
                projectile.Hit();
                
            }
            else if (side == ICollision.Right)
            {
                enemy.TakeDamage(new Vector2(-1, 0));
                projectile.Hit();
                
            }
            else if (side == ICollision.Bottom)
            {
                enemy.TakeDamage(new Vector2(0, -1));
                projectile.Hit();
                
            }
            else if (side == ICollision.Top)
            {
                enemy.TakeDamage(new Vector2(0, 1));
                projectile.Hit();
                
            }
        }
    }
}

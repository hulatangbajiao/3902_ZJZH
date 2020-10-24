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
    class LinkProjectileCollisonHandler : IHandler
    {
        
        private ICollision side;
        private IEnemy enemy;
        private IProjectile projectile;

        public LinkProjectileCollisonHandler(IEnemy enemy, IProjectile projectile, ICollision side)
        {
            this.enemy = enemy;
            this.projectile = projectile;
            this.side = side;
        }

        public void Execute()
        {
            
            if (side == ICollision.Bottom)
            {
                
            } else if (side == ICollision.Left)
            {
                
            } else if (side == ICollision.Right)
            {
                
            } else if (side == ICollision.Top)
            {
                
            } 
        }
    }
}

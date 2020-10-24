using Game1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Collision
{
    class LinkProjectileCollisonHandler
    {
        
        private ICollision side;
        private ILink link;
        private IProjectile projectile;

        public LinkProjectileCollisonHandler(ILink link, IProjectile projectile, ICollision side)
        {
            this.link = link;
            this.projectile = projectile;
            this.side = side;
        }

        public void Execute()
        {
            
            if (side == ICollision.Bottom)
            {
                link.TakeDamage();
            } else if (side == ICollision.Left)
            {
                link.TakeDamage();
            } else if (side == ICollision.Right)
            {
                link.TakeDamage();
            } else if (side == ICollision.Top)
            {
                link.TakeDamage();
            } 
        }
    }
}

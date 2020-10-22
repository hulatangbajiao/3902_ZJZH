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
    class LinkProjectileDetection : IDetection
    {
        private ILink link;
        private IProjectile projectile;


        public LinkProjectileDetection(ILink link, IProjectile projectile)
        {
            this.link = link;
            this.projectile = projectile;

        }
        public void update()
        {
            Rectangle ifCollision = new Rectangle();
            ifCollision = Rectangle.Intersect(link.rectangle, projectile.rectangle);
            if (!ifCollision.IsEmpty)
            {
                if (ifCollision.Height > ifCollision.Width && link.X < projectile.X)
                {
                    new LinkProjectileCollisonHandler(link, projectile, ICollision.Left).Execute();
                }
                else if (ifCollision.Height > ifCollision.Width && link.X > projectile.X)
                {
                    new LinkProjectileCollisonHandler(link, projectile, ICollision.Right).Execute();
                }
                else if (ifCollision.Height < ifCollision.Width && link.Y > projectile.Y)
                {
                    new LinkProjectileCollisonHandler(link, projectile, ICollision.Bottom).Execute();
                }
                else if (ifCollision.Height < ifCollision.Width && link.Y < projectile.Y)
                {
                    new LinkProjectileCollisonHandler(link, projectile, ICollision.Top).Execute();
                }
                else
                {
                    new LinkProjectileCollisonHandler(link, projectile, ICollision.Null).Execute();
                }
            }
        }
    }
}


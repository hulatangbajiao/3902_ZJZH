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
            Rectangle LinkRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 96, 96);
            Rectangle projectileRectangle = new Rectangle((int)GlobalDefinitions.OctPosition.X, (int)GlobalDefinitions.OctPosition.Y, 96, 96);
            Rectangle ifCollision = new Rectangle();
            ifCollision = Rectangle.Intersect(LinkRectangle, projectileRectangle);
            ICollision side = new NullCollision(ifCollision);
            if (!ifCollision.IsEmpty)
            {
                if (ifCollision.Height > ifCollision.Width && LinkRectangle.X < projectileRectangle.X)
                {
                    side = new LeftCollision(ifCollision);
                    new LinkProjectileCollisonHandler(link, projectile, side).Execute();
                }
                else if (ifCollision.Height > ifCollision.Width && LinkRectangle.X > projectileRectangle.X)
                {
                    side = new RightCollision(ifCollision);
                    new LinkProjectileCollisonHandler(link, projectile, side).Execute();
                }
                else if (ifCollision.Height < ifCollision.Width && LinkRectangle.Y > projectileRectangle.Y)
                {
                    side = new TopCollision(ifCollision);
                    new LinkProjectileCollisonHandler(link, projectile, side).Execute();
                }
                else if (ifCollision.Height < ifCollision.Width && LinkRectangle.Y < projectileRectangle.Y)
                {
                    side = new BottomCollision(ifCollision);
                    new LinkProjectileCollisonHandler(link, projectile, side).Execute();
                }
                else
                {
                    new LinkProjectileCollisonHandler(link, projectile, side).Execute();
                }
            }
        }
    }
}
 

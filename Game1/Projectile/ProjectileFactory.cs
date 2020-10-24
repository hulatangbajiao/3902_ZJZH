using Game1.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class ProjectileFactory : IProjectileFactory
    {
        public List<IProjectile> ProjectileList { get; set; }

        public ProjectileFactory(MainStage game)
        {
            
        }

        public void Initialize() 
        {
            ProjectileList = new List<IProjectile>();

        }

        public void AddArrow(Vector2 position, Vector2 direction)
        {
            ProjectileList.Add(new Arrow(position, direction));

        }

        public void AddBomb(Vector2 position, Vector2 direction)
        {
            ProjectileList.Add(new Bomb(position, direction));

        }
        public void AddBoomer(Vector2 position, Vector2 direction)
        {
            ProjectileList.Add(new Boomer(position, direction));

        }

        public void AddFireBall(Vector2 position, Vector2 direction)
        {
            ProjectileList.Add(new FireBall(position, direction));

        }



        public void Update()
        {
           
            foreach (IProjectile projectile in ProjectileList)
            {
                projectile.Update();
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            
            foreach (IProjectile projectile in ProjectileList)
            {
                projectile.Draw(spriteBatch);
            }
        }
    }
    

}

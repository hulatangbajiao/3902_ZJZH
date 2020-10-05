using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public interface IProjectileFactory
    {
        
        void Initialize();
        void AddArrow(Vector2 position, Vector2 direction);
        void AddBomb(Vector2 position, Vector2 direction);
        void AddBoomer(Vector2 position, Vector2 direction);
        void Update();
        void Draw(SpriteBatch spriteBatch);
        
    }
}

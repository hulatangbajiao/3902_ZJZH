using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public interface IProjectile
    {
        
        Vector2 Position { get; set; }
        Vector2 Direction { get; set; }
        int Velocity { get; set; }
        bool exist { get; set; }
        void Update();
        void Draw(SpriteBatch spriteBatch);
        Rectangle GetRectangle();
    }
}

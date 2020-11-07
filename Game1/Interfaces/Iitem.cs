using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Interfaces
{
    public interface IItem
    {
        
        Vector2 Position { get; set; }
        
        bool exist { get; set; }
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}







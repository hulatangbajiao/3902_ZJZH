using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public interface IGeneralSprite
    {
        Color color { get; set; }
        void Update();
        void ChangeColor();
        

        void Draw(Texture2D SpriteSheet, SpriteBatch spriteBatch, Vector2 Position);
        Rectangle GetRectangle();
        void Draw(Func<Texture2D> getInventoryBackgroundSpriteSheet, object spriteBatch);
    }
}
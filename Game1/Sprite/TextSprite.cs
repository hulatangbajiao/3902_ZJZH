using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Sprite
{
    class TextSprite : ISprite
    {
        private SpriteFont font = Texture2DStorage.GetFont();
        private String content;
        
        public TextSprite(String content)
        {
            content = this.content;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            spriteBatch.DrawString(font, content, Position, Color.White);
        }

        public Rectangle GetRectangle()
        {
            return new Rectangle();
        }

        public void Update()
        {
            
        }
    }
}

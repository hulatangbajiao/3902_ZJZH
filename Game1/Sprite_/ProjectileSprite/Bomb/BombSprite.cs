using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class BombSprite : ISprite
    {

        private int timer;
        private int currentFrame = 0;
        private Rectangle destinationRectangle;

        public BombSprite()
        {
            timer = 120;

        }

        public void Update()
        {
            timer--;
            if (timer == 60 || timer == 40 || timer == 20)
            {
                currentFrame++;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            Rectangle sourceRectangle;
            
            Texture2D Texture = Texture2DStorage.GetBombSpriteSheet();

            if (currentFrame == 0)
            {
                sourceRectangle = new Rectangle(0, 0, 16, Texture.Height);
                destinationRectangle = new Rectangle((int)Position.X+10, (int)Position.Y-10, 40, 80);
            }
            else 
            {
                sourceRectangle = new Rectangle(16 + (Texture.Width - 16)/3*(currentFrame-1), 0, (Texture.Width - 16)/3, Texture.Height);
                destinationRectangle = new Rectangle((int)Position.X, (int)Position.Y, 60, 60);
            }

            
           





            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);//use Texture2DStorage class to load texture2D
        }
        public Rectangle GetRectangle()
        {
            return destinationRectangle;
        }

    }
}

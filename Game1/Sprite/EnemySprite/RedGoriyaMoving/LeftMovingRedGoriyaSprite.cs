using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Sprite_.Enemy_Sprite.RedGoriyaMoving
{
    class LeftMovingRedGoriyaSprite : ISprite
    {
        private int currentFrame = 0;
        private int totalFrame = 10;
        private Rectangle destinationRectangle;
        public LeftMovingRedGoriyaSprite()
        {

        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrame)
                currentFrame = 0;

            
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame < 5)
            {
                sourceRectangle = new Rectangle(0, 0, 100, 96);
                destinationRectangle = new Rectangle((int)Position.X, (int)Position.Y, 96, 96);   
            }


            else
            {
                sourceRectangle = new Rectangle(100, 0, 192, 96);
                destinationRectangle = new Rectangle((int)Position.X, (int)Position.Y, 192, 96);
            }

            spriteBatch.Draw(Texture2DStorage.GetLeftMovingRedGoriyaSpriteSheet(), destinationRectangle, sourceRectangle, Color.White);
        }
        public Rectangle GetRectangle()
        {
            return destinationRectangle;
        }
    }
}

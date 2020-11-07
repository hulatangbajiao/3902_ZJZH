using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Sprite_.Enemy_Sprite.AquamentusMoving
{
    class LeftMovingAquamentusSprite : ISprite
    {
        private int currentFrame = 0;
        private int totalFrame = 20;
        private Rectangle destinationRectangle;
        public LeftMovingAquamentusSprite()
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
            

            if (currentFrame < 5)
            {
                sourceRectangle = new Rectangle(0, 0, 150, 204);
                
            }
            else if (5 <= currentFrame && currentFrame < 10)
            {
                sourceRectangle = new Rectangle(152, 0, 150, 204);
                
            }
            else if (10 <= currentFrame && currentFrame < 15)
            {
                sourceRectangle = new Rectangle(303, 0, 150, 204);
                
            }
            else
            {
                sourceRectangle = new Rectangle(454, 0, 150, 204);
                
            }
            destinationRectangle = new Rectangle((int)Position.X, (int)Position.Y, 150, 204);

            spriteBatch.Draw(Texture2DStorage.GetLeftAquamentusSpriteSheet(), destinationRectangle, sourceRectangle, Color.White);
        }
        public Rectangle GetRectangle()
        {
            return destinationRectangle;
        }
    }
}

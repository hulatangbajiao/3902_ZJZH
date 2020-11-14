using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Sprite_.Enemy_Sprite.AquamentusMoving
{
    class RightMovingAquamentusSprite : ISprite
    {
        private int currentFrame = 0;
        private int totalFrame = 80;
        private Rectangle destinationRectangle;
        public RightMovingAquamentusSprite()
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
            

            if (currentFrame < 20)
            {
                sourceRectangle = new Rectangle(0, 0, 150, 204);

            }
            else if (20 <= currentFrame && currentFrame < 40)
            {
                sourceRectangle = new Rectangle(152, 0, 150, 204);

            }
            else if (40 <= currentFrame && currentFrame < 60)
            {
                sourceRectangle = new Rectangle(303, 0, 150, 204);

            }
            else
            {
                sourceRectangle = new Rectangle(454, 0, 150, 204);

            }
            destinationRectangle = new Rectangle((int)Position.X, (int)Position.Y, 150, 204);

            spriteBatch.Draw(Texture2DStorage.GetRightAquamentusSpriteSheet(), destinationRectangle, sourceRectangle, Color.White);
        }
        public Rectangle GetRectangle()
        {
            return destinationRectangle;
        }
    }
}

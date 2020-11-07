using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Sprite_.Enemy_Sprite.OctMoving
{
    class RightMovingBlueBatSprite : ISprite
    {
        private int currentFrame = 0;
        private int totalFrame = 10;
        private Rectangle destinationRectangle;
        public RightMovingBlueBatSprite()
        {
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrame)
                currentFrame = 0;

            
        }
        public  void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            Rectangle sourceRectangle;
            

            if (currentFrame < 5)
            {
                sourceRectangle = new Rectangle(0, 0, 96, 96);
                destinationRectangle = new Rectangle((int)Position.X, (int)Position.Y, 96, 96);
            }


            else
            {
                sourceRectangle = new Rectangle(0, 96, 96, 192);
                destinationRectangle = new Rectangle((int)Position.X, (int)Position.Y, 96, 192);
            }
            spriteBatch.Draw(Texture2DStorage.GetRightMovingBlueBatSpriteSheet(), destinationRectangle, sourceRectangle, Color.White);
        }
        public Rectangle GetRectangle()
        {
            return destinationRectangle;
        }
    }
}

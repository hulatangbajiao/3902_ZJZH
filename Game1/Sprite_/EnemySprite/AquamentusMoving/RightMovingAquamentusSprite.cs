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
        private int totalFrame = 20;

        public RightMovingAquamentusSprite()
        {
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrame)
                currentFrame = 0;

            GlobalDefinitions.OctPosition.X = GlobalDefinitions.OctPosition.X + (float)1; //change the y axis position of Link
            if (GlobalDefinitions.OctPosition.X == GlobalDefinitions.GraphicsWidth)
            {
                GlobalDefinitions.OctPosition.X = 0;
            }
        }
        public  void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame < 5)
            {
                sourceRectangle = new Rectangle(0, 0, 150, 204);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.OctPosition.X, (int)GlobalDefinitions.OctPosition.Y, 150, 204);
            } else if (5<= currentFrame && currentFrame < 10)
            {
                sourceRectangle = new Rectangle(152, 0, 300, 204);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.OctPosition.X, (int)GlobalDefinitions.OctPosition.Y, 150, 204);
            } else if (10<= currentFrame && currentFrame < 15)
            {
                sourceRectangle = new Rectangle(303, 0, 454, 204);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.OctPosition.X, (int)GlobalDefinitions.OctPosition.Y, 150, 204);
            }
            else
            {
                sourceRectangle = new Rectangle(454, 0, 606, 204);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.OctPosition.X, (int)GlobalDefinitions.OctPosition.Y, 150, 204);
            }
            spriteBatch.Draw(Texture2DStorage.GetRightMovingAquamentusSpriteSheet(), destinationRectangle, sourceRectangle, Color.White);
        }
    }
}

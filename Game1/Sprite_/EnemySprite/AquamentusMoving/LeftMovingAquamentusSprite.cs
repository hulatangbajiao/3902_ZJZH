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
        private int totalFrame = 10;

        public LeftMovingAquamentusSprite()
        {

        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrame)
                currentFrame = 0;

            GlobalDefinitions.AquamentusPosition.X = GlobalDefinitions.AquamentusPosition.X - (float)1; //change the y axis position of Link
            if (GlobalDefinitions.AquamentusPosition.X == 0)
            {
                GlobalDefinitions.AquamentusPosition.X = (float)GlobalDefinitions.GraphicsWidth;
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame < 5)
            {
                sourceRectangle = new Rectangle(0, 0, 150, 204);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.AquamentusPosition.X, (int)GlobalDefinitions.AquamentusPosition.Y, 150, 204);
            }
            else if (5 <= currentFrame && currentFrame < 10)
            {
                sourceRectangle = new Rectangle(152, 0, 150, 204);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.AquamentusPosition.X, (int)GlobalDefinitions.AquamentusPosition.Y, 150, 204);
            }
            else if (10 <= currentFrame && currentFrame < 15)
            {
                sourceRectangle = new Rectangle(303, 0, 150, 204);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.AquamentusPosition.X, (int)GlobalDefinitions.AquamentusPosition.Y, 150, 204);
            }
            else
            {
                sourceRectangle = new Rectangle(454, 0, 150, 204);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.AquamentusPosition.X, (int)GlobalDefinitions.AquamentusPosition.Y, 150, 204);
            }
            spriteBatch.Draw(Texture2DStorage.GetLeftAquamentusSpriteSheet(), destinationRectangle, sourceRectangle, Color.White);
        }

    }
}

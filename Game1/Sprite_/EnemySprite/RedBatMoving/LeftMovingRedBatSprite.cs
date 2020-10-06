using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Sprite_.Enemy_Sprite.OctMoving
{
    class LeftMovingRedBatSprite : ISprite
    {
        private int currentFrame = 0;
        private int totalFrame = 10;

        public LeftMovingRedBatSprite()
        {

        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrame)
                currentFrame = 0;

            GlobalDefinitions.OctPosition.X = GlobalDefinitions.OctPosition.X - (float)1; //change the y axis position of Link
            if (GlobalDefinitions.OctPosition.X == 0)
            {
                GlobalDefinitions.OctPosition.X = (float)GlobalDefinitions.GraphicsWidth;
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame < 5)
            {
                sourceRectangle = new Rectangle(0, 0, 96, 96);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.OctPosition.X, (int)GlobalDefinitions.OctPosition.Y, 96, 96);   
            }


            else
            {
                sourceRectangle = new Rectangle(0, 96, 96, 192);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.OctPosition.X, (int)GlobalDefinitions.OctPosition.Y, 96, 192);
            }

            spriteBatch.Draw(Texture2DStorage.GetLeftMovingRedBatSpriteSheet(), destinationRectangle, sourceRectangle, Color.White);
        }

    }
}

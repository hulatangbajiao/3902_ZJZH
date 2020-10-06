using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Sprite_.Enemy_Sprite.OctMoving
{
    class DownMovingBlueOctSprite : ISprite
    {
        private int currentFrame = 0;
        private int totalFrame = 10;

        public DownMovingBlueOctSprite()
        {
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrame)
                currentFrame = 0;

            GlobalDefinitions.BlueOctPosition.Y = GlobalDefinitions.BlueOctPosition.Y + (float)1; //change the y axis position of Link
            if (GlobalDefinitions.BlueOctPosition.Y == GlobalDefinitions.GraphicsHeight)
            {
                GlobalDefinitions.BlueOctPosition.Y = 0;
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame < 5)
            {
                sourceRectangle = new Rectangle(0, 0, 96, 96);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.BlueOctPosition.X, (int)GlobalDefinitions.BlueOctPosition.Y, 96, 96);
            }


            else
            {
                sourceRectangle = new Rectangle(100, 0, 192, 96);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.BlueOctPosition.X, (int)GlobalDefinitions.BlueOctPosition.Y, 192, 96);
            }

            spriteBatch.Draw(Texture2DStorage.GetDownMovingBlueOctorokSpriteSheet(), destinationRectangle, sourceRectangle, Color.White);

        }
    }
}

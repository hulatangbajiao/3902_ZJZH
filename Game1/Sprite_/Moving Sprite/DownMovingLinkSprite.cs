using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class DownMovingLinkSprite : ISprite
    {
        private int currentFrame = 0;
        private int totalFrame = 2;

        public DownMovingLinkSprite()
        {


        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrame)
                currentFrame = 0;

            GlobalDefinitions.Position.Y = GlobalDefinitions.Position.Y + (float)1; //change the y axis position of Link
            if (GlobalDefinitions.Position.Y == 0)
            {
                GlobalDefinitions.Position.Y = (float)GlobalDefinitions.GraphicsHeight;
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame == 0)
            {
                sourceRectangle = new Rectangle(0, 0, 155, 208);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 90, 100);//I don't understand why the width of destinationRectangle has to be like this.
            }


            else
            {
                sourceRectangle = new Rectangle(527, 0, 691, 208);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 400, 100);
            }

            spriteBatch.Draw(Texture2DStorage.GetDownMovingLinkSpriteSheet(), destinationRectangle, sourceRectangle, Color.White);//use Texture2DStorage class to load texture2D
        }
    }
}

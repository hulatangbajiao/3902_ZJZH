using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class UpWoodenSwordLinkSprite : ISprite
    {
        private int currentFrame = 0;
        private int totalFrame = 4;

        public UpWoodenSwordLinkSprite()
        {


        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrame)
                currentFrame = 0;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame == 0)
            {
                sourceRectangle = new Rectangle(155, 164, 220, 218);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 100, 100);//I don't understand why the width of destinationRectangle has to be like this.
            }
            else if (currentFrame == 1)
            {
                sourceRectangle = new Rectangle(693, 14, 222, 366);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y - 90, 100, 190);
            }
            else if (currentFrame == 2)
            {
                sourceRectangle = new Rectangle(173, 564, 192, 382);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y - 50, 100, 150);
            }
            else
            {
                sourceRectangle = new Rectangle(711, 670, 192, 272);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y - 20, 100, 120);
            }

            spriteBatch.Draw(Texture2DStorage.GetUpWoodenSwordLinkSpriteSheet(), destinationRectangle, sourceRectangle, Color.White);//use Texture2DStorage class to load texture2D
        }
    }
}

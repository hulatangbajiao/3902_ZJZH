using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class LeftWoodenSwordLinkSprite : ISprite
    {
        private int currentFrame = 0;
        private int totalFrame = 4;

        public LeftWoodenSwordLinkSprite()
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
                sourceRectangle = new Rectangle(160, 160, 230, 230);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 100, 100);//I don't understand why the width of destinationRectangle has to be like this.
            }
            else if (currentFrame == 1)
            {
                sourceRectangle = new Rectangle(550, 150, 370, 230);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X - 90, (int)GlobalDefinitions.Position.Y, 190, 100);
            }
            else if (currentFrame == 2)
            {
                sourceRectangle = new Rectangle(60, 690, 320, 230);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X - 50, (int)GlobalDefinitions.Position.Y, 150, 100);
            }
            else
            {
                sourceRectangle = new Rectangle(650, 690, 270, 230);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X - 20, (int)GlobalDefinitions.Position.Y, 120, 100);
            }

            spriteBatch.Draw(Texture2DStorage.GetLeftWoodenSwordLinkSpriteSheet(), destinationRectangle, sourceRectangle, Color.White);//use Texture2DStorage class to load texture2D
        }
    }
}

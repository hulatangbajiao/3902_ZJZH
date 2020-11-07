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
        private int totalFrame = 12;

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

            if (currentFrame < 3)
            {
                sourceRectangle = new Rectangle(0, 0, 96, 162);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y-162+96, 96, 162);//I don't understand why the width of destinationRectangle has to be like this.
            }
            else if (3 <= currentFrame && currentFrame < 6)
            {
                sourceRectangle = new Rectangle(96, 0, 96, 162);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y - 162 + 96, 96, 162);
            }
            else if (6 <= currentFrame && currentFrame < 9)
            {
                sourceRectangle = new Rectangle(192, 0, 96, 162);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y - 162 + 96, 96, 162);
            }
            else
            {
                sourceRectangle = new Rectangle(288, 0, 96, 162);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y - 162 + 96, 96, 162);
            }

            spriteBatch.Draw(Texture2DStorage.GetUpWoodenSwordLinkSpriteSheet(), destinationRectangle, sourceRectangle, Color.White);//use Texture2DStorage class to load texture2D
        }
    }
}

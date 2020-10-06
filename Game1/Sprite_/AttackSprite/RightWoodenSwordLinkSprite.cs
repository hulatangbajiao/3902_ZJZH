using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class RightWoodenSwordLinkSprite : ISprite
    {
        private int currentFrame = 0;
        private int totalFrame = 12;

        public RightWoodenSwordLinkSprite()
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
                sourceRectangle = new Rectangle(0, 0, 96, 102);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 96, 102); 
            }
            else if (3 <= currentFrame && currentFrame < 6)
            {
                sourceRectangle = new Rectangle(96, 0, 162, 102);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 162, 102);
            }
            else if (6 <= currentFrame && currentFrame < 9)
            {
                sourceRectangle = new Rectangle(96+162, 0, 138, 102);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 138, 102);
            }
            else
            {
                sourceRectangle = new Rectangle(96+162+138, 0, 114, 102);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 114, 102);
            }

            spriteBatch.Draw(Texture2DStorage.GetRightWoodenSwordLinkSpriteSheet(), destinationRectangle, sourceRectangle, Color.White);//use Texture2DStorage class to load texture2D
        }
    }
}

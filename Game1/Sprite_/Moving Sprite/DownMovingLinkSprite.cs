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
        private int totalFrame = 10;
        private Rectangle destinationRectangle;
        public DownMovingLinkSprite()
        {
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrame)
                currentFrame = 0;

            GlobalDefinitions.Position.Y = GlobalDefinitions.Position.Y + (float)5; //change the y axis position of Link
            

        }

        public virtual void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            Rectangle sourceRectangle;
            

            if (currentFrame < 5)
            {
                sourceRectangle = new Rectangle(0, 0, 96, 96);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 96, 96); 
            }


            else
            {
                sourceRectangle = new Rectangle(96, 0, 192, 96);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 192, 96);
            }

            spriteBatch.Draw(Texture2DStorage.GetDownMovingLinkSpriteSheet(), destinationRectangle, sourceRectangle, Color.White);//use Texture2DStorage class to load texture2D
        }
        public Rectangle GetRectangle()
        {
            return destinationRectangle;
        }
    }
}

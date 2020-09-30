using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class UpMovingLinkSprite
    {
        private Vector2 location;
        private int currentFrame = 0;
        private int totalFrame = 2;

        public UpMovingLinkSprite(Vector2 location)
        {
            this.location = location;

        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrame)
                currentFrame = 0;

            location.Y = location.Y - (float)1; //change the x axis position of Link
            if (location.Y == 0)
            {
                location.Y = (float)GlobalDefinitions.GraphicsHeight;
            }

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame == 0)
            {
                sourceRectangle = new Rectangle(0, 0, 512, 525);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 512, 525);
            }
            

            else
            {
                sourceRectangle = new Rectangle(512, 0, 512, 525);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 512, 525);
            }

            spriteBatch.Draw(Texture2DStorage.GetUpMovingLinkSpriteSheet(), destinationRectangle, sourceRectangle, Color.White);//use Texture2DStorage class to load texture2D
        }
    }
}

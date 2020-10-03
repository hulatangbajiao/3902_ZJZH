using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    public class LeftIdleLinkSprite : ISprite
    {


        public LeftIdleLinkSprite()
        {

        }

        public void Update()
        {


        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(0, 0, 216, 218);
            Rectangle destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 100, 100);
            //use texture2dStorage to get the texture2d of the sprite
            spriteBatch.Draw(Texture2DStorage.GetLeftIdleLinkSpriteSheet(), destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
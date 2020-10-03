using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
     public class DamagedLinkSprite : ISprite
    {

        public DamagedLinkSprite()
        {

        }

        public void Update()
        {


        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(0, 0, 216, 218);
            Rectangle destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 216, 218);
            //use texture2dStorage to get the texture2d of the sprite
            spriteBatch.Draw(Texture2DStorage.GetDownIdleLinkSpriteSheet(), destinationRectangle, sourceRectangle, Color.Red);
        }
    }
}
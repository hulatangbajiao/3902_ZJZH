using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    public class UpIdleLinkSprite : ISprite
    {

      
        public UpIdleLinkSprite()
        {

        }

        public void Update()
        {
            

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(0, 0, 96, 96);
            Rectangle destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 96, 96);
            //use texture2dStorage to get the texture2d of the sprite
            spriteBatch.Draw(Texture2DStorage.GetUpIdleLinkSpriteSheet(), destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
     public class DamagedLinkSprite : ISprite
    {
        private Vector2 location;

        public DamagedLinkSprite(Vector2 location)
        {
            this.location = location;

        }

        public void Update()
        {


        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(0, 0, 216, 218);
            Rectangle destinationRectangle = new Rectangle((int)this.location.X, (int)this.location.Y, 216, 218);
            //use texture2dStorage to get the texture2d of the sprite
            spriteBatch.Draw(Texture2DStorage.GetUpIdleLinkSpriteSheet(), destinationRectangle, sourceRectangle, Color.Red);
        }
    }
}
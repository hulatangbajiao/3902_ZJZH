using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    public class UpIdleLinkSprite : ISprite
    {
        private Rectangle destinationRectangle;


        public UpIdleLinkSprite()
        {

        }

        public void Update()
        {
            

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            Rectangle sourceRectangle = new Rectangle(0, 0, 96, 96);
            Rectangle destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 96, 96);
            //use texture2dStorage to get the texture2d of the sprite
            spriteBatch.Draw(Texture2DStorage.GetUpIdleLinkSpriteSheet(), destinationRectangle, sourceRectangle, Color.White);
        }
        public Rectangle GetRectangle()
        {
            return destinationRectangle;
        }
    }
}
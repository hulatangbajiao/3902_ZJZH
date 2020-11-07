using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
     public class DamagedLinkSprite : ISprite
    {
        private Rectangle destinationRectangle;
        public DamagedLinkSprite()
        {

        }

        public void Update()
        {


        }

        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            Rectangle sourceRectangle = new Rectangle(0, 0, 96, 96);
            destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 96, 96);
            //use texture2dStorage to get the texture2d of the sprite
            spriteBatch.Draw(Texture2DStorage.GetDamagedLinkSpriteSheet(), destinationRectangle, sourceRectangle, Color.Red);
        }
        public Rectangle GetRectangle()
        {
            return destinationRectangle;
        }
    }
}
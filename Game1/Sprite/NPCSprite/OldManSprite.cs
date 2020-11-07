using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1.Sprite_.NPC_Sprite
{
    class OldManSprite : ISprite
    {
        private Rectangle destinationRectangle;
        public OldManSprite()
        {
        }
        public void Update()
        {

        }
        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            Rectangle sourceRectangle = new Rectangle(0, 0, 96, 96);
            destinationRectangle = new Rectangle((int)Position.X, (int)Position.Y, 96, 96);
            //use texture2dStorage to get the texture2d of the sprite
            spriteBatch.Draw(Texture2DStorage.GetOldManSpriteSheet(), destinationRectangle, sourceRectangle, Color.White);
        }
        public Rectangle GetRectangle()
        {
            return destinationRectangle;

        }
    }
}

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class DownUseItemSprite : ISprite
    {

        private Rectangle destinationRectangle;
        public DownUseItemSprite()
        {


        }

        public void Update()
        {
            
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            Rectangle sourceRectangle;
            
            Texture2D texture = Texture2DStorage.GetDownUseItemLinkSpriteSheet();



            sourceRectangle = new Rectangle(0, 0, texture.Width, texture.Height);
            destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 96, 96);
            

            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);//use Texture2DStorage class to load texture2D
        }
        public Rectangle GetRectangle()
        {
            return destinationRectangle;
        }
    }
}

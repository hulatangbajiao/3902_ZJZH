using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class LeftUseItemSprite : ISprite
    {


        public LeftUseItemSprite()
        {


        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;
            Texture2D texture = Texture2DStorage.GetLeftUseItemLinkSpriteSheet();


            sourceRectangle = new Rectangle(0, 0, texture.Width, texture.Height);
            destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 96,96);


            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);//use Texture2DStorage class to load texture2D
        }
    }
}

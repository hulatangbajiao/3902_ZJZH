using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Game1.Sprite_;
using Game1.Interfaces;
using Game1;

namespace Game1.ItemsClasses
{
    class UseMapSprite: Iitem
    {

        public Texture2D Texture { get; set; }


        public UseMapSprite(Texture2D MapSpriteSheet)
        {
            Texture = MapSpriteSheet;

        }

        public void Update()
        {


        }

        public void Draw(SpriteBatch spriteBatch)
        {


            int width = Texture.Width;
            int height = Texture.Height;


            Nullable<Rectangle> sourceRectangle = new Rectangle(0, 0, width, height);
            Rectangle destinationRectangle = new Rectangle(450, 150, width / 2, height / 2);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }







    }
}

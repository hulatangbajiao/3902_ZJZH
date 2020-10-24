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
    class UseArrowSprite : IItemSprite
    {
        public Texture2D Texture { get; set; }
        private Rectangle destinationRectangle;

        public UseArrowSprite()
        {


        }

        public void Update()
        {


        }

        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {


            Texture = Texture2DStorage.GetArrowSpriteSheet();


            Nullable<Rectangle> sourceRectangle = new Rectangle(0, 0, Texture.Width, Texture.Height);
            Rectangle destinationRectangle = new Rectangle((int)Position.X, (int)Position.Y, Texture.Width / 2, Texture.Height / 2);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Rectangle GetRectangle()
        {
            return destinationRectangle;
        }


    }
}




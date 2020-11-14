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
    class UseMapSprite : ISprite
    {

        public Texture2D Texture { get; set; }

        private Rectangle destinationRectangle;

        public UseMapSprite()
        {


        }

        public void Update()
        {


        }

        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            Texture = Texture2DStorage.GetMapSpriteSheet();

            int width = Texture.Width;
            int height = Texture.Height;


            Nullable<Rectangle> sourceRectangle = new Rectangle(0, 0, width, height);
            destinationRectangle = new Rectangle((int)Position.X, (int)Position.Y, width , height );

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

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
    class UseBombSprite : ISprite
    {


        public Texture2D Texture { get; set; }
        private Rectangle destinationRectangle;


        public UseBombSprite()
        {


        }

        public void Update()
        {


        }

        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {





            Texture = Texture2DStorage.GetItemBombSpriteSheet();


            Nullable<Rectangle> sourceRectangle = new Rectangle(0, 0, Texture.Width, Texture.Height);
            destinationRectangle = new Rectangle((int)Position.X, (int)Position.Y, Texture.Width, Texture.Height );

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

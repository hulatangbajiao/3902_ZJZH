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

namespace Game1.Block
{
    class BlueStoneBlockSprite : ISprite
    {

        public Texture2D Texture { get; set; }
        private Rectangle destinationRectangle;
        public BlueStoneBlockSprite()
        {

        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 Position)

        {

            Texture = Texture2DStorage.GetBlueStoneBlockSpriteSheet();

            Nullable<Rectangle> sourceRectangle = new Rectangle(0, 0, Texture.Width, Texture.Height);
            destinationRectangle = new Rectangle((int)Position.X, (int)Position.Y, Texture.Width, Texture.Height);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

        }


        public Rectangle GetRectangle()
        {
            return destinationRectangle;
        }


    }
}

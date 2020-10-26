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
    class BlueBlockSprite : IBlock
    {
        public Texture2D Texture { get; set; }
        private Rectangle destinationRectangle;
        public BlueBlockSprite()
        {

        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {

            Texture = Texture2DStorage.GetBlueBlockSpriteSheet();

            Nullable<Rectangle> sourceRectangle = new Rectangle(0, 0, Texture.Width, Texture.Height);
            Rectangle destinationRectangle = new Rectangle(400, 100, Texture.Width / 2, Texture.Height / 2);


            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

        }

        public Rectangle GetRectangle()
        {
            return destinationRectangle;
        }



    }
}

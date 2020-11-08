using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Sprite
{
    class CoreSprite : ISprite
    {
        private int currentFrame = 0;
        private int totalFrame;
        private Rectangle destinationRectangle;
        private Texture2D Sprite;
        private int Width;
        private int Height;

        public CoreSprite(Texture2D Sprite, int Width, int Height, int totalFrame)
        {
            this.Sprite = Sprite;
            this.totalFrame = totalFrame * 10;
            this.Width = Width;
            this.Height = Height; 
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrame)
                currentFrame = 0;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            Rectangle sourceRectangle = new Rectangle( Width*(currentFrame/10), 0, Width, Height);
            destinationRectangle = new Rectangle((int)Position.X, (int)Position.Y, Width , Height);
            spriteBatch.Draw(Sprite, destinationRectangle, sourceRectangle, Color.White);
        }
        public Rectangle GetRectangle()
        {
            return destinationRectangle;
        }
    }
}



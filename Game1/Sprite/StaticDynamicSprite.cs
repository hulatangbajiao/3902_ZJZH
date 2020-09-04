using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Game1.Sprite
{
    class StaticDynamicSprite : StaticFixedSprite
    {
        private int X;
        private int Y;
        private int XSpeed;
        private int YSpeed;

        public StaticDynamicSprite(Game instance) : base(instance)
        {
            X = new Random().Next(0, GlobalDefinitions.GraphicsWidth);
            Y = new Random().Next(0, GlobalDefinitions.GraphicsHeight);
            XSpeed = 10;
            YSpeed = 10;
        }

        public override void Update()
        {
            X += XSpeed;
            Y += YSpeed;

            if (X + 25 >= GlobalDefinitions.GraphicsWidth)
            {
                XSpeed = -XSpeed;
                X = GlobalDefinitions.GraphicsWidth - 25;
            }
            else if (X <= 0)
            {
                XSpeed = -XSpeed;
                X = 0;
            }

            if (Y + 30 >= GlobalDefinitions.GraphicsHeight)
            {
                YSpeed = -YSpeed;
                Y = GlobalDefinitions.GraphicsHeight - 30;
            }
            else if (Y <= 0)
            {
                YSpeed = -YSpeed;
                Y = 0;
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, new Vector2(X, Y));
        }
    }
}

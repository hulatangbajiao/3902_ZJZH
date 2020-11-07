using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Game1.Sprite
{
    class AnimatedHorizontalMovingSprite : AnimatedFixedSprite
    {
        private int X;
        private int XSpeed;

        public AnimatedHorizontalMovingSprite(Game instance) : base(instance)
        {
            X = new Random().Next(0, GlobalDefinitions.GraphicsWidth);
            XSpeed = 10;
        }

        public override void Update()
        {
            X += XSpeed;
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

            base.Update();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, new Vector2(X, GlobalDefinitions.GraphicsHeight / 2));
        }
    }
}

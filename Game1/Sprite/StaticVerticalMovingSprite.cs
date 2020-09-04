using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Game1.Sprite
{
    class StaticVerticalMovingSprite : StaticFixedSprite
    {
        private int Y;
        private int YSpeed;

        public StaticVerticalMovingSprite(Game instance) : base(instance)
        {
            Y = new Random().Next(0, GlobalDefinitions.GraphicsHeight);
            YSpeed = 10;
        }

        public override void Update()
        {
            Y += YSpeed;
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
            sprite.Draw(spriteBatch, new Vector2(GlobalDefinitions.GraphicsWidth / 2, Y));
        }
    }
}

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1.Sprite
{
    class AnimatedFixedSprite : StaticFixedSprite
    {
        public AnimatedFixedSprite(Game instance) : base (instance)
        {
        }

        public override void Update()
        {
            sprite.Update();
        }
    }
}

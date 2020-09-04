using Microsoft.Xna.Framework;

namespace Game1.Sprite
{
    class AnimatedDynamicSprite : StaticDynamicSprite
    {
        public AnimatedDynamicSprite(Game instance) : base(instance)
        {
        }

        public override void Update()
        {
            sprite.Update();
            base.Update();
        }
    }
}

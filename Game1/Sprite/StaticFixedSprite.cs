using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1.Sprite
{
    class StaticFixedSprite : ISprite
    {
        private Texture2D texture;
        protected CoreSprite sprite;
        private readonly Game gameInstance;
        private readonly Vector2 position;

        public StaticFixedSprite(Game instance)
        {
            gameInstance = instance;
            position = new Vector2(50, 50);
        }

        public void LoadResources()
        {
            texture = gameInstance.Content.Load<Texture2D>("images/Link");
            sprite = new CoreSprite(texture, 1, 6);
            // Update it once. The actual update function is a no-op for static sprite
            sprite.Update();
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, position);
        }

        public virtual void Update()
        {
            // This is a no-op and this is intended
        }
    }
}

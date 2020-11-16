using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1.Sprite
{
    class TextSprite : ISprite
    {
        private SpriteFont font;
        private Game gameInstance;

        private const string CreditsText = "Credits\nProgram Made By: Yan Zhang\nSprites from: https://www.spriters-resource.com/nes/legendofzelda/sheet/8366/";

        public TextSprite(Game instance)
        {
            gameInstance = instance;
        }

        public void LoadResources()
        {
            font = gameInstance.Content.Load<SpriteFont>("Strings");
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(font, CreditsText, new Vector2(50, 400), Color.Black);
        }

        public void Update()
        {
            // This is a no-op for static text sprite
        }
    }
}

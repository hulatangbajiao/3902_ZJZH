using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1.Sprite
{
    class TextSprite : ISprite
    {
        private SpriteFont font;
        private Game gameInstance;

        private const string CreditsText = "Credits\nProgram Made By: Yan Zhang\nSprites from: http://rbwhitaker.wdfiles.com/local--files/monogame-texture-atlases-1/SmileyWalk.png";

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

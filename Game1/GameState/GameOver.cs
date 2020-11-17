using Game1.GameState;
using Game1.Interfaces;
using Game1.Sprite;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.GameState
{
    class GameOver : IGameState
    {
        MainStage game;
        public ISprite MessageSprite { get; set; }
        public ISprite ResetSprite { get; set; }
        public ISprite ContinueSprite { get; set; }
        public ISprite QuitSprite { get; set; }
        public IGeneralSprite BlackBackground { get; set; }
        private const int offset = 100;
        private Vector2 Position = new Vector2(0, 0);

        private String gameOver = "Game Over";
        private String continueGame = "Press c to Continue the game";
        private String restart = "Press r to restart the game";
        private String quit = "Press q to quit the game";

        public GameOver()
        {
            MessageSprite = new TextSprite(gameOver);
            ResetSprite = new TextSprite(restart);
            ContinueSprite = new TextSprite(continueGame);
            QuitSprite = new TextSprite(quit);
            BlackBackground = new GeneralSprite(1536, 1056, 1);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            BlackBackground.Draw(Texture2DStorage.GetBlackBackgroundSpriteSheet(), spriteBatch, Position);
            MessageSprite.Draw(spriteBatch, new Vector2(GlobalDefinitions.GraphicsWidth/2, GlobalDefinitions.GraphicsHeight / 3));
            ResetSprite.Draw(spriteBatch, new Vector2(GlobalDefinitions.GraphicsWidth / 2, GlobalDefinitions.GraphicsHeight / 3 + offset));
            ContinueSprite.Draw(spriteBatch, new Vector2( GlobalDefinitions.GraphicsWidth / 2, GlobalDefinitions.GraphicsHeight / 3 + 2 * offset));
            QuitSprite.Draw(spriteBatch, new Vector2( GlobalDefinitions.GraphicsWidth / 2, GlobalDefinitions.GraphicsHeight / 3 + 3 * offset));
        }
    }
}

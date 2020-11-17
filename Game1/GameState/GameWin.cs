using Game1.GameState;
using Game1.Interfaces;
using Game1.Sprite;
using Game1.Sprite_;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.GameState
{
    class GameWin : IGameState
    {
        MainStage game;
        public ISprite MessageSprite { get; set; }
        public ISprite ResetSprite { get; set; }
        public ISprite QuitSprite { get; set; }
        public IGeneralSprite BlackBackground { get; set; }

        private const int offset = 100;

        private String gameWin = "Win";
        private String restart = "Press r to restart the game";
        private String quit = "Press q to quit the game";
        private Vector2 Position = new Vector2(0, 0);

        public GameWin()
        {
            MessageSprite = new TextSprite(gameWin);
            ResetSprite = new TextSprite(restart);
            QuitSprite = new TextSprite(quit);
            BlackBackground = new GeneralSprite(1536, 1056 + 336, 1);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            BlackBackground.Draw(Texture2DStorage.GetBlackBackgroundSpriteSheet(), spriteBatch, Position);
            MessageSprite.Draw(spriteBatch, new Vector2(GlobalDefinitions.GraphicsWidth / 2, GlobalDefinitions.GraphicsHeight / 3));
            ResetSprite.Draw(spriteBatch, new Vector2(GlobalDefinitions.GraphicsWidth / 2, GlobalDefinitions.GraphicsHeight / 3 + offset));
            QuitSprite.Draw(spriteBatch, new Vector2(GlobalDefinitions.GraphicsWidth / 2, GlobalDefinitions.GraphicsHeight / 3 + 3 * offset));
        }
    }
}

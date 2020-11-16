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

namespace Game1.GameWin
{
    class GameWin : IGameState
    {
        MainStage game;
        public ISprite MessageSprite { get; set; }
        public ISprite ResetSprite { get; set; }
        public ISprite QuitSprite { get; set; }
        private const int offset = 16;

        private String gameWin = "Win";
        private String restart = "Press r to restart the game";
        private String quit = "Press q to quit the game";

        public GameWin()
        {
            MessageSprite = new TextSprite(gameWin);
            ResetSprite = new TextSprite(restart);
            QuitSprite = new TextSprite(quit);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            MessageSprite.Draw(spriteBatch, new Vector2(GlobalDefinitions.GraphicsHeight / 2, GlobalDefinitions.GraphicsWidth / 2));
            ResetSprite.Draw(spriteBatch, new Vector2(GlobalDefinitions.GraphicsHeight / 2 + offset, GlobalDefinitions.GraphicsWidth / 2));
            QuitSprite.Draw(spriteBatch, new Vector2(GlobalDefinitions.GraphicsHeight / 2 + 2 * offset, GlobalDefinitions.GraphicsWidth / 2));
        }
    }
}

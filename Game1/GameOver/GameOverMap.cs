using Game1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.GameOver
{
    class GameOverMap : IMenu
    {
        private Texture2DStorage gameOver;
        private Texture2DStorage reset;
        private Texture2DStorage continueGame;
        private Texture2DStorage quitGame;
        public GameOverMap()
        {
            gameOver = TextSprite("Game Over");
            reset = TextSprite("Reset the game");
            continueGame = TextSprite("Continue");
            quitGame = TextSprite("Quit");
        }
        public void selected()
        {

        }
        public void selectUp()
        {

        }
        public void selectDown()
        {

        }
        public void selectLeft()
        {

        }
        public void selectRight()
        {

        }
    }
}

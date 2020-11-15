using Game1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.GameWin
{
    class GameWinMap : IMenu
    {
        private ISprite Win;
        private Texture2DStorage reset;
        private Texture2DStorage quitGame;

        public GameWinMap()
        {
            Win = TextSprite("Win");
            reset = TextSprite("Reset the game");
            quitGame = TextSprite("Quit");
        }



        public void selectDown()
        {
            throw new NotImplementedException();
        }

        public void selected()
        {
            throw new NotImplementedException();
        }

        public void selectLeft()
        {
            throw new NotImplementedException();
        }

        public void selectRight()
        {
            throw new NotImplementedException();
        }

        public void selectUp()
        {
            throw new NotImplementedException();
        }
    }
}

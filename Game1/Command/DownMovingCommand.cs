using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class DownMovingCommand : ICommand
    {
        private IPlayer player;

        public DownMovingStateCommand(IPlayer Link)
        {
            player = Link;
        }

        public void Execute()
        {
            Link.KeepMoveDown();
            Link.MoveDown();
        }
    }

}
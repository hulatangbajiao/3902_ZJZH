using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class UpMovingCommand : ICommand
    {
        private IPlayer player;

    public UpMovingCommand(IPlayer Link)
    {
        player = Link;
    }

    public void Execute()
    {
        Link.KeepMoveUp();
        Link.MoveUp();
    }
}

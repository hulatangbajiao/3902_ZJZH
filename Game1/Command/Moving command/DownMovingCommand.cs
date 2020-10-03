using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class DownMovingCommand : ICommand
    {
<<<<<<< Updated upstream:Game1/Command/DownMovingCommand.cs
        private IPlayer player;
        public DownMovingStateCommand(IPlayer Link)
=======
        private ILink Link;

        public DownMovingCommand(ILink Link)
>>>>>>> Stashed changes:Game1/Command/Moving command/DownMovingCommand.cs
        {
            this.Link = Link;
        }

        public void Execute()
        {
            Link.MoveDown();
        }
<<<<<<< Updated upstream:Game1/Command/DownMovingCommand.cs
=======

        public void Stop()
        {
            Link.Stop();
        }
>>>>>>> Stashed changes:Game1/Command/Moving command/DownMovingCommand.cs
    }
}

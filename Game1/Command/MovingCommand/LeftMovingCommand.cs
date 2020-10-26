using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class LeftMovingCommand : ICommand
    {
        private ILink Link;

        public LeftMovingCommand(ILink Link)
        {
            this.Link = Link;
        }

        public void Execute()
        {
            Link.MoveLeft();
        }

        public void Stop()
        {
            Link.Stop();
        }
    }
}

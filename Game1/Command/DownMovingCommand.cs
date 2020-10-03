using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class DownMovingCommand : ICommand
    {
        private ILink Link;

        public DownMovingCommand(ILink Link)
        {
            this.Link = Link;
        }

        public void Execute()
        {
            Link.MoveDown();
        }

        public void Stop()
        {
            Link.Stop();
        }
    }
}

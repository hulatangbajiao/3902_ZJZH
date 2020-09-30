using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class UpMovingCommand : ICommand
    {
        private ILink Link;

        public UpMovingCommand(ILink Link)
        {
            this.Link = Link;
        }

        public void Execute()
        {
            Link.MoveUp();
        }

        public void Stop()
        {
            Link.Stop();
        }
    }
}
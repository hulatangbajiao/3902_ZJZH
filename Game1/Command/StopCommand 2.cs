using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class StopCommand : ICommand
    {
        public ILink Link;
        public StopCommand(ILink Link)
        {
            this.Link = Link;

        }
        public void Execute()
        {
            Link.Stop();
        }

    }
}

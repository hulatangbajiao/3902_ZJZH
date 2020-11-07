using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    public class UpMovingCommand : ICommand
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
    }
}

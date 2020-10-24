using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class RightMovingCommand : ICommand
    {
        private ILink Link;

        public RightMovingCommand(ILink Link)
        {
            this.Link = Link;
        }

        public void Execute()
        {
            Link.MoveRight();
            
        }
        public void Stop()
        {
            Link.Stop();
        }
    }
   
}


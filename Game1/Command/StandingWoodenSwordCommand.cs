using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class StandingWoodenSwordCommand : ICommand
    {
        private ILink Link;

        public StandingWoodenSwordCommand(ILink Link)
        {
            this.Link = Link;
        }

        public void Execute()
        {
            Link.UseItem();
        }

        public void Stop()
        {
            Link.Stop();
        }
    }
   
}

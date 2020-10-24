using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class UseArrowCommand : ICommand
    {

        private IPlayer player;

        public UseArrowCommand(IPlayer Link)
        {
            player = Link;
        }
        private ILink Link;

        public UseArrowCommand(ILink Link)
        {
            this.Link = Link;

        }

        public void Execute()
        {

            Link.UseItem(1);
        }

        public void Stop()
        {
            Link.Stop();

        }
    }
   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class UseBoomerCommand : ICommand
    {

        private IPlayer player;

        public UseBoomerCommand(IPlayer Link)
        {
            player = Link;
        }
        private ILink Link;

        public UseBoomerCommand(ILink Link)
        {
            this.Link = Link;

        }

        public void Execute()
        {

            Link.UseItem(3);
        }

        public void Stop()
        {
            Link.Stop();

        }
    }
   
}

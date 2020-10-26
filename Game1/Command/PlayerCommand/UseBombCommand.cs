using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class UseBombCommand : ICommand
    {

        private IPlayer player;

        public UseBombCommand(IPlayer Link)
        {
            player = Link;
        }
        private ILink Link;

        public UseBombCommand(ILink Link)
        {
            this.Link = Link;

        }

        public void Execute()
        {

            Link.UseItem(2);
        }
    }
   
}

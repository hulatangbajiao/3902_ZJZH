using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class UseBombCommand : ICommand
    {
        private ILink Link;

        public UseBombCommand(ILink Link)
        {
            this.Link = Link;

        }

        public void Execute()
        {
            AudioFactory.Instance.PlayBombSound();
            Link.UseItem(2);
        }
    }
   
}

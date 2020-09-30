using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class DamagedCommand : ICommand
    {
        private ILink Link;

        public DamagedCommand(ILink Link)
        {
            this.Link = Link;
        }

        public void Execute()
        {
            Link.TakeDamage();
        }
    }

}
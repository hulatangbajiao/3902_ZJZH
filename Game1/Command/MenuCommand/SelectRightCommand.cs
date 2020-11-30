using Game1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command.MenuCommand
{
    class SelectRightCommand : ICommand
    {
        private IMenu menu;
        public SelectRightCommand(IMenu menu)
        {
            this.menu = menu;
        }

        public void Execute()
        {
            menu.selectRight();
        }
    }
}

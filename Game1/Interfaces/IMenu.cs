using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Interfaces
{
    interface IMenu
    {
        void selected();
        void selectUp();
        void selectDown();
        void selectLeft();
        void selectRight();
    }
}

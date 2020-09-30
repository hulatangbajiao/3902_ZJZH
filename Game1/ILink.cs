using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public interface ILink
    {
        public ILinkState state;
        void TakeDamage();
        void MoveLeft();
        void KeepMoveLeft();
        void MoveUp();

        //if 'w'key is being pressed for a long time(more than once in one Update cycle), link will be animated and move up in y axis.
        void KeepMoveUp();
        void MoveDown();
        void KeepMoveDown();
        void MoveRight();
        void KeepMoveRight();

        //press 'z' and 'n' key to use sword to attack
        //when player press '1' then call UseWoodenSword() to attack,
        //                  '2' then call UseWhiteSword()
        //                  '3'           UseMagicalRod()
        void UseWoodenSword();
        void UseWhiteSword();
        void UseMagicalRod();

        void UseItem();
    }
}

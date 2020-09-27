using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class Link : ILink
    {
        public ILinkState state;

        public Link()
        {
            state = new UpIdleState(this);
        }

        public void MoveUp()
        {
            state.MoveUp();
        }

        public void TakeDamage()
        {
            state.TakeDamage();
        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), link will be animated and move up in y axis.
        public void KeepMoveUp()
        {
            state.KeepMoveUp();
        }

        public void MoveDown()
        {
            state.MoveDown();
        }
        
        public void KeepMoveDown()
        {
            state.KeepMoveDown();
        }
        public void MoveLeft()
        {
            state.MoveLeft();
        }
        public void KeepMoveLeft()
        {
            state.KeepMoveLeft();
        }
        public void MoveRight()
        {
            state.MoveRight();
        }
        public void KeepMoveRight()
        {
            state.KeepMoveRight();
        }

        //press 'z' and 'n' key to use sword to attack
        //when player press '1' then call UseWoodenSword() to attack,
        //                  '2' then call UseWhiteSword()
        //                  '3'           UseMagicalRod()
        public void UseWoodenSword()
        {
            state.UseWoodenSword();
        }
        public void UseWhiteSword()
        {
            state.UseWhiteSword();
        }
        public void UseMagicalRod()
        {
            state.UseMagicalRod();
        }

        public void UseItem()
        {
            state.UseItem();
        }


    }
}

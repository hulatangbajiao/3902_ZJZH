using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class DamagedLink : ILink
    {
        MainStage game;
        ILink decoratedLink;
        int timer = 1000;

        public ILinkState state;
        public DamagedLink(ILink decoratedLink, MainStage game)
        {
            this.decoratedLink = decoratedLink;
            this.game = game;
            state = new DamagedLinkState(this, game);
        }

        public void TakeDamage()
        {
            //no code required
        }

        public void Update()
        {

            timer--;
            if (timer == 0)
            {
                RemoveDecorator();
            }

            decoratedLink.Update();//method needs to be added
        }
        
        void RemoveDecorator()
        {
            game.Link = decoratedLink;//parameter needs to be added
        }

        public void MoveUp()
        {
            decoratedLink.MoveUp();
        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), link will be animated and move up in y axis.
        public void KeepMoveUp()
        {
            decoratedLink.KeepMoveUp();
        }

        public void MoveDown()
        {
            decoratedLink.MoveDown();
        }

        public void KeepMoveDown()
        {
            decoratedLink.KeepMoveDown();
        }
        public void MoveLeft()
        {
            decoratedLink.MoveLeft();
        }
        public void KeepMoveLeft()
        {
            decoratedLink.KeepMoveLeft();
        }
        public void MoveRight()
        {
            decoratedLink.MoveRight();
        }
        public void KeepMoveRight()
        {
            decoratedLink.KeepMoveRight();
        }

        //press 'z' and 'n' key to use sword to attack
        //when player press '1' then call UseWoodenSword() to attack,
        //                  '2' then call UseWhiteSword()
        //                  '3'           UseMagicalRod()
        public void UseWoodenSword()
        {
            decoratedLink.UseWoodenSword();
        }
        public void UseWhiteSword()
        {
            decoratedLink.UseWhiteSword();
        }
        public void UseMagicalRod()
        {
            decoratedLink.UseMagicalRod();
        }

        public void UseItem()
        {
            decoratedLink.UseItem();
        }
    }
}

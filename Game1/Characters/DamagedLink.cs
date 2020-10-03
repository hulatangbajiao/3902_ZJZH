using Microsoft.Xna.Framework;
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
<<<<<<< HEAD
        int timer = 20;
=======
        int timer = 200;
>>>>>>> 7138942d4ffb4ce348a80ca24494c5f810f3311e


        public ILinkState State { get; set; }

        public Vector2 Position { get; set; }
        public DamagedLink(Link decoratedLink, MainStage game)
        {
            this.decoratedLink = decoratedLink;
            this.game = game;
            State = new DamagedLinkState(decoratedLink, game);
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

            //method needs to be added
        }
        
        public void RemoveDecorator()
        {
            game.Link = decoratedLink;//parameter needs to be added
        }

        public void MoveUp()
        {
        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), link will be animated and move up in y axis.
       
        public void MoveDown()
        {
        }

        
        public void MoveLeft()
        {
        }
        
        public void MoveRight()
        {
        }
       

        public void Attack()
        {

        }

        public void Stop()
        {

        }

        public void UseItem()
        {
        }
    }
}

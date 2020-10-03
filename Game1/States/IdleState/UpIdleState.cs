using Game1.Sprite;
using Game1.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Game1
{
    internal class UpIdleState : ILinkState
    {
<<<<<<< Updated upstream
        private Link link;
=======
        public ILink Link { get; set; }
        private Link decoratedLink;
        MainStage game;
        public ISprite GetSprite { get; set; }
        public UpIdleState(ILink link, MainStage game)
        {
            this.Link = link;
            this.decoratedLink = (Link)link;
            this.game = game;
            GetSprite = new UpIdleLinkSprite();

        }
        //link has already faced up so no code for MoveUp()
>>>>>>> Stashed changes

        public UpIdleLinkSprite GetSprite { get; set; }
        public UpIdleState(Link link)
        {
<<<<<<< Updated upstream
            this.link = link;
            GetSprite = new UpIdleLinkSprite(link.position);

=======
<<<<<<< HEAD
            game.Link = new DamagedLink(decoratedLink, game);
=======
            Link = new DamagedLink(decoratedLink, game);
>>>>>>> 7138942d4ffb4ce348a80ca24494c5f810f3311e

            //remains to be discussed
>>>>>>> Stashed changes
        }
        //link has already faced up so no code for MoveUp()
        public void MoveUp()
        {
<<<<<<< Updated upstream
            link.state = new UpMovingState(link);
        }

        public void MoveDown()
        {
            link.state = new DownMovingState(link);

        }

        public void MoveLeft()
        {
            link.state = new LeftMovingState(link);
        }
 
        public void MoveRight()
        {
            link.state = new RightMovingState(link);
=======
            Link.State = new UpMovingState(Link, game);
        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), link will be animated and move up in y axis.

        public void MoveDown()
        {
            Link.State = new DownMovingState(Link, game);


        }


        public void MoveLeft()
        {
            Link.State = new LeftMovingState(Link, game);

        }


        public void MoveRight()
        {
            Link.State = new RightMovingState(Link, game);

>>>>>>> Stashed changes
        }

        public void Stop()
        {
            
        }
        public void Attack()
        {
<<<<<<< Updated upstream
            link.state = new UpAttackState(link);
=======
            Link.State = new UpWoodenSwordState(Link, game);

>>>>>>> Stashed changes
        }



        public void UseItem()
        {
<<<<<<< Updated upstream
            link.state = new UpUseItemState(link);
=======

>>>>>>> Stashed changes
        }


        public void Update()
        {
            GetSprite.Update();
        }
    }
}
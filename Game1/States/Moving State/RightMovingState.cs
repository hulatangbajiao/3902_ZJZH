<<<<<<< Updated upstream
﻿using Game1.Sprite;
using Game1.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.State
=======
﻿using Game1.Command;
using Game1.Sprite_;

namespace Game1
>>>>>>> Stashed changes
{
    public class RightMovingState : ILinkState
    {
        public ILink Link { get; set; }
        MainStage game;
        public ISprite GetSprite { get; set; }
        public RightMovingState(ILink link, MainStage game)
        {
            this.Link = link;
            this.game = game;
            GetSprite = new RightMovingLinkSprite();

        }
        //link has already faced up so no code for MoveUp()

        public void TakeDamage()
        {
<<<<<<< HEAD
            game.Link = new DamagedLink((Link)Link, game);
=======
            Link = new DamagedLink((Link)Link, game);
>>>>>>> 7138942d4ffb4ce348a80ca24494c5f810f3311e

            //remains to be discussed
        }
        public void MoveUp()
        {
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
        }

        public void Stop()
        {
            Link.State = new RightIdleState(Link, game); //when call stop(), the moving state transforms to idle state
        }

        public void Attack()
        {
            Link.State = new RightWoodenSwordState(Link, game);
        }
        public void UseItem()
        {

        }

<<<<<<< Updated upstream
        public RightMovingLinkSprite GetSprite { get; set; }
        public RightMovingState(Link link)
        {
            this.link = link;
            GetSprite = new RightMovingLinkSprite(link.position);

        }
        //link has already faced up so no code for MoveUp()
        public void MoveUp()
        {
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
            
        }

        public void Stop()
        {
            link.state = new RightIdleState(link);
        }
        public void Attack()
        {
            link.state = new RightAttackState(link);
        }



        public void UseItem()
        {
            link.state = new RightUseItemState(link);
        }


        public void Update()
        {
            link.PositionMoveRight();
=======
        public void Update()
        {
>>>>>>> Stashed changes
            GetSprite.Update();
        }
    }
}



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
    public class DownMovingState : ILinkState
    {
        public ILink Link { get; set; }
        MainStage game;
        public ISprite GetSprite { get; set; }
        public DownMovingState(ILink link, MainStage game)
        {
            this.Link = link;
            this.game = game;
            GetSprite = new DownMovingLinkSprite();

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
        }

        public void MoveLeft()
        {
            Link.State = new LeftMovingState(Link, game);
        }


        public void MoveRight()
        {
            Link.State = new RightMovingState(Link, game);
        }

        public void Stop()
        {
            Link.State = new DownIdleState(Link, game); //when call stop(), the moving state transforms to idle state
        }

        public void Attack()
        {
            Link.State = new DownWoodenSwordState(Link, game);
        }
        public void UseItem()
        {

        }

<<<<<<< Updated upstream
        public DownMovingLinkSprite GetSprite { get; set; }
        public DownMovingState(Link link)
        {
            this.link = link;
            GetSprite = new DownMovingLinkSprite(link.position);

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
            link.state = new RightMovingState(link);
        }

        public void Stop()
        {
            link.state = new DownIdleState(link);
        }
        public void Attack()
        {
            link.state = new DownAttackState(link);
        }



        public void UseItem()
        {
            link.state = new DownUseItemState(link);
        }


        public void Update()
        {
            link.PositionMoveDown();
=======
        public void Update()
        {
>>>>>>> Stashed changes
            GetSprite.Update();
        }
    }
}

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
    public class LeftMovingState : ILinkState
    {
        public ILink Link { get; set; }
        MainStage game;
        public ISprite GetSprite { get; set; }
        public LeftMovingState(ILink link, MainStage game)
        {
            this.Link = link;
            this.game = game;
            GetSprite = new LeftMovingLinkSprite();

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
        }


        public void MoveRight()
        {
            Link.State = new RightMovingState(Link, game);
        }

        public void Stop()
        {
            Link.State = new LeftIdleState(Link, game); //when call stop(), the moving state transforms to idle state
        }

        public void Attack()
        {
            Link.State = new LeftWoodenSwordState(Link, game);
        }
        public void UseItem()
        {

        }

<<<<<<< Updated upstream
        public LeftMovingLinkSprite GetSprite { get; set; }
        public LeftMovingState(Link link)
        {
            this.link = link;
            GetSprite = new LeftMovingLinkSprite(link.position);

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
            link.state = new LeftIdleState(link);
        }
        public void Attack()
        {
            link.state = new LeftAttackState(link);
        }



        public void UseItem()
        {
            link.state = new LeftUseItemState(link);
        }
        

        public void Update()
        {
            link.PositionMoveLeft();
=======
        public void Update()
        {
>>>>>>> Stashed changes
            GetSprite.Update();
        }
    }
}


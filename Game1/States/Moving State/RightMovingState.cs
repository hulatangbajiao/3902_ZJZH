using Game1.Sprite;
using Game1.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.State
{
    internal class RightMovingState : ILinkState
    {
        private Link link;

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
            GetSprite.Update();
        }
    }
}



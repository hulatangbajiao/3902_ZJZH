using Game1.Sprite;
using Game1.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Game1.State
{
    internal class DownMovingState : ILinkState
    {
        private Link link;

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
            GetSprite.Update();
        }
    }
}

using Game1.Sprite;
using Game1.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.State
{
    internal class LeftMovingState : ILinkState
    {
        private Link link;

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
            GetSprite.Update();
        }
    }
}


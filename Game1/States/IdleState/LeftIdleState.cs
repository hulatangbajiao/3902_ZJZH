using Game1.Sprite;
using Game1.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Game1.State
{
    internal class LeftIdleState : ILinkState
    {
        private Link link;

        public LeftIdleLinkSprite GetSprite { get; set; }
        public LeftIdleState(Link link)
        {
            this.link = link;
            GetSprite = new LeftIdleLinkSprite(link.position);

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
            GetSprite.Update();
        }
    }
}


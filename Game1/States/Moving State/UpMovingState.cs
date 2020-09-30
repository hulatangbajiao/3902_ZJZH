using Game1.Sprite;
using Game1.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    internal class UpMovingState : ILinkState
    {
        private Link link;

        public UpMovingLinkSprite GetSprite { get; set; }
        public UpMovingState(Link link)
        {
            this.link = link;
            GetSprite = new UpMovingLinkSprite(link.position);

        }
        //link has already faced up so no code for MoveUp()
        public void MoveUp()
        {
            
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
            link.state = new UpIdleState(link);
        }
        public void Attack()
        {
            link.state = new UpAttackState(link);
        }



        public void UseItem()
        {
            link.state = new UpUseItemState(link);
        }


        public void Update()
        {
            link.PositionMoveUp();
            GetSprite.Update();
        }
    }
}
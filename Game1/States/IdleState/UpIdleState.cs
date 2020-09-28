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
        private Link link;

        public UpIdleLinkSprite GetSprite { get; set; }
        public UpIdleState(Link link)
        {
            this.link = link;
            GetSprite = new UpIdleLinkSprite(link.position);

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
            link.state = new UpAttackState(link);
        }



        public void UseItem()
        {
            link.state = new UpUseItemState(link);
        }


        public void Update()
        {
            
        }
    }
}
using Game1.Sprite;
using Game1.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Game1.State
{
    internal class LeftUseItemState : ILinkState
    {
        private Link link;

        public LeftUseItemSprite GetSprite { get; set; }
        public LeftUseItemState(Link link)
        {
            this.link = link;
            GetSprite = new LeftUseItemSprite(link.position);

        }
        //link has already faced up so no code for MoveUp()
        public void MoveUp()
        {
            
        }

        public void MoveDown()
        {
            

        }

        public void MoveLeft()
        {
            
        }

        public void MoveRight()
        {
            
        }

        public void Stop()
        {
            link.state = new LeftIdleState(link);
        }
        public void Attack()
        {
            
        }



        public void UseItem()
        {
            
        }


        public void Update()
        {
            GetSprite.Update();
        }
    }
}

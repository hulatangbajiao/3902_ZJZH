using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class Link
    {
        public ILinkState state;
        public Vector2 position;
        public int equipmentItem1;
        public int equipmentItem2;
        public int equipmentItem3;
        public int weapon;
        

        public Link()
        {
            state = new UpIdleState(this);

            position = new Vector2(0, 0);
        }

        public void MoveUp()
        {
            state.MoveUp();
        }


        public void MoveDown()
        {
            state.MoveDown();
        }

        public void MoveLeft()
        {
            state.MoveLeft();
        }

        public void MoveRight()
        {
            state.MoveRight();
        }

        public void Stop()
        {
            state.Stop();
        }
        public void Attack()
        {
            state.Attack();
        }
        

        

        public void PositionMoveUp()
        {
            position.Y -= 2;
        }
        public void PositionMoveDown()
        {
            position.Y += 2;
        }
        public void PositionMoveLeft()
        {
            position.X -= 2;
        }
        public void PositionMoveRight()
        {
            position.X += 2;
        }
        public void UseItem() 
        {
            state.UseItem();
        }
        
        }


    }
}

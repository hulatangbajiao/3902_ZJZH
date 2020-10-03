﻿using Game1.Command;

namespace Game1
{
    public class UpMovingState : ILinkState
    {
        public ILink Link { get; set; }
        MainStage game;
        public ISprite GetSprite { get; set; }
        public UpMovingState(ILink link, MainStage game)
        {
            this.Link = link;
            this.game = game;
            GetSprite = new UpMovingLinkSprite();

        }
        //link has already faced up so no code for MoveUp()

        public void TakeDamage()
        {
            game.Link = new DamagedLink((Link)Link, game);

            //remains to be discussed
        }
        public void MoveUp()
        {

        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), link will be animated and move up in y axis.

        public void MoveDown()
        {
            Link.State = new DownMovingState(Link, game);
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
            Link.State = new UpIdleState(Link, game); //when call stop(), the moving state transforms to idle state
        }

        public void Attack()
        {
<<<<<<< HEAD:Game1/States/Moving State/UpMovingState.cs
            Link.State = new UpWoodenSwordState(Link, game);
=======
            //Link.State = new UpWoodenSwordState(Link, game);
>>>>>>> 7138942d4ffb4ce348a80ca24494c5f810f3311e:Game1/UpMovingState.cs
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
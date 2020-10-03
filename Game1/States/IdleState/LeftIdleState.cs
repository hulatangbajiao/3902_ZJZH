﻿using Microsoft.Xna.Framework;

namespace Game1
{
    public class LeftIdleState : ILinkState
    {
        public ILink Link { get; set; }
        private Link decoratedLink;
        MainStage game;
        public ISprite GetSprite { get; set; }
        public LeftIdleState(ILink link, MainStage game)
        {
            this.Link = link;
            this.decoratedLink = (Link)link;
            this.game = game;
            GetSprite = new LeftIdleLinkSprite();

        }
        //link has already faced up so no code for MoveUp()

        public void TakeDamage()
        {
            Link = new DamagedLink(decoratedLink, game);

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
            Link.State = new LeftMovingState(Link, game);

        }


        public void MoveRight()
        {
            Link.State = new RightMovingState(Link, game);

        }

        public void Stop()
        {
            // no-op
        }

        public void Attack()
        {
            Link.State = new LeftWoodenSwordState(Link, game);

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
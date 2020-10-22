using Game1.Sprite_.Enemy_Sprite.OctMoving;
using Microsoft.Xna.Framework;

namespace Game1
{
    internal class BlueOctRightMovingState : IOctState
    {
        private BlueOct BlueOct;
        private MainStage game;
        public ISprite GetSprite { get; set; }

        public BlueOctRightMovingState(BlueOct blueoct, MainStage game)
        {
            this.BlueOct = blueoct;
            this.game = game;
            GetSprite = new RightMovingBlueOctSprite();
        }

        public void MoveUp()
        {
            BlueOct.State = new BlueOctUpMovingState(BlueOct, game);

        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), Oct will be animated and move up in y axis.

        public void MoveDown()
        {
            BlueOct.State = new BlueOctDownMovingState(BlueOct, game);

        }


        public void MoveLeft()
        {
            BlueOct.State = new BlueOctLeftMovingState(BlueOct, game);

        }


        public void MoveRight()
        {
        }

        public void Update()
        {
            GetSprite.Update();
        }
        public void BreatheFire()
        {
            this.game.ProjectileFactory.AddArrow(GlobalDefinitions.BlueOctPosition, new Vector2(1, 0));
        }


    }
}
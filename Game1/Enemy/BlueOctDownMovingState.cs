using Game1.Sprite_.Enemy_Sprite.OctMoving;
using Microsoft.Xna.Framework;

namespace Game1
{
    internal class BlueOctDownMovingState : IOctState
    {
        private BlueOct BlueOct;
        private MainStage game;
        public ISprite GetSprite { get; set; }

        public BlueOctDownMovingState(BlueOct blueoct, MainStage game)
        {
            this.BlueOct = blueoct;
            this.game = game;
            GetSprite = new DownMovingBlueOctSprite();
        }

        public void MoveUp()
        {
            BlueOct.State = new BlueOctUpMovingState(BlueOct, game);

        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), Oct will be animated and move up in y axis.

        public void MoveDown()
        {

        }


        public void MoveLeft()
        {
            BlueOct.State = new BlueOctLeftMovingState(BlueOct, game);
        }


        public void MoveRight()
        {
            BlueOct.State = new BlueOctRightMovingState(BlueOct, game);
        }

        public void Update()
        {
            GetSprite.Update();
        }
        public void BreatheFire()
        {
            this.game.ProjectileFactory.AddArrow(GlobalDefinitions.BlueOctPosition, new Vector2(0, 1));
        }


    }
}
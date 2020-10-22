using Game1.Sprite_.Enemy_Sprite.OctMoving;
using Microsoft.Xna.Framework;

namespace Game1
{
    internal class BlueOctLeftMovingState : IEnemyState
    {
        private BlueOct BlueOct;
        private MainStage game;
        public ISprite GetSprite { get; set; }

        public BlueOctLeftMovingState(BlueOct blueoct, MainStage game)
        {
            this.BlueOct = blueoct;
            this.game = game;
            GetSprite = new LeftMovingBlueOctSprite();
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
            this.game.ProjectileFactory.AddArrow(GlobalDefinitions.BlueOctPosition, new Vector2(-1, 0));
        }


    }
}
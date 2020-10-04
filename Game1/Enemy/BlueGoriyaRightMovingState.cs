using Game1.Sprite_.Enemy_Sprite.OctMoving;
using Game1.Sprite_.Enemy_Sprite.BlueGoriyaMoving;
using Microsoft.Xna.Framework;

namespace Game1
{
    internal class BlueGoriyaRightMovingState : IOctState
    {
        private BlueGoriya BlueGoriya;
        private MainStage game;
        public ISprite GetSprite { get; set; }

        public BlueGoriyaRightMovingState(BlueGoriya Bluegoriya, MainStage game)

        {
            this.BlueGoriya = Bluegoriya;
            this.game = game;
            GetSprite = new RightMovingBlueGoriyaSprite();

        }

        public void MoveUp()
        {
            BlueGoriya.State = new BlueGoriyaUpMovingState(BlueGoriya, game);

        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), Oct will be animated and move up in y axis.

        public void MoveDown()
        {
            BlueGoriya.State = new BlueGoriyaDownMovingState(BlueGoriya, game);

        }


        public void MoveLeft()
        {
            BlueGoriya.State = new BlueGoriyaLeftMovingState(BlueGoriya, game);
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
            this.game.ProjectileFactory.AddArrow(GlobalDefinitions.BlueGoriyaPosition, new Vector2(1, 0));
        }


    }
}
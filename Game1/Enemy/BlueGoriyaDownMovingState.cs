using Game1.Sprite_.Enemy_Sprite.OctMoving;
using Game1.Sprite_.Enemy_Sprite.BlueGoriyaMoving;
using Microsoft.Xna.Framework;

namespace Game1
{
    internal class BlueGoriyaDownMovingState : IOctState
    {
        private BlueGoriya BlueGoriya;
        private MainStage game;
        public ISprite GetSprite { get; set; }

        public BlueGoriyaDownMovingState(BlueGoriya Bluegoriya, MainStage game)

        {
            this.BlueGoriya = Bluegoriya;
            this.game = game;
            GetSprite = new DownMovingBlueGoriyaSprite();

        }

        public void MoveUp()
        {
            BlueGoriya.State = new BlueGoriyaUpMovingState(BlueGoriya, game);

        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), Oct will be animated and move up in y axis.

        public void MoveDown()
        {

        }


        public void MoveLeft()
        {
            BlueGoriya.State = new BlueGoriyaLeftMovingState(BlueGoriya, game);

        }


        public void MoveRight()
        {
            BlueGoriya.State = new BlueGoriyaRightMovingState(BlueGoriya, game);

        }

        public void Update()
        {
            GetSprite.Update();
        }
        public void BreatheFire()
        {
            this.game.ProjectileFactory.AddArrow(GlobalDefinitions.BlueGoriyaPosition, new Vector2(0, 1));
        }


    }
}
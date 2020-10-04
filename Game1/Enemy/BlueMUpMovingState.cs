using Game1.Sprite_.Enemy_Sprite.OctMoving;
using Microsoft.Xna.Framework;

namespace Game1
{
    internal class BlueMUpMovingState : IOctState
    {
        private BlueM BlueM;
        private MainStage game;
        public ISprite GetSprite { get; set; }

        public BlueMUpMovingState(BlueM bluem, MainStage game)
        {
            this.BlueM = bluem;
            this.game = game;
            GetSprite = new UpMovingBlueMSprite();
        }

        public void MoveUp()
        {
        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), Oct will be animated and move up in y axis.

        public void MoveDown()
        {
            BlueM.State = new BlueMDownMovingState(BlueM, game);

        }


        public void MoveLeft()
        {
            BlueM.State = new BlueMLeftMovingState(BlueM, game);
        }


        public void MoveRight()
        {
            BlueM.State = new BlueMRightMovingState(BlueM, game);
        }

        public void Update()
        {
            GetSprite.Update();
        }
        public void BreatheFire()
        {
            this.game.ProjectileFactory.AddArrow(GlobalDefinitions.BlueMPosition, new Vector2(0, -1));
        }


    }
}
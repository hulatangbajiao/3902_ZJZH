using Game1.Sprite_.Enemy_Sprite.AquamentusMoving;
using Game1.Sprite_.Enemy_Sprite.OctMoving;
using Microsoft.Xna.Framework;

namespace Game1
{
    internal class AquamentusLeftMovingState : IEnemyState
    {
        private Aquamentus Aquamentus;
        private MainStage game;
        public ISprite GetSprite { get; set; }

        public AquamentusLeftMovingState(Aquamentus Aquamentus, MainStage game)

        {
            this.Aquamentus = Aquamentus;
            this.game = game;
            GetSprite = new LeftMovingAquamentusSprite();

        }

        public void MoveUp()
        {

        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), Oct will be animated and move up in y axis.

        public void MoveDown()
        {

        }


        public void MoveLeft()
        {
        }


        public void MoveRight()
        {
            Aquamentus.State = new AquamentusRightMovingState(Aquamentus, game);

        }

        public void Update()
        {
            GetSprite.Update();
        }
        public void BreatheFire()
        {
            this.game.ProjectileFactory.AddFireBall(GlobalDefinitions.AquamentusPosition, new Vector2(-1, 0));
            this.game.ProjectileFactory.AddFireBall(GlobalDefinitions.AquamentusPosition, new Vector2(-1, 1));
            this.game.ProjectileFactory.AddFireBall(GlobalDefinitions.AquamentusPosition, new Vector2(-1, -1));


        }


    }
}
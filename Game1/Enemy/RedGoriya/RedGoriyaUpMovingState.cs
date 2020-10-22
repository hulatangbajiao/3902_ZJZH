using Game1.Sprite_.Enemy_Sprite.OctMoving;
using Game1.Sprite_.Enemy_Sprite.RedGoriyaMoving;
using Microsoft.Xna.Framework;

namespace Game1
{
    internal class RedGoriyaUpMovingState : IEnemyState
    {
        private RedGoriya RedGoriya;
        private MainStage game;
        public ISprite GetSprite { get; set; }

        public RedGoriyaUpMovingState(RedGoriya redgoriya, MainStage game)

        {
            this.RedGoriya = redgoriya;
            this.game = game;
            GetSprite = new UpMovingRedGoriyaSprite();

        }

        public void MoveUp()
        {
        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), Oct will be animated and move up in y axis.

        public void MoveDown()
        {
            RedGoriya.State = new RedGoriyaDownMovingState(RedGoriya, game);

        }


        public void MoveLeft()
        {
            RedGoriya.State = new RedGoriyaLeftMovingState(RedGoriya, game);
        }


        public void MoveRight()
        {
            RedGoriya.State = new RedGoriyaRightMovingState(RedGoriya, game);
        }

        public void Update()
        {
            GetSprite.Update();
        }
        public void BreatheFire()
        {
            this.game.ProjectileFactory.AddArrow(GlobalDefinitions.RedGoriyaPosition, new Vector2(0, -1));
        }


    }
}
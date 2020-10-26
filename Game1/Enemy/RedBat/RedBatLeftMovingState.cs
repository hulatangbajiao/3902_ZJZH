using Game1.Sprite_.Enemy_Sprite.OctMoving;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class RedBatLeftMovingState : IEnemyState
    {
        private RedBat RedBat;
        private MainStage game;
        public ISprite GetSprite { get; set; }

        public RedBatLeftMovingState(RedBat redBat, MainStage game)

        {
            this.RedBat = redBat;
            this.game = game;
            GetSprite = new LeftMovingRedBatSprite();

        }

        public void MoveUp()
        {
            RedBat.State = new RedBatUpMovingState(RedBat, game);

        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), Oct will be animated and move up in y axis.

        public void MoveDown()
        {
            RedBat.State = new RedBatDownMovingState(RedBat, game);

        }


        public void MoveLeft()
        {
        }


        public void MoveRight()
        {
            RedBat.State = new RedBatRightMovingState(RedBat, game);

        }

        public void Update()
        {
            GetSprite.Update();
            RedBat.Position = RedBat.Position + new Vector2(-1, 0) * RedBat.MovingSpeed;
        }
        public void BreatheFire()
        {
            
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            this.GetSprite.Draw(spriteBatch, Position);
        }
        public Rectangle GetRectangle()
        {
            return this.GetSprite.GetRectangle();
        }

    }
}
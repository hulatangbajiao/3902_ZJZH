using Game1.Sprite_.Enemy_Sprite.OctMoving;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class RedBatUpMovingState : IEnemyState
    {
        private RedBat RedBat;
        private MainStage game;
        public ISprite GetSprite { get; set; }

        public RedBatUpMovingState(RedBat redBat, MainStage game)

        {
            this.RedBat = redBat;
            this.game = game;
            GetSprite = new UpMovingRedBatSprite();

        }

        public void MoveUp()
        {
        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), Oct will be animated and move up in y axis.

        public void MoveDown()
        {
            RedBat.State = new RedBatDownMovingState(RedBat, game);

        }


        public void MoveLeft()
        {
            RedBat.State = new RedBatLeftMovingState(RedBat, game);
        }


        public void MoveRight()
        {
            RedBat.State = new RedBatRightMovingState(RedBat, game);
        }

        public void Update()
        {
            GetSprite.Update();
            RedBat.Position = RedBat.Position + new Vector2(0, -1) * RedBat.MovingSpeed;
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
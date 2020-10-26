using Game1.Sprite_.Enemy_Sprite.OctMoving;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class OctRightMovingState : IEnemyState
    {
        private Oct Oct;
        private MainStage game;
        public ISprite GetSprite { get; set; }

        public OctRightMovingState(Oct oct, MainStage game)
        {
            this.Oct = oct;
            this.game = game;
            GetSprite = new RightMovingOctSprite();

        }

        public void MoveUp()
        {
            Oct.State = new OctUpMovingState(Oct, game);
        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), Oct will be animated and move up in y axis.

        public void MoveDown()
        {
            Oct.State = new OctDownMovingState(Oct, game);

        }


        public void MoveLeft()
        {
            Oct.State = new OctLeftMovingState(Oct, game);
        }


        public void MoveRight()
        {

        }

        public void Update()
        {
            GetSprite.Update();
            Oct.Position = Oct.Position + new Vector2(1, 0) * Oct.MovingSpeed;
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
using Game1.Sprite_.Enemy_Sprite.OctMoving;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class BlueOctDownMovingState : IEnemyState
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
            BlueOct.Position = BlueOct.Position + new Vector2(0, 1) * BlueOct.MovingSpeed;
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
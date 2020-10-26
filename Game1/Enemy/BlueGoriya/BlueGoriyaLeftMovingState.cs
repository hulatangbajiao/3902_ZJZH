using Game1.Sprite_.Enemy_Sprite.OctMoving;
using Game1.Sprite_.Enemy_Sprite.BlueGoriyaMoving;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class BlueGoriyaLeftMovingState : IEnemyState
    {
        private BlueGoriya BlueGoriya;
        private MainStage game;
        private ISprite GetSprite { get; set; }

        public BlueGoriyaLeftMovingState(BlueGoriya Bluegoriya, MainStage game)

        {
            this.BlueGoriya = Bluegoriya;
            this.game = game;
            GetSprite = new LeftMovingBlueGoriyaSprite();

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
        }


        public void MoveRight()
        {
            BlueGoriya.State = new BlueGoriyaRightMovingState(BlueGoriya, game);

        }

        public void Update()
        {
            GetSprite.Update();
            BlueGoriya.Position = BlueGoriya.Position - new Vector2(1, 0) * BlueGoriya.MovingSpeed;
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
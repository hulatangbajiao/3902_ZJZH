using Game1.Sprite_.Enemy_Sprite.OctMoving;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class BlueMLeftMovingState : IEnemyState
    {
        private BlueM BlueM;
        private MainStage game;
        public ISprite GetSprite { get; set; }

        public BlueMLeftMovingState(BlueM bluem, MainStage game)
        {
            this.BlueM = bluem;
            this.game = game;
            GetSprite = new LeftMovingBlueMSprite();
        }

        public void MoveUp()
        {
            BlueM.State = new BlueMUpMovingState(BlueM, game);

        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), Oct will be animated and move up in y axis.

        public void MoveDown()
        {
            BlueM.State = new BlueMDownMovingState(BlueM, game);

        }


        public void MoveLeft()
        {
        }


        public void MoveRight()
        {
            BlueM.State = new BlueMRightMovingState(BlueM, game);

        }

        public void Update()
        {
            GetSprite.Update();
            BlueM.Position = BlueM.Position + new Vector2(-1, 0) * BlueM.MovingSpeed;
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
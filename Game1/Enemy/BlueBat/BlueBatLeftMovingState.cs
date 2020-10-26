using Game1.Sprite_.Enemy_Sprite.OctMoving;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class BlueBatLeftMovingState : IEnemyState
    {
        private BlueBat BlueBat;
        private MainStage game;
        private ISprite GetSprite { get; set; }

        public BlueBatLeftMovingState(BlueBat BlueBat, MainStage game)

        {
            this.BlueBat = BlueBat;
            this.game = game;
            GetSprite = new LeftMovingBlueBatSprite();

        }

        public void MoveUp()
        {
            BlueBat.State = new BlueBatUpMovingState(BlueBat, game);

        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), Oct will be animated and move up in y axis.

        public void MoveDown()
        {
            BlueBat.State = new BlueBatDownMovingState(BlueBat, game);
        }


        public void MoveLeft()
        {
            

        }


        public void MoveRight()
        {
            BlueBat.State = new BlueBatRightMovingState(BlueBat, game);

        }

        public void Update()
        {
            GetSprite.Update();
            BlueBat.Position = BlueBat.Position + new Vector2(-1, 0) * BlueBat.MovingSpeed;
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
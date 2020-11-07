using Game1.Sprite_.Enemy_Sprite.OctMoving;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class BlueBatUpMovingState : IEnemyState
    {
        private BlueBat BlueBat;
        public IEnemyFactory factory { get; set; }
        private ISprite GetSprite { get; set; }

        public BlueBatUpMovingState(BlueBat BlueBat, IEnemyFactory factory)

        {
            this.BlueBat = BlueBat;
            this.factory = factory;
            GetSprite = new UpMovingBlueBatSprite();

        }

        public void MoveUp()
        {
            

        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), Oct will be animated and move up in y axis.

        public void MoveDown()
        {
            BlueBat.State = new BlueBatDownMovingState(BlueBat, factory);
        }


        public void MoveLeft()
        {
            BlueBat.State = new BlueBatLeftMovingState(BlueBat, factory);

        }


        public void MoveRight()
        {
            BlueBat.State = new BlueBatRightMovingState(BlueBat, factory);

        }

        public void Update()
        {
            GetSprite.Update();
            BlueBat.Position = BlueBat.Position + new Vector2(0, -1) * BlueBat.MovingSpeed;
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
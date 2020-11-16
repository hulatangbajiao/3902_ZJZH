using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class BlueBatRightMovingState : IEnemyState
    {
        private BlueBat BlueBat;
        public IEnemyFactory factory { get; set; }
        private IGeneralSprite GetSprite { get; set; }

        public BlueBatRightMovingState(BlueBat BlueBat, IEnemyFactory factory)

        {
            this.BlueBat = BlueBat;
            this.factory = factory;
            GetSprite = new GeneralSprite(96,96,2);

        }

        public void MoveUp()
        {
            BlueBat.State = new BlueBatUpMovingState(BlueBat, factory);

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
            

        }

        public void Update()
        {
            GetSprite.Update();
            BlueBat.Position = BlueBat.Position + new Vector2(1, 0) * BlueBat.MovingSpeed;
        }
        public void BreatheFire()
        {

        }
        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            this.GetSprite.Draw(Texture2DStorage.GetUpMovingBlueBatSpriteSheet(), spriteBatch, Position);
        }
        public Rectangle GetRectangle()
        {
            return this.GetSprite.GetRectangle();
        }
    }
}
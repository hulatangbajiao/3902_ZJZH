using Game1.Sprite_.Enemy_Sprite.AquamentusMoving;
using Game1.Sprite_.Enemy_Sprite.OctMoving;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class AquamentusRightMovingState : IEnemyState
    {
        private Aquamentus Aquamentus;
        private MainStage game;
        private ISprite GetSprite { get; set; }

        public AquamentusRightMovingState(Aquamentus Aquamentus, MainStage game)

        {
            this.Aquamentus = Aquamentus;
            this.game = game;
            GetSprite = new RightMovingAquamentusSprite();

        }

        public void MoveUp()
        {

        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), Oct will be animated and move up in y axis.

        public void MoveDown()
        {

        }


        public void MoveLeft()
        {
            Aquamentus.State = new AquamentusLeftMovingState(Aquamentus, game);
        }


        public void MoveRight()
        {
            

        }

        public void Update()
        {
            GetSprite.Update();
            Aquamentus.Position = Aquamentus.Position + new Vector2(1, 0) * Aquamentus.MovingSpeed;
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
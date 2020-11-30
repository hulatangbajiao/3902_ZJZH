using Game1.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class FireBall : IProjectile
    {
        public IGeneralSprite GetSprite { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 Direction { get; set; }
        public int Velocity { get; set; }

        public bool exist { get; set; }


        public FireBall(Vector2 Position, Vector2 direction)
        {


            this.Position = Position + new Vector2(30, 30);
            Direction = direction;
            Velocity = 10;
            exist = true;

            GetSprite = new GeneralSprite(50,50,1);


        }
        public void Hit()
        {
            exist = false;
        }
        public void Update()
        {


            Position = Position + Direction * Velocity;
            GetSprite.Update();

            if (Position.X > 2000 || Position.X < -300 || Position.Y < -300 || Position.Y > 2000)
            {
                exist = false;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (exist)
            {
                GetSprite.Draw(Texture2DStorage.GetFireBallSpriteSheet(),spriteBatch, Position);
            }
        }
        public Rectangle GetRectangle()
        {
            return this.GetSprite.GetRectangle();
        }

    }
}


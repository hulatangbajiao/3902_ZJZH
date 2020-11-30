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
    public class EnemyFireBall : IEnemy
    {
        private IGeneralSprite GetSprite { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 Direction { get; set; }
        public int MovingSpeed { get; set; }
        public IEnemyState State { get; set; }
        public bool exist { get; set; }
        public int timer { get; set; }
        public bool damaging { get; set; }
        private Vector2 damageDirection = new Vector2(0, 0);


        public EnemyFireBall(Vector2 Position, Vector2 direction, IEnemyFactory factory)
        {

            MovingSpeed = 20;
            this.Position = Position + new Vector2(30, 30);
            Direction = direction;
            damaging = false;
            timer = 0;
            exist = true;

            GetSprite = new GeneralSprite(50,50,1);


        }
        public void Die()
        {

        }
        public void TakeDamage(Vector2 DamageDirection)
        {
            
        }
        public void Hit()
        {
            exist = false;
        }
        public void MoveUp()
        {
            
        }


        public void MoveDown()
        {
            
        }

        public void MoveLeft()
        {
            
        }

        public void MoveRight()
        {
            
        }


        public void Attack()
        {
            
        }

        public void Update()
        {

            if (exist)
            {
                Position = Position + Direction * MovingSpeed;
                GetSprite.Update();

                if (Position.X > 2000 || Position.X < -300 || Position.Y < -300 || Position.Y > 2000)
                {
                    exist = false;
                }
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


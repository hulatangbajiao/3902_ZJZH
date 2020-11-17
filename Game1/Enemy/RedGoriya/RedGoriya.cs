
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class RedGoriya : IEnemy
    {

        public IEnemyState State { get; set; }
        
        int count;
        Random rand;
        public bool exist { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 Direction { get; set; }
        public int MovingSpeed { get; set; }
        private int health = 2;

        public RedGoriya(Vector2 Position, Vector2 Direction, IEnemyFactory factory)
        {
            State = new RedGoriyaUpMovingState(this, factory);
            this.Position = Position;
            rand = new Random();
            MovingSpeed = 1;
            exist = true;
        }

        public void Die()
        {

        }
        public void TakeDamage(Vector2 DamageDirection)
        {
            health--;
            if (health <= 0)
            {
                this.Die();
            }
        }
        public void Hit()
        {

        }
        public void MoveUp()
        {
            State.MoveUp();
        }


        public void MoveDown()
        {
            State.MoveDown();
        }

        public void MoveLeft()
        {
            State.MoveLeft();
        }

        public void MoveRight()
        {
            State.MoveRight();
        }


        public void Attack()
        {
            State.BreatheFire();
        }



        public void Update()
        {
            if (exist)
            {
                State.Update();

                count++;
                if (count > GlobalDefinitions.phaseChangingSpeed)
                {
                    switch (rand.Next(0, 5))
                    {
                        case 0:
                            State.MoveUp();
                            break;
                        case 1:
                            State.MoveDown();
                            break;
                        case 2:
                            State.MoveLeft();
                            break;
                        case 3:
                            State.MoveRight();
                            break;
                        case 4:
                            State.BreatheFire();
                            break;



                        default:
                            // Do nothing, this is not supposed to happen
                            break;
                    }
                    count = 0;
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (exist)
            {
                this.State.Draw(spriteBatch, Position);
            }
        }
        public Rectangle GetRectangle()
        {
            return this.State.GetRectangle();
        }


    }
}

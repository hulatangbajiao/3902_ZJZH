
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team4_LegendOfZelda.Random_Number_Generator;

namespace Game1
{
    public class BlueBat : IEnemy
    {
        public IEnemyState State { get; set; }
        private MainStage game;
        int count;
        Random rand;
        public bool exist { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 Direction { get; set; }
        public int MovingSpeed { get; set; }
        private int health = 2;
        public int timer { get; set; }
        public bool damaging { get; set; }
        private Vector2 damageDirection = new Vector2(0, 0);

        public BlueBat(Vector2 Position, Vector2 Direction, IEnemyFactory factory)
        {
            State = new BlueBatUpMovingState(this, factory);
            this.Position = Position;
            rand = new Random();
            exist = true;
            MovingSpeed = 1;
            damaging = false;
            timer = 0;
        }
        public void Die()
        {
            this.State.die = true;
            State.GetSprite = new GeneralSprite(96, 96, 8);
        }
        public void TakeDamage(Vector2 DamageDirection)
        {
            health--;
            if (health <= 0)
            {
                this.Die();
            }
            damageDirection = DamageDirection;
            damaging = true;
            timer = 20;
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
                    switch (RandomIntGenerator.Instance.Next(0, 5))
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
                            State.MoveUp();
                            break;



                        default:
                            // Do nothing, this is not supposed to happen
                            break;
                    }
                    count = 0;
                }
            }
        }

        public void Draw(SpriteBatch spritebatch)
        {
            if (exist)
            {
                State.Draw(spritebatch, Position);
                if (timer > 0)
                {
                    timer--;
                    State.GetSprite.ChangeColor();
                }
                else
                {
                    State.GetSprite.color = Color.White;
                }
                if (timer < 16)
                {
                    damaging = false;
                }
                if (!damaging)
                {
                    State.Update();
                }
                else
                {
                    Position -= 30 * damageDirection;
                }
            }
        }

        public Rectangle GetRectangle()
        {
            return this.State.GetRectangle();
        }
    }
}

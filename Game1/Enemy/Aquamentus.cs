using Game1.Enemy_NPC;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class Aquamentus : IEnemy
    {

        public IOctState State { get; set; }
        private MainStage game;
        int count;
        Random rand;

        public Aquamentus(MainStage game)
        {
            State = new AquamentusLeftMovingState(this, game);
            GlobalDefinitions.AquamentusPosition = new Vector2(GlobalDefinitions.GraphicsWidth / 2, GlobalDefinitions.GraphicsHeight / 2);
            rand = new Random();
            this.game = game;
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
            State.Update();

            count++;
            if (count > GlobalDefinitions.phaseChangingSpeed)
            {
                switch (rand.Next(0, 5))
                {
                    case 0:
                        State.MoveRight();
                        break;
                    case 1:
                        State.BreatheFire();
                        break;
                    case 2:
                        State.MoveLeft();
                        break;
                    case 3:
                        State.BreatheFire();
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
}

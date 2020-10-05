using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class Oct : IEnemy
    {

        public ILinkState State { get; set; }

        private MainStage _game;

        public Oct(MainStage game)
        {
            _game = game;
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

       
        public void BreatheFire()
        {
            State.BreatheFire();
        }

       
        public void Update()
        {
            State.Update();
        }

       
    }
}

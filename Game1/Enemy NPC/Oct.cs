using Game1.Enemy_NPC;
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
        public Vector2 OctPosition { get; set; }
        public Oct(MainStage game)
        {
            State = new OctUpmovingState(this, game);
            OctPosition = new Vector2(GlobalDefinitions.GraphicsWidth / 2, GlobalDefinitions.GraphicsHeight / 2);
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

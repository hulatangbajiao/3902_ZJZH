using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class Link : ILink
    {

        public ILinkState State { get; set; }
        public int Item { get; set; }
        public Link(MainStage game)
        {
            Item = 0;
            State = new UpIdleState(this, game);
            GlobalDefinitions.Position = new Vector2(GlobalDefinitions.GraphicsWidth / 2, GlobalDefinitions.GraphicsHeight / 2);
        }

        public void TakeDamage()
        {
            State.TakeDamage();
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

        public void Stop()
        {
            State.Stop();
        }

        public void Attack()
        {
            State.Attack();
        }

        public void UseItem(int Item)
        {
            this.Item = Item;
            State.UseItem();

        }

        public void Update()
        {
            State.Update();
        }

        public void Reset()
        {
            State = new UpIdleState(this, _game);
            GlobalDefinitions.Position = new Vector2(GlobalDefinitions.GraphicsWidth / 2, GlobalDefinitions.GraphicsHeight / 2);
        }
    }
}

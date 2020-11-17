using Game1.Command;
using Game1.Command.GameCommand;
using Game1.Command.MenuCommand;
using Game1.Controller;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Inventory
{
    class MenuKeyBroadController : IController
    {
        private Dictionary<Keys, ICommand> controllerMappings;
        private MainStage instance;
        public MenuKeyBroadController(MainStage instance)
        {
            this.instance = instance;
            controllerMappings = new Dictionary<Keys, ICommand>();

            controllerMappings.Add(Keys.P, new PauseGameCommand(instance));
            controllerMappings.Add(Keys.Q, new QuitGameCommand(instance));
            controllerMappings.Add(Keys.R, new ResetGameCommand(instance));

            controllerMappings.Add(Keys.W, new SelectUpCommand(this.instance.GetInventoryMenu()));
            controllerMappings.Add(Keys.Up, new SelectUpCommand(this.instance.GetInventoryMenu()));
            controllerMappings.Add(Keys.A, new SelectLeftCommand(this.instance.GetInventoryMenu()));
            controllerMappings.Add(Keys.Left, new SelectLeftCommand(this.instance.GetInventoryMenu()));
            controllerMappings.Add(Keys.S, new SelectDownCommand(this.instance.GetInventoryMenu()));
            controllerMappings.Add(Keys.Down, new SelectDownCommand(this.instance.GetInventoryMenu()));
            controllerMappings.Add(Keys.D, new SelectRightCommand(this.instance.GetInventoryMenu()));
            controllerMappings.Add(Keys.Right, new SelectRightCommand(this.instance.GetInventoryMenu()));

        }
        public void Update()
        {
            var pressedKeys = Keyboard.GetState().GetPressedKeys();

            foreach (Keys key in pressedKeys)
            {
                controllerMappings[key]?.Execute();
            }

        }
    }
}

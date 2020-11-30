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
        public static Keys lastPressedKey;
        private Dictionary<Keys, ICommand> controllerMappings;
        private MainStage instance;
        static KeyboardState currentKeyState;
        static KeyboardState previousKeyState;
        public MenuKeyBroadController(MainStage instance)
        {
            this.instance = instance;
            controllerMappings = new Dictionary<Keys, ICommand>();

            controllerMappings.Add(Keys.Space, new ResumeGameCommand(instance));
            controllerMappings.Add(Keys.Q, new QuitGameCommand(instance));
            controllerMappings.Add(Keys.R, new ResetGameCommand(instance));
            controllerMappings.Add(Keys.P, new PauseGameCommand(instance));

            controllerMappings.Add(Keys.W, new SelectUpCommand(this.instance.InventoryMenu));
            controllerMappings.Add(Keys.Up, new SelectUpCommand(this.instance.InventoryMenu));
            controllerMappings.Add(Keys.A, new SelectLeftCommand(this.instance.InventoryMenu));
            controllerMappings.Add(Keys.Left, new SelectLeftCommand(this.instance.InventoryMenu));
            controllerMappings.Add(Keys.S, new SelectDownCommand(this.instance.InventoryMenu));
            controllerMappings.Add(Keys.Down, new SelectDownCommand(this.instance.InventoryMenu));
            controllerMappings.Add(Keys.D, new SelectRightCommand(this.instance.InventoryMenu));
            controllerMappings.Add(Keys.Right, new SelectRightCommand(this.instance.InventoryMenu));

        }
        public void Update()
        {
            var OnceKeyArray = new Keys[12] { Keys.Space, Keys.Q, Keys.R, Keys.P, Keys.W, Keys.Up, Keys.A, Keys.Left, Keys.S, Keys.Down, Keys.D, Keys.Right };
            previousKeyState = currentKeyState;
            currentKeyState = Keyboard.GetState();
            foreach (Keys key in OnceKeyArray)
            {
                //if the keys in the keyArray are pressed, execute corresponding command

                if (OnceKeyArray.Contains<Keys>(key))
                {
                    if (currentKeyState.IsKeyDown(key) && !previousKeyState.IsKeyDown(key))
                    {
                        controllerMappings[key]?.Execute();
                        lastPressedKey = key;
                    }

                }
            }
        }
    }
}

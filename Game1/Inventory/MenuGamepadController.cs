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
    class MenuGamepadController : IController
    {
        public static Buttons lastPressed;
        private Dictionary<Buttons, ICommand> controllerMappings;
        private MainStage instance;
        static GamePadState currentState;
        static GamePadState previousState;
        public MenuGamepadController(MainStage instance)
        {
            this.instance = instance;
            controllerMappings = new Dictionary<Buttons, ICommand>();

            controllerMappings.Add(Buttons.RightTrigger, new ResumeGameCommand(instance));
            controllerMappings.Add(Buttons.Back, new QuitGameCommand(instance));
            controllerMappings.Add(Buttons.LeftTrigger, new ResetGameCommand(instance));
            controllerMappings.Add(Buttons.Start, new PauseGameCommand(instance));

            controllerMappings.Add(Buttons.DPadUp, new SelectUpCommand(this.instance.InventoryMenu));
            controllerMappings.Add(Buttons.DPadLeft, new SelectLeftCommand(this.instance.InventoryMenu));
            controllerMappings.Add(Buttons.DPadDown, new SelectDownCommand(this.instance.InventoryMenu));
            controllerMappings.Add(Buttons.DPadRight, new SelectRightCommand(this.instance.InventoryMenu));

        }
        public void Update()
        {
            var OnceArray = new Buttons[] { Buttons.DPadUp, Buttons.DPadDown, Buttons.DPadLeft, Buttons.DPadRight, Buttons.Start, Buttons.Back, Buttons.LeftShoulder,
                Buttons.RightShoulder, Buttons.LeftTrigger, Buttons.RightTrigger };
            previousState = currentState;
            currentState = GamePad.GetState(Microsoft.Xna.Framework.PlayerIndex.One);
            foreach (Buttons button in OnceArray)
            {
                //if the keys in the keyArray are pressed, execute corresponding command

                if (OnceArray.Contains<Buttons>(button))
                {
                    if (currentState.IsButtonDown(button) && !previousState.IsButtonDown(button))
                    {
                        controllerMappings[button]?.Execute();
                        lastPressed = button;
                    }

                }
            }
        }
    }
}

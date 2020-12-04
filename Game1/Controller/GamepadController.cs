using Game1.Command;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Game1.Controller
{
    class GamepadController : IController
    {
        public static Buttons lastButtonPressed;
        private Dictionary<Buttons, ICommand> gamepadMappings;
        private MainStage instance;

        static GamePadState currentState;
        static GamePadState previousState;

        public GamepadController(MainStage instance)
        {
            lastButtonPressed = Buttons.Back;
            this.instance = instance;
            gamepadMappings = new Dictionary<Buttons, ICommand>();

            gamepadMappings.Add(Buttons.Back, new QuitGameCommand(instance));
            gamepadMappings.Add(Buttons.Start, new PauseGameCommand(instance));
            gamepadMappings.Add(Buttons.LeftTrigger, new ResetGameCommand(instance));
            gamepadMappings.Add(Buttons.DPadUp, new UpMovingCommand(this.instance.Link));
            gamepadMappings.Add(Buttons.DPadLeft, new LeftMovingCommand(this.instance.Link));
            gamepadMappings.Add(Buttons.DPadDown, new DownMovingCommand(this.instance.Link));
            gamepadMappings.Add(Buttons.DPadRight, new RightMovingCommand(this.instance.Link));

            gamepadMappings.Add(Buttons.A, new StandingWoodenSwordCommand(this.instance.Link));
            gamepadMappings.Add(Buttons.X, new UseArrowCommand(this.instance.Link));
            gamepadMappings.Add(Buttons.B, new UseBombCommand(this.instance.Link));
            gamepadMappings.Add(Buttons.Y, new UseBoomerCommand(this.instance.Link));
        }
        public void Update()
        {
            var buttonarray = new Buttons[14] {Buttons.A, Buttons.B, Buttons.Y, Buttons.X, Buttons.DPadUp,
                Buttons.DPadLeft, Buttons.DPadDown, Buttons.DPadRight, Buttons.Back, Buttons.Start, Buttons.LeftShoulder,
                Buttons.RightShoulder, Buttons.LeftTrigger, Buttons.RightTrigger };

            var attackarray = new Buttons[] { Buttons.A };
            var oncearray = new Buttons[] {Buttons.B, Buttons.Y, Buttons.X, Buttons.DPadUp,
                Buttons.DPadLeft, Buttons.DPadDown, Buttons.DPadRight, Buttons.Back, Buttons.Start, Buttons.LeftShoulder,
                Buttons.RightShoulder, Buttons.LeftTrigger, Buttons.RightTrigger};
            previousState = currentState;
            currentState = GamePad.GetState(Microsoft.Xna.Framework.PlayerIndex.One);


            if (oncearray.Contains<Buttons>(lastButtonPressed))
            {
                ICommand command = new StopCommand(this.instance.Link);
                command.Execute();
            }
            else if (attackarray.Contains<Buttons>(lastButtonPressed))
            {
            }
            else if (buttonarray.Contains<Buttons>(lastButtonPressed) && (!currentState.IsButtonDown(lastButtonPressed)))
            {
                ICommand command = new StopCommand(this.instance.Link);
                command.Execute();
            }

            foreach (Buttons button in buttonarray)
            {
                //if the keys in the keyArray are pressed, execute corresponding command

                if (oncearray.Contains<Buttons>(button))
                {
                    if (currentState.IsButtonDown(button) && !previousState.IsButtonDown(button))
                    {
                        gamepadMappings[button]?.Execute();
                        lastButtonPressed = button;
                    }

                }
                else if (attackarray.Contains<Buttons>(button))
                {
                    if (currentState.IsButtonDown(button) && !previousState.IsButtonDown(button))
                    {
                        gamepadMappings[button]?.Execute();
                        lastButtonPressed = button;

                    }
                }
                else if (buttonarray.Contains<Buttons>(button))
                {
                    if (currentState.IsButtonDown(button))

                    {
                        if ((lastButtonPressed == button) || ((lastButtonPressed != button) && currentState.IsButtonUp(lastButtonPressed)))
                        {
                            gamepadMappings[button]?.Execute();
                            lastButtonPressed = button;
                        }

                    }
                }
            }
        }
    }
}

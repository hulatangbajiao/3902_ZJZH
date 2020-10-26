using Game1.Command;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Game1.Controller
{
    public class KeyboardController : IController
    {
        public static Keys lastPressedKey;
        private Dictionary<Keys, ICommand> controllerMappings;
        private MainStage instance;

        static KeyboardState currentKeyState;
        static KeyboardState previousKeyState;

        public KeyboardController(MainStage instance)
        {
            lastPressedKey = Keys.Q;
            this.instance = instance;
            controllerMappings = new Dictionary<Keys, ICommand>();

            //Use 'q' to quit and 'r' to reset the program back to its initial state.
            controllerMappings.Add(Keys.Q, new QuitGameCommand(instance));
            controllerMappings.Add(Keys.R, new ResetGameCommand(instance));

            // Link
            //Arrow and "wasd" keys should move Link and change his facing direction.
            controllerMappings.Add(Keys.W, new UpMovingCommand(this.instance.Link));
            controllerMappings.Add(Keys.Up, new UpMovingCommand(this.instance.Link));
            controllerMappings.Add(Keys.A, new LeftMovingCommand(this.instance.Link));
            controllerMappings.Add(Keys.Left, new LeftMovingCommand(this.instance.Link));
            controllerMappings.Add(Keys.S, new DownMovingCommand(this.instance.Link));
            controllerMappings.Add(Keys.Down, new DownMovingCommand(this.instance.Link));
            controllerMappings.Add(Keys.D, new RightMovingCommand(this.instance.Link));
            controllerMappings.Add(Keys.Right, new RightMovingCommand(this.instance.Link));
            controllerMappings.Add(Keys.Z, new StandingWoodenSwordCommand(this.instance.Link));
            controllerMappings.Add(Keys.N, new StandingWoodenSwordCommand(this.instance.Link));
            controllerMappings.Add(Keys.E, new DamagedCommand(this.instance.Link));

            //Number keys (1, 2, 3, etc.) should be used to have Link use a different item 
            controllerMappings.Add(Keys.NumPad1, new UseArrowCommand(this.instance.Link));
            controllerMappings.Add(Keys.NumPad2, new UseBombCommand(this.instance.Link));
            controllerMappings.Add(Keys.NumPad3, new UseBoomerCommand(this.instance.Link));
            controllerMappings.Add(Keys.D1, new UseArrowCommand(this.instance.Link));
            controllerMappings.Add(Keys.D2, new UseBombCommand(this.instance.Link));
            controllerMappings.Add(Keys.D3, new UseBoomerCommand(this.instance.Link));
        }
        public void Update()
        {
            var keyArray = new Keys[25] { Keys.W, Keys.Up, Keys.A, Keys.Left, Keys.S, Keys.Down, Keys.D, Keys.Right, Keys.Z, Keys.N, Keys.E, Keys.NumPad1, Keys.D1, Keys.NumPad2, Keys.D2, Keys.NumPad3, Keys.D3, Keys.Y, Keys.T, Keys.U, Keys.I, Keys.Q, Keys.R, Keys.O, Keys.P };
            var OnceKeyArray = new Keys[15] { Keys.E, Keys.NumPad1, Keys.D1, Keys.NumPad2, Keys.D2, Keys.NumPad3, Keys.D3, Keys.Y, Keys.T, Keys.U, Keys.I, Keys.Q, Keys.R, Keys.O, Keys.P };
            var AttackArray = new Keys[2] { Keys.Z, Keys.N };
            previousKeyState = currentKeyState;
            currentKeyState = Keyboard.GetState();

            if (OnceKeyArray.Contains<Keys>(lastPressedKey))
            {
                new StopCommand(this.instance.Link);
            }
            else if (AttackArray.Contains<Keys>(lastPressedKey))
            {
            }
            else if (keyArray.Contains<Keys>(lastPressedKey) && (!currentKeyState.IsKeyDown(lastPressedKey)))
            {
                new StopCommand(this.instance.Link);
            }

            foreach (Keys key in keyArray)
            {
                //if the keys in the keyArray are pressed, execute corresponding command

                if (OnceKeyArray.Contains<Keys>(key))
                {
                    if (currentKeyState.IsKeyDown(key) && !previousKeyState.IsKeyDown(key) && currentKeyState.IsKeyUp(lastPressedKey))
                    {
                        controllerMappings[key]?.Execute();
                        lastPressedKey = key;
                    }

                }
                else if (AttackArray.Contains<Keys>(key))
                {
                    if (currentKeyState.IsKeyDown(key) && !previousKeyState.IsKeyDown(key))
                    {
                        controllerMappings[key]?.Execute();
                        lastPressedKey = key;

                    }
                }
                else if (keyArray.Contains<Keys>(key))
                {
                    if (currentKeyState.IsKeyDown(key))

                    {
                        controllerMappings[key]?.Execute();
                        lastPressedKey = key;
                    }
                }
            }
        }
    }

}


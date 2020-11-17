using Game1.Command;
using Game1.Controller;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.GameState
{
    class KeybroadGameWin : IController
    {
        public static Keys lastPressedKey;
        private Dictionary<Keys, ICommand> controllerMappings;
        private MainStage instance;
        static KeyboardState currentKeyState;
        static KeyboardState previousKeyState;
        public KeybroadGameWin(MainStage instance)
        {
            this.instance = instance;
            controllerMappings = new Dictionary<Keys, ICommand>();

            controllerMappings.Add(Keys.Q, new QuitGameCommand(instance));
            controllerMappings.Add(Keys.R, new ResetGameCommand(instance));

        }
        public void Update()
        {
            previousKeyState = currentKeyState;
            currentKeyState = Keyboard.GetState();
            var keyArray = new Keys[2] { Keys.Q, Keys.R };
            foreach (Keys key in keyArray)
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

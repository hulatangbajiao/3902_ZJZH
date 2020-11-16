﻿using Game1.Command;
using Game1.Controller;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.GameWin
{
    class KeybroadGameWin : IController
    {
        private Dictionary<Keys, ICommand> controllerMappings;
        private MainStage instance;
        public KeybroadGameWin(MainStage instance)
        {
            this.instance = instance;
            controllerMappings = new Dictionary<Keys, ICommand>();

            controllerMappings.Add(Keys.Q, new QuitGameCommand(instance));
            controllerMappings.Add(Keys.R, new ResetGameCommand(instance));

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
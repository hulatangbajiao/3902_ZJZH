using Game1.Interface;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Game1.Controller
{
    class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> controllerMappings;

	    public KeyboardController()
	    {
		    controllerMappings = new Dictionary<Keys, ICommand>();
	    }

	    public void RegisterCommand(Keys key, ICommand command)
	    {
		    controllerMappings.Add(key, command);
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

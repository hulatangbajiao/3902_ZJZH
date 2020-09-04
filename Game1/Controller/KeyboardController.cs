using Game1.Command;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Game1.Controller
{
    class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> controllerMappings;

	    public KeyboardController(MainStage instance)
	    {
		    controllerMappings = new Dictionary<Keys, ICommand>();
            controllerMappings.Add(Keys.NumPad0, new QuitGameCommand(instance));
            controllerMappings.Add(Keys.D0, new QuitGameCommand(instance));
            controllerMappings.Add(Keys.NumPad1, new SetSpriteCommand(instance, GlobalDefinitions.SpriteModes.StaticFixed));
            controllerMappings.Add(Keys.D1, new SetSpriteCommand(instance, GlobalDefinitions.SpriteModes.StaticFixed));
            controllerMappings.Add(Keys.NumPad2, new SetSpriteCommand(instance, GlobalDefinitions.SpriteModes.AnimatedFixed));
            controllerMappings.Add(Keys.D2, new SetSpriteCommand(instance, GlobalDefinitions.SpriteModes.AnimatedFixed));
            controllerMappings.Add(Keys.NumPad3, new SetSpriteCommand(instance, GlobalDefinitions.SpriteModes.StaticVerticalMoving));
            controllerMappings.Add(Keys.D3, new SetSpriteCommand(instance, GlobalDefinitions.SpriteModes.StaticVerticalMoving));
            controllerMappings.Add(Keys.NumPad4, new SetSpriteCommand(instance, GlobalDefinitions.SpriteModes.AnimatedHorizontalMoving));
            controllerMappings.Add(Keys.D4, new SetSpriteCommand(instance, GlobalDefinitions.SpriteModes.AnimatedHorizontalMoving));
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

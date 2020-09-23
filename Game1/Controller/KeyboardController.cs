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

            //Use 'q' to quit and 'r' to reset the program back to its initial state.
            controllerMappings.Add(Keys.Q, new QuitGameCommand(instance));
            controllerMappings.Add(Keys.R, new ResetGameCommand(instance));

            // Link
            //Arrow and "wasd" keys should move Link and change his facing direction.
            //change face direction
            controllerMappings.Add(Keys.W, new SetLinkCommand(instance, GlobalDefinitions.LinkModes.UpIdleState));
            controllerMappings.Add(Keys.PageUp, new SetLinkCommand(instance, GlobalDefinitions.LinkModes.UpIdleState));
            controllerMappings.Add(Keys.A, new SetLinkCommand(instance, GlobalDefinitions.LinkModes.LeftIdleState));
            controllerMappings.Add(Keys.Home, new SetLinkCommand(instance, GlobalDefinitions.LinkModes.LeftIdleState));
            controllerMappings.Add(Keys.S, new SetLinkCommand(instance, GlobalDefinitions.LinkModes.RightIdleState));
            controllerMappings.Add(Keys.PageDown, new SetLinkCommand(instance, GlobalDefinitions.LinkModes.RightIdleState));
            controllerMappings.Add(Keys.D, new SetLinkCommand(instance, GlobalDefinitions.LinkModes.DownIdleState));
            controllerMappings.Add(Keys.End, new SetLinkCommand(instance, GlobalDefinitions.LinkModes.DownIdleState));
            // TODO: moving, long key press to move?? short key press to change the face direction??
            controllerMappings.Add(Keys.W, new SetLinkCommand(instance, GlobalDefinitions.LinkModes.UpMovingState));
            controllerMappings.Add(Keys.PageUp, new SetLinkCommand(instance, GlobalDefinitions.LinkModes.UpMovingState));
            controllerMappings.Add(Keys.A, new SetLinkCommand(instance, GlobalDefinitions.LinkModes.LeftMovingState));
            controllerMappings.Add(Keys.Home, new SetLinkCommand(instance, GlobalDefinitions.LinkModes.LeftMovingState));
            controllerMappings.Add(Keys.S, new SetLinkCommand(instance, GlobalDefinitions.LinkModes.RightMovingState));
            controllerMappings.Add(Keys.PageDown, new SetLinkCommand(instance, GlobalDefinitions.LinkModes.RightMovingState));
            controllerMappings.Add(Keys.D, new SetLinkCommand(instance, GlobalDefinitions.LinkModes.DownMovingState));
            controllerMappings.Add(Keys.End, new SetLinkCommand(instance, GlobalDefinitions.LinkModes.DownMovingState));

            //The 'z' and 'n' key should cause Link to attack using his sword.
            controllerMappings.Add(Keys.Z, new SetLinkCommand(instance, GlobalDefinitions.LinkModes.StandingMagicalRodState));
            controllerMappings.Add(Keys.N, new SetLinkCommand(instance, GlobalDefinitions.LinkModes.StandingMagicalRodState));

            //Number keys (1, 2, 3, etc.) should be used to have Link use a different item 
            controllerMappings.Add(Keys.NumPad1, new SetLinkCommand(instance, GlobalDefinitions.LinkModes.StandingMagicalRodState));
            controllerMappings.Add(Keys.NumPad2, new SetLinkCommand(instance, GlobalDefinitions.LinkModes.StandingWhiteSwordState));
            controllerMappings.Add(Keys.NumPad3, new SetLinkCommand(instance, GlobalDefinitions.LinkModes.StandingWoodenSwordState));
            controllerMappings.Add(Keys.D1, new SetLinkCommand(instance, GlobalDefinitions.LinkModes.StandingMagicalRodState));
            controllerMappings.Add(Keys.D2, new SetLinkCommand(instance, GlobalDefinitions.LinkModes.StandingWhiteSwordState));
            controllerMappings.Add(Keys.D3, new SetLinkCommand(instance, GlobalDefinitions.LinkModes.StandingWoodenSwordState));

            //Use 'e' to cause Link to become damaged.
            controllerMappings.Add(Keys.E, new SetLinkCommand(instance, GlobalDefinitions.LinkModes.damaged));

            //Block/obstacle controls
            //TODO: need to modify, Use keys "t" and "y" to cycle between which block is currently being shown
            controllerMappings.Add(Keys.T, new SetBlockCommand(instance, GlobalDefinitions.BlockModes.previous));
            controllerMappings.Add(Keys.Y, new SetBlockCommand(instance, GlobalDefinitions.BlockModes.next));

            //Item controls
            //Use keys "u" and "i" to cycle between which item is currently being shown
            controllerMappings.Add(Keys.U, new SetItemCommand(instance, GlobalDefinitions.ItemModes.previous));
            controllerMappings.Add(Keys.I, new SetItemCommand(instance, GlobalDefinitions.ItemModes.next));

            //Enemy/NPC (other character) controls
            //Use keys "o" and "p" to cycle between which enemy or npc is currently being shown 
            controllerMappings.Add(Keys.O, new SetNPCommand(instance, GlobalDefinitions.NPCModes.previous));
            controllerMappings.Add(Keys.P, new SetNPCCommand(instance, GlobalDefinitions.NPCModes.next));

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

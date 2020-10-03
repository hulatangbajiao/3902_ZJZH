using Game1.Command;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Game1.Controller
{
    public class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> controllerMappings;
        private MainStage instance;


        public KeyboardController(MainStage instance, IPlayer Link)
        {
            this.instance = instance;
            controllerMappings = new Dictionary<Keys, ICommand>();

            //Use 'q' to quit and 'r' to reset the program back to its initial state.
            controllerMappings.Add(Keys.Q, new QuitGameCommand(instance));
            controllerMappings.Add(Keys.R, new ResetGameCommand(instance));

            // Link
            //Arrow and "wasd" keys should move Link and change his facing direction.
<<<<<<< Updated upstream
            controllerMappings.Add(Keys.W, new UpMovingCommand(Link));
            controllerMappings.Add(Keys.PageUp, new UpMovingCommand(Link));
            controllerMappings.Add(Keys.A, new LeftMovingCommand(Link));
            controllerMappings.Add(Keys.Home, new LeftMovingCommand(Link));
            controllerMappings.Add(Keys.S, new DownMovingCommand(Link));
            controllerMappings.Add(Keys.PageDown, new DownMovingCommand(Link));
            controllerMappings.Add(Keys.D, new RightMovingCommand(Link));
            controllerMappings.Add(Keys.End, new RightMovingCommand(Link));
=======
            controllerMappings.Add(Keys.W, new UpMovingCommand(this.instance.Link));
            controllerMappings.Add(Keys.PageUp, new UpMovingCommand(this.instance.Link));
            controllerMappings.Add(Keys.A, new LeftMovingCommand(this.instance.Link));
            controllerMappings.Add(Keys.Home, new LeftMovingCommand(this.instance.Link));
            controllerMappings.Add(Keys.S, new DownMovingCommand(this.instance.Link));
            controllerMappings.Add(Keys.PageDown, new DownMovingCommand(this.instance.Link));
            controllerMappings.Add(Keys.D, new RightMovingCommand(this.instance.Link));
            controllerMappings.Add(Keys.End, new RightMovingCommand(this.instance.Link));
            
            controllerMappings.Add(Keys.Z, new StandingWoodenSwordCommand(this.instance.Link));
            controllerMappings.Add(Keys.N, new StandingWoodenSwordCommand(this.instance.Link));
            
            
>>>>>>> Stashed changes

            
            controllerMappings.Add(Keys.E, new DamagedCommand(this.instance.Link));
            /*
            //Block/obstacle controls
            //TODO: need to modify, Use keys "t" and "y" to cycle between which block is currently being shown
            controllerMappings.Add(Keys.T, new SetBlockCommand(instance, GlobalDefinitions.BlockModes.previous));
            controllerMappings.Add(Keys.Y, new SetBlockCommand(instance, GlobalDefinitions.BlockModes.next));

            //Number keys (1, 2, 3, etc.) should be used to have Link use a different item 
            controllerMappings.Add(Keys.NumPad1, new StandingWoodenSwordCommand(Link));
            controllerMappings.Add(Keys.NumPad2, new StandingWhiteSwordCommand(Link));
            controllerMappings.Add(Keys.NumPad3, new StandingMagicalRodCommand(Link));
            controllerMappings.Add(Keys.D1, new StandingWoodenSwordCommand(Link));
            controllerMappings.Add(Keys.D2, new StandingWhiteSwordCommand(Link));
            controllerMappings.Add(Keys.D3, new StandingMagicalRodCommand(Link));

            //Item controls
            //Use keys "u" and "i" to cycle between which item is currently being shown
            controllerMappings.Add(Keys.U, new SetItemCommand(instance, GlobalDefinitions.ItemModes.previous));
            controllerMappings.Add(Keys.I, new SetItemCommand(instance, GlobalDefinitions.ItemModes.next));

            //Enemy/NPC (other character) controls
            //Use keys "o" and "p" to cycle between which enemy or npc is currently being shown 
            controllerMappings.Add(Keys.O, new SetNPCommand(instance, GlobalDefinitions.NPCModes.previous));
            controllerMappings.Add(Keys.P, new SetNPCCommand(instance, GlobalDefinitions.NPCModes.next));
        }
<<<<<<< Updated upstream
            public void Update() {
                var pressedKeys = Keyboard.GetState().GetPressedKeys();
=======
        public void Update()
        {

            var keyArray = new Keys[11] { Keys.W, Keys.PageUp, Keys.A, Keys.Home, Keys.S, Keys.PageDown, Keys.D, Keys.End, Keys.Z, Keys.N, Keys.E};
>>>>>>> Stashed changes

                foreach (Keys key in pressedKeys)
                {
                    controllerMappings[key]?.Execute();
                }
            }
        }
    }
<<<<<<< Updated upstream
=======
}
>>>>>>> Stashed changes

}


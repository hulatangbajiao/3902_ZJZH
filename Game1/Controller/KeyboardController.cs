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



        public KeyboardController(MainStage instance)
        {
            this.instance = instance;
            controllerMappings = new Dictionary<Keys, ICommand>();

            //Use 'q' to quit and 'r' to reset the program back to its initial state.
            controllerMappings.Add(Keys.Q, new QuitGameCommand(instance));
            controllerMappings.Add(Keys.R, new ResetGameCommand(instance));

            // Link
            //Arrow and "wasd" keys should move Link and change his facing direction.
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
            
            

            
            controllerMappings.Add(Keys.E, new DamagedCommand(this.instance.Link));
            
            //Block/obstacle controls
            //TODO: need to modify, Use keys "t" and "y" to cycle between which block is currently being shown
            
            controllerMappings.Add(Keys.T, new NextBlockCommand(this.instance.BlockList));
            controllerMappings.Add(Keys.Y, new PreviousBlockCommand(this.instance.BlockList));

            //Number keys (1, 2, 3, etc.) should be used to have Link use a different item 
            controllerMappings.Add(Keys.NumPad1, new UseArrowCommand(this.instance.Link));
            controllerMappings.Add(Keys.NumPad2, new UseBombCommand(this.instance.Link));
            controllerMappings.Add(Keys.NumPad3, new UseBoomerCommand(this.instance.Link));
            controllerMappings.Add(Keys.D1, new UseArrowCommand(this.instance.Link));
            controllerMappings.Add(Keys.D2, new UseBombCommand(this.instance.Link));
            controllerMappings.Add(Keys.D3, new UseBoomerCommand(this.instance.Link));

            //Item controls
            //Use keys "u" and "i" to cycle between which item is currently being shown
            controllerMappings.Add(Keys.U, new PreviousItemCommand(this.instance.ItemList));
            controllerMappings.Add(Keys.I, new NextItemCommand(this.instance.ItemList));

            //Enemy/NPC (other character) controls
            //Use keys "o" and "p" to cycle between which enemy or npc is currently being shown 
            controllerMappings.Add(Keys.O, new PreviousEnemyCommand(this.instance.Enemylist));
            controllerMappings.Add(Keys.P, new NextEnemyCommand(this.instance.Enemylist));

        
        }
        public void Update()
        {

            var keyArray = new Keys[25] { Keys.W, Keys.PageUp, Keys.A, Keys.Home, Keys.S, Keys.PageDown, Keys.D, Keys.End, Keys.Z, Keys.N, Keys.E, Keys.NumPad1, Keys.D1, Keys.NumPad2, Keys.D2, Keys.NumPad3, Keys.D3, Keys.Y, Keys.T, Keys.U, Keys.I, Keys.Q, Keys.R, Keys.O, Keys.P};


            if (keyArray.Contains(lastPressedKey) && Keyboard.GetState().IsKeyUp(lastPressedKey))
            {
                controllerMappings[lastPressedKey]?.Stop();
            }
            foreach (Keys key in keyArray)
            {
                //if the keys in the keyArray are pressed, execute corresponding command
                if (Keyboard.GetState().IsKeyDown(key))
                {
                    controllerMappings[key]?.Execute();
                    lastPressedKey = key;
                }
            }
        }
    }

}


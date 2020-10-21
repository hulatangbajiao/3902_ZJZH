using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game1.Command;
using Microsoft.Xna.Framework.Input;

namespace Game1.Controller
{
    class MouseController : IController
    {
        private ICommand RoomPreviousCommand;
        private ICommand RoomNextCommand;
      

        public MouseController(MainStage instance)
        {
            RoomNextCommand = new RoomNextCommand();
            RoomPreviousCommand = new RoomPreviousCommand();
            
        }

        public void Update()
        {
            MouseState state = Mouse.GetState();

            // Mouse event should only respond within the window area
            if (state.X < 0 || state.X > GlobalDefinitions.GraphicsWidth ||
                state.Y < 0 || state.Y > GlobalDefinitions.GraphicsHeight)
            {
                return;
            }

            // If the right button is clicked, exit the game
            if (state.RightButton == ButtonState.Pressed)
            {
                
            }

            // If the left button is clicked, handle it according to the position
            if (state.LeftButton == ButtonState.Pressed)
            {
            }
        }
    }
 }

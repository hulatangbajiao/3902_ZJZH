using Game1.Command;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;

namespace Game1.Controller
{
    class MouseController : IController
    {
        private ICommand quitGameCommand;

        public MouseController(Game instance)
        {
            quitGameCommand = new QuitGameCommand(instance);
        }

        public void Update()
        {
            MouseState state = Mouse.GetState();
            
            // If the right button is clicked, exit the game
            if (state.RightButton == ButtonState.Pressed)
            {
                quitGameCommand.Execute();
                return;
            }

            // If the left button is clicked, handle it according to the position
            Debug.WriteLine($"X {state.X}, Y {state.Y}");
        }
    }
}

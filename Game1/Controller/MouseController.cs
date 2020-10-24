using Game1.Command;
using Microsoft.Xna.Framework.Input;

namespace Game1.Controller
{
    class MouseController : IController
    {
        private ICommand quitGameCommand;
        private ICommand[] setSpriteCommands;

        public MouseController(MainStage instance)
        {
            
        }

        public void Update()
        {
            MouseState state = Mouse.GetState();


            // If the left button is clicked, handle it according to the position
            if (state.LeftButton == ButtonState.Pressed)
            {
                
            }

            if (state.RightButton == ButtonState.Pressed)
            {

            }
        }
    }
}

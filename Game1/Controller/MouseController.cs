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
            quitGameCommand = new QuitGameCommand(instance);
            setSpriteCommands = new ICommand[(int) GlobalDefinitions.SpriteModes.Invalid];
            setSpriteCommands[(int)GlobalDefinitions.SpriteModes.StaticFixed] = new SetSpriteCommand(instance,
                GlobalDefinitions.SpriteModes.StaticFixed);
            setSpriteCommands[(int)GlobalDefinitions.SpriteModes.StaticVerticalMoving] = new SetSpriteCommand(instance,
                GlobalDefinitions.SpriteModes.StaticVerticalMoving);
            setSpriteCommands[(int)GlobalDefinitions.SpriteModes.AnimatedFixed] = new SetSpriteCommand(instance,
                GlobalDefinitions.SpriteModes.AnimatedFixed);
            setSpriteCommands[(int)GlobalDefinitions.SpriteModes.AnimatedHorizontalMoving] = new SetSpriteCommand(instance,
                GlobalDefinitions.SpriteModes.AnimatedHorizontalMoving);
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
                quitGameCommand.Execute();
                return;
            }

            // If the left button is clicked, handle it according to the position
            if (state.LeftButton == ButtonState.Pressed)
            {
                if (state.X < GlobalDefinitions.GraphicsWidth / 2 && state.Y < GlobalDefinitions.GraphicsHeight / 2)
                {
                    setSpriteCommands[(int)GlobalDefinitions.SpriteModes.StaticFixed].Execute();
                }
                else if (state.X > GlobalDefinitions.GraphicsWidth / 2 && state.Y < GlobalDefinitions.GraphicsHeight / 2)
                {
                    setSpriteCommands[(int)GlobalDefinitions.SpriteModes.AnimatedFixed].Execute();
                }
                else if (state.X < GlobalDefinitions.GraphicsWidth / 2 && state.Y > GlobalDefinitions.GraphicsHeight / 2)
                {
                    setSpriteCommands[(int)GlobalDefinitions.SpriteModes.StaticVerticalMoving].Execute();
                }
                else
                {
                    setSpriteCommands[(int)GlobalDefinitions.SpriteModes.AnimatedHorizontalMoving].Execute();
                }
            }
        }
    }
}

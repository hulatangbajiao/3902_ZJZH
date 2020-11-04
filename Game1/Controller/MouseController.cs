using Game1.Command;
using Game1.Command.RoomCommand;
using Microsoft.Xna.Framework.Input;

namespace Game1.Controller
{
    class MouseController : IController
    {
        private ICommand NorthRoomCommand;
        private ICommand SouthRoomCommand;
        private ICommand WestRoomCommand;
        private ICommand EastRoomCommand;
        private MainStage instance;
        private object dungeonlevel;

        public MouseController(MainStage instance)
        {
            NorthRoomCommand = new NorthRoomCommand(instance.dungeonlevel);
            SouthRoomCommand = new SouthRoomCommand(instance.dungeonlevel);
            WestRoomCommand = new EastRoomCommand(instance.dungeonlevel);
            EastRoomCommand = new WestRoomCommand(instance.dungeonlevel);
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

            // If the left button is clicked, handle it according to the position
            if (state.LeftButton == ButtonState.Pressed)
            {
                if (state.X < GlobalDefinitions.GraphicsWidth / 2 && state.Y < GlobalDefinitions.GraphicsHeight / 2)
                {
                    NorthRoomCommand.Execute();
                }
                else if (state.X > GlobalDefinitions.GraphicsWidth / 2 && state.Y < GlobalDefinitions.GraphicsHeight / 2)
                {
                    SouthRoomCommand.Execute();
                }
                else if (state.X < GlobalDefinitions.GraphicsWidth / 2 && state.Y > GlobalDefinitions.GraphicsHeight / 2)
                {
                    WestRoomCommand.Execute();
                }
                else
                {
                    EastRoomCommand.Execute();
                }

            }
        }
    }
}

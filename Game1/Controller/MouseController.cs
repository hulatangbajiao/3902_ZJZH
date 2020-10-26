using Game1.Command;
using Microsoft.Xna.Framework.Input;

namespace Game1.Controller
{
    class MouseController : IController
    {
        private ICommand NextRoomCommand;
        private ICommand PreviousRoomCommand;
        private MainStage instance;

        public MouseController(MainStage instance)
        {
            this.instance = instance;
            NextRoomCommand = new NextRoomCommand(this.instance.DungeonLevel.Rooms);
            PreviousRoomCommand = new PreviousRoomCommand(this.instance.DungeonLevel.Rooms);
        }

        public void Update()
        {
            MouseState state = Mouse.GetState();

            // If the left button is clicked, handle it according to the position
            if (state.LeftButton == ButtonState.Pressed)
            {
                PreviousRoomCommand.Execute();
            }

            if (state.RightButton == ButtonState.Pressed)
            {
                NextRoomCommand.Execute();
            }
        }
    }
}

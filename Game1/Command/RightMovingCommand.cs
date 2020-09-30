using Game1.Command;

namespace Game1.Controller
{
    internal class RightMovingCommand : ICommand
    {
        private IPlayer link;

        public RightMovingCommand(IPlayer link)
        {
            this.link = link;
        }
    }
}
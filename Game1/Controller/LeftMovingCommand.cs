using Game1.Command;

namespace Game1.Controller
{
    internal class LeftMovingCommand : ICommand
    {
        private IPlayer link;

        public LeftMovingCommand(IPlayer link)
        {
            this.link = link;
        }
    }
}
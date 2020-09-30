using Game1.Command;

namespace Game1.Controller
{
    internal class StandingWhiteSwordCommand : ICommand
    {
        private IPlayer link;

        public StandingWhiteSwordCommand(IPlayer link)
        {
            this.link = link;
        }
    }
}
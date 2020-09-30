using Game1.Command;

namespace Game1.Controller
{
    internal class StandingWoodenSwordCommand : ICommand
    {
        private IPlayer link;

        public StandingWoodenSwordCommand(IPlayer link)
        {
            this.link = link;
        }
    }
}
using Game1.Command;

namespace Game1.Controller
{
    internal class StandingMagicalRodCommand : ICommand
    {
        private IPlayer link;

        public StandingMagicalRodCommand(IPlayer link)
        {
            this.link = link;
        }
    }
}
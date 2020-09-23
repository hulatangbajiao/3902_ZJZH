using static Game1.GlobalDefinitions;

namespace Game1.Command
{
    class SetLinkCommand : ICommand
    {
        private LinkModes LinkMode;
        private MainStage GameInstnace;

        public SetLinkCommand(MainStage instnace, LinkModes mode)
        {
            GameInstnace = instnace;
            LinkMode = mode;
        }

        public void Execute() 
        {
            GameInstnace.ActiveSprite = GameInstnace.LoadedSprites[(int) LinkMode];
        }
    }
}

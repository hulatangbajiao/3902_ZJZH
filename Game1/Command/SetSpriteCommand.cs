using static Game1.GlobalDefinitions;

namespace Game1.Command
{
    class SetSpriteCommand : ICommand
    {
        private SpriteModes SpriteMode;
        private MainStage GameInstnace;

        public SetSpriteCommand(MainStage instnace, SpriteModes mode)
        {
            GameInstnace = instnace;
            SpriteMode = mode;
        }

        public void Execute() 
        {
            GameInstnace.ActiveSprite = GameInstnace.LoadedSprites[(int) SpriteMode];
        }
    }
}

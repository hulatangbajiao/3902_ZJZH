namespace Game1
{
    public interface IOctState
    {
        ISprite GetSprite { get; set; }

        void MoveUp();
        void MoveDown();
        void MoveLeft();
        void MoveRight();
        void Update();
        void BreatheFire();
    }
}
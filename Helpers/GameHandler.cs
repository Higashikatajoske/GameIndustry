namespace GameIndustry.Helpers
{
    public class GameHandler
    {
        public RSPOptions Choose { get; set; }
        public RSPOptions WinCondition { get; set; }
        public RSPOptions LooseCondition { get; set; }
        public string? Image { get; set; }

        public GameState GameResult(GameHandler opponent)
        {
            if (Choose == opponent.Choose)
                return GameState.Draw;

            if (LooseCondition == opponent.Choose)
                return GameState.Loss;

            return GameState.Victory;
        }
    }
}

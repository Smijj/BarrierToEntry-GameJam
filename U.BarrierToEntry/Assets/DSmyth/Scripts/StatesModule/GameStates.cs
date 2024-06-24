using System;

namespace DSmyth.StatesModule
{
    public static class GameStates
    {
        public static Action OnGameOver;
        public static Action<int> OnHealthChanged;
        public static Action<int> OnScoreChanged;
    }
}

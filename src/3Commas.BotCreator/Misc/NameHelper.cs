namespace _3Commas.BotCreator.Misc
{
    public static class NameHelper
    {
        public static string GenerateBotName(string nameFormula, string symbol, string strategy)
        {
            return nameFormula
                .Replace("{pair}", symbol)
                .Replace("{strategy}", strategy);
        }
    }
}

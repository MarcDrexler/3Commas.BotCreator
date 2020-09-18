namespace _3Commas.BotCreator.Misc
{
    public class Logic
    {
        public int GetOrderVolume(in decimal value)
        {
            var factor = (value / 15000);

            if (factor < 1) factor = 1;

            return (int)(10 * factor);
        }

        public decimal GetSafetyOrderVolume(in decimal value)
        {
            return (int) (GetOrderVolume(value) * 1.1);
        }

        public static string GenerateBotName(string nameFormula, string symbol, string strategy)
        {
            return nameFormula
                .Replace("{pair}", symbol)
                .Replace("{strategy}", strategy);
        }
    }
}

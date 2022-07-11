namespace Personnummer.Formatters
{
    /// <summary>
    /// Formatter for short personnummer formats.
    /// YYMMDDNNNN
    /// </summary>
    public class ShortFormat : IFormatter
    {
        public static readonly IFormatter Instance = new ShortFormat();
        
        public string Format(Personnummer personnummer)
        {
            return $"{personnummer.Year}{personnummer.Month}{personnummer.Day}{personnummer.Numbers}";
        }
    }
}

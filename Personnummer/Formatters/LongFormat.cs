namespace Personnummer.Formatters
{
    /// <summary>
    /// Formatter for short personnummer formats.
    /// YYYYMMDDNNNN
    /// </summary>
    public class LongFormat : IFormatter
    {
        public static readonly IFormatter Instance = new LongFormat();
        
        public string Format(Personnummer personnummer)
        {
            return $"{personnummer.FullYear}{personnummer.Month}{personnummer.Day}{personnummer.Numbers}";
        }
    }
}

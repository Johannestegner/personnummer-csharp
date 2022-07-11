namespace Personnummer.Formatters
{
    /// <summary>
    /// Formatter for short personnummer formats.
    /// YYYYMMDD-/+NNNN
    /// </summary>
    public class LongSeparatedFormat : IFormatter
    {
        public static readonly IFormatter Instance = new LongSeparatedFormat();
        
        public string Format(Personnummer personnummer)
        {
            return $"{personnummer.FullYear}{personnummer.Month}{personnummer.Day}{personnummer.Separator}{personnummer.Numbers}";
        }
    }
}

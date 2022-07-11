namespace Personnummer.Formatters
{
    /// <summary>
    /// Formatter for short personnummer formats.
    /// YYMMDD-/+NNNN
    /// </summary>
    public class ShortSeparatedFormat : IFormatter
    {
        public static readonly IFormatter Instance = new ShortSeparatedFormat();
        
        public string Format(Personnummer personnummer)
        {
            return $"{personnummer.Year}{personnummer.Month}{personnummer.Day}{personnummer.Separator}{personnummer.Numbers}";
        }
    }
}

namespace Personnummer.Formatters
{
    /// <summary>
    /// Interface for classes used to format personnummer.
    /// </summary>
    public interface IFormatter
    {
        /// <summary>
        /// Format the personnummer.
        /// </summary>
        /// <param name="personnummer">Personnummer to format.</param>
        /// <returns>Formatted string value.</returns>
        public string Format(Personnummer personnummer);
    }
}

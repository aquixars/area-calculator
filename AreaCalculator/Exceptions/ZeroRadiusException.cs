namespace AreaCalculator.Exceptions
{
    /// <summary>
    /// Исключение, которое выбрасывается при некорректном значении радиуса круга.
    /// </summary>
    public class ZeroRadiusException : Exception
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ZeroRadiusException"/>.
        /// </summary>
        public ZeroRadiusException()
        {
        }
    }
}

namespace AreaCalculator.Exceptions
{
    /// <summary>
    /// Исключение, которое выбрасывается при некорректном размере сторон треугольника.
    /// </summary>
    public class InvalidSidesSizeException : Exception
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="InvalidSidesSizeException"/>.
        /// </summary>
        public InvalidSidesSizeException()
        {
        }
    }
}

namespace AreaCalculator.Exceptions
{
    /// <summary>
    /// Исключение, которое выбрасывается при некорректном значении стороны треугольника.
    /// </summary>
    public class InvalidSideException : Exception
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="InvalidSideException"/>.
        /// </summary>
        public InvalidSideException()
        {
        }
    }
}

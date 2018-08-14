using System.Collections.Generic;

namespace Patterns_05
{
    /// <summary>
    /// Класс получения объекта по типу
    /// </summary>
    class ObjectFactory
    {
        private static Dictionary<string, IDrawAPI> objects = new Dictionary<string, IDrawAPI>();

        /// <summary>
        /// Получение объекта по типу
        /// </summary>
        /// <param name="objectType">тип объекта</param>
        /// <returns>объект реализующий метод Draw</returns>
        public static IDrawAPI GetObject(string objectType)
        {
            switch (objectType)
            {
                case "Rectangle":
                    if (!objects.ContainsKey("Rectangle"))
                        objects["Rectangle"] = new RectangleObject();
                    return objects["Rectangle"];
                case "Cicle":
                    if (!objects.ContainsKey("Cicle"))
                        objects["Cicle"] = new CicleObject();
                    return objects["Cicle"];
                default:
                    break;
            }
            return null;
        }
    }
}

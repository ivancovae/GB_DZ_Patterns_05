using System.Collections.Generic;

namespace Patterns_05
{
    class RectangleFactory
    {
        static Dictionary<string, IDrawRectangleAPI> rectangles = new Dictionary<string, IDrawRectangleAPI>();

        public static IDrawRectangleAPI GetRectangle(string rectangleType)
        {
            switch (rectangleType)
            {
                case "Red":
                    if (!rectangles.ContainsKey("Red"))
                        rectangles["Red"] = new RedRectangle();
                    return rectangles["Red"];
                default:
                    break;
            }
            return null;
        }
    }
}

using System.Collections.Generic;

namespace Patterns_05
{
    class CicleFactory
    {
        static Dictionary<string, IDrawCicleAPI> cicles = new Dictionary<string, IDrawCicleAPI>();

        public static IDrawCicleAPI GetCicle(string cicleType)
        {
            switch (cicleType)
            {
                case "Blue":
                    if (!cicles.ContainsKey("Blue"))
                        cicles["Blue"] = new BlueCicle();
                    return cicles["Blue"];
                default:
                    break;
            }
            return null;
        }
    }
}

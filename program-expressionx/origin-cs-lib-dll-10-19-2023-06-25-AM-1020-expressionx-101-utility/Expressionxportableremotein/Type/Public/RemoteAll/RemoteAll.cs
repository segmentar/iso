using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableremotein
    {
        public static void RemoteAll(Expressionxportable value_EXPRESSIONXPORTABLE)
        {
            foreach (Expressionxportable expressionxportable in Expressionxportableset.ExpressionxportableAllSetSurface(value_EXPRESSIONXPORTABLE, true))
            {
                Remote(expressionxportable);

                continue;
            }

            return;
        }
    }
}

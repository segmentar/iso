using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static void SaveToSystem(Expressionxportable expressionxportable, String name, Expressionxportablesavecontext expressionxportablesavecontext)
        {
            Expressionxportablesave.SaveToSystem(expressionxportable, name, expressionxportablesavecontext);

            return;
        }
    }
}

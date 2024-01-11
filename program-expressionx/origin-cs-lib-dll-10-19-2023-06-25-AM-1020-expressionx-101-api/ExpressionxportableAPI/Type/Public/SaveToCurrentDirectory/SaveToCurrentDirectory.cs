using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static void SaveToCurrentDirectory(Expressionxportable expressionxportable, String name, Expressionxportablesavecontext expressionxportablesavecontext)
        {
            Expressionxportablesave.SaveToCurrentDirectory(expressionxportable, name, expressionxportablesavecontext);

            return;
        }
    }
}

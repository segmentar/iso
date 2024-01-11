using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static void SaveToSpace(Expressionxportable expressionxportable, Expressionxportablesavecontext expressionxportablesavecontext)
        {
            Expressionxportablesave.SaveToSpace(expressionxportable, expressionxportablesavecontext);

            return;
        }
    }
}

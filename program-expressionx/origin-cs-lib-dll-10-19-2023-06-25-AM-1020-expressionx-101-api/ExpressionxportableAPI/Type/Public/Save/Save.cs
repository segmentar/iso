using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static Object[] Save(Expressionxportable expressionxportable, String filename, Expressionxportablesavecontext expressionxportablesavecontext)
        {
            Object[] arrayResult = default;

            arrayResult = Expressionxportablesave.Save(expressionxportable, filename, expressionxportablesavecontext);

            return arrayResult;
        }
    }
}

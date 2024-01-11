using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static Expressionxportable ExecuteFull(Expressionxportable expressionxportable, String[] array)
        {
            Expressionxportable expressionxportableResult = default;

            expressionxportableResult = Expressionxportableexecute.ExecuteFull(expressionxportable, array);

            return expressionxportableResult;
        }
    }
}

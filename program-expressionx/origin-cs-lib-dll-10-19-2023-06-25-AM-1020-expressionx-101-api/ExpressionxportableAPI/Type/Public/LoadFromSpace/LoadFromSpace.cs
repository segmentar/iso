using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static Expressionxportable LoadFromSpace(Expressionxportableloadcontext expressionxportableloadcontext)
        {
            Expressionxportable expressionxportableResult = default;

            expressionxportableResult = Expressionxportableload.LoadFromSpace(expressionxportableloadcontext);

            return expressionxportableResult;
        }
    }
}

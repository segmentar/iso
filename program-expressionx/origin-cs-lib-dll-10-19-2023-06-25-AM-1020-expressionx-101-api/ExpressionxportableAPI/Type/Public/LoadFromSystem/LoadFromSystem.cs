using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static Expressionxportable LoadFromSystem(String fileName, Expressionxportableloadcontext expressionxportableloadcontext)
        {
            Expressionxportable expressionxportableResult = default;

            expressionxportableResult = Expressionxportableload.LoadFromSystem(fileName, expressionxportableloadcontext);

            return expressionxportableResult;
        }
    }
}

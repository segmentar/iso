using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static Expressionxportable LoadFromCurrentDirectory(String name, Expressionxportableloadcontext expressionxportableloadcontext)
        {
            Expressionxportable expressionxportableResult = default;

            expressionxportableResult = Expressionxportableload.LoadFromCurrentDirectory(name, expressionxportableloadcontext);

            return expressionxportableResult;
        }
    }
}

using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static Expressionxportable ExecuteProject(Expressionxportable expressionxportable, Boolean create)
        {
            Expressionxportable expressionxportableResult = default;

            expressionxportableResult = Expressionxportableexecute.ExecuteProject(expressionxportable, create);

            return expressionxportableResult;
        }
    }
}

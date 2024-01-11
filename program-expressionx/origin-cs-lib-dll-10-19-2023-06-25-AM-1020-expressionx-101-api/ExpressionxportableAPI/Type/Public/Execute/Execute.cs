using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static Expressionxportable Execute(Expressionxportable expressionxportable, String[] array, Expressionxportablesavecontext expressionxportablesavecontext, Expressionxportableloadcontext expressionxportableloadcontext)
        {
            Expressionxportable expressionxportableResult = default;

            expressionxportableResult = Expressionxportableexecute.Execute(expressionxportable, array, expressionxportablesavecontext, expressionxportableloadcontext);

            return expressionxportableResult;
        }
    }
}

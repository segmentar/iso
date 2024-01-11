using Core;

namespace Core
{
    using System;

    public partial class Expressionxportable
    {
        public static Expressionxportable[] ExpressionTemplateSetSurface(Expressionxportable[] array_EXPRESSION)
        {
            Expressionxportable[] arrayResult = default;

            var list = ExpressionTemplateSet(array_EXPRESSION);

            var array = new Expressionxportable[list.Count];

            list.CopyTo(array, ExpressionPolicy.ExpressionIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}

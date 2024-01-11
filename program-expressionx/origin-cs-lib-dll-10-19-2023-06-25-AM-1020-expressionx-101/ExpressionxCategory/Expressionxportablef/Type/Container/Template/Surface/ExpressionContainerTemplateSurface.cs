using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    public partial class Expressionxportable
    {
        public static T[] ExpressionTemplateContainerSurface<T>(Expressionxportable[] array_EXPRESSION)
        {
            T[] arrayResult = default;
            
            var list = ExpressionTemplateContainer(array_EXPRESSION);

            IEnumerable enumerable;

            enumerable = list.OfType<T>().Cast<T>().ToArray<T>();

            var reflect = (T[])(enumerable as Array);

            var result = reflect;

            arrayResult = result;

            return arrayResult;
        }
    }
}

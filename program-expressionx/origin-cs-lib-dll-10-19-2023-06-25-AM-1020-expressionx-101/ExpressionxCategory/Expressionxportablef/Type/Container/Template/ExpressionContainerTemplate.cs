using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expressionxportable
    {
        public static ICollection ExpressionTemplateContainer(Expressionxportable[] array_EXPRESSION)
        {
            IList listResult = default;

            listResult = new ArrayList();

            foreach (Expressionxportable value_EXPRESSION in array_EXPRESSION)
            {
                Expressionxportable expression;

                expression = new ExpressionSimple(value_EXPRESSION.StringIdentity.StringValue, value_EXPRESSION.ObjectIdentity).Result;

                Tuple<Expressionxportable, Expressionxportable> tuple;

                tuple = new Tuple<Expressionxportable, Expressionxportable>(value_EXPRESSION, expression);

                listResult.Add(tuple);

                continue;
            }

            return listResult;
        }
    }
}

using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XSingle
        {
            public static IList<ExpressionxportablebuildX_evelY> FunctionDefaultSet(Expressionxportable[] array_EXPRESSIONXPORTABLE)
            {
                ICollection<ExpressionxportablebuildX_evelY> collectionResult = default;

                collectionResult = new List<ExpressionxportablebuildX_evelY>();

                var ordinal = 1;

                foreach (Expressionxportable value_EXPRESSION in array_EXPRESSIONXPORTABLE)
                {
                    var type = (((value_EXPRESSION.ObjectIdentity == default) || Attribute.IsDefined(value_EXPRESSION.ObjectIdentity.GetType(), typeof(SerializableAttribute)) is false) ? String.Empty : value_EXPRESSION.ObjectIdentity.GetType().ToString());

                    ExpressionxportablebuildX_evelY level;

                    level = new ExpressionxportablebuildX_evelY();

                    level.Type = type;

                    level.Expression = value_EXPRESSION;

                    collectionResult.Add(level);

                    ordinal = ordinal + 1;

                    continue;
                }

                return new List<ExpressionxportablebuildX_evelY>(collectionResult);
            }
        }
    }
}

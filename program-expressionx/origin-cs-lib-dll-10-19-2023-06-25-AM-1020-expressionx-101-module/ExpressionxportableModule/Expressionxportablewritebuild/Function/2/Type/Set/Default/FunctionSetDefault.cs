using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XDouble
        {
            public static IList<ExpressionxportablebuildXl_velY> FunctionDefaultSet(ExpressionxportablebuildX_evelY[] Level_ARRAY)
            {
                ICollection<ExpressionxportablebuildXl_velY> collectionResult = default;

                collectionResult = new Collection<ExpressionxportablebuildXl_velY>();

                var ordinal = 1;

                foreach (ExpressionxportablebuildX_evelY Level_VALUE in Level_ARRAY)
                {
                    ExpressionxportablebuildXl_velY level;

                    level = new ExpressionxportablebuildXl_velY();

                    level.Type = Level_VALUE.Type;

                    level.Ordinal = ordinal;

                    level.Expression = Level_VALUE.Expression;

                    collectionResult.Add(level);

                    ordinal = ordinal + 1;

                    continue;
                }

                return new List<ExpressionxportablebuildXl_velY>(collectionResult);
            }
        }
    }
}

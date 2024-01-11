using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XQuintuple
        {
            public static ExpressionxportablebuildXleve_Y[] FunctionDefaultSetSurface(ExpressionxportablebuildXlev_lY[] Level_ARRAY, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT)
            {
                ExpressionxportablebuildXleve_Y[] arrayResult = default;

                var list = FunctionDefaultSet(Level_ARRAY, value_EXPRESSIONXPORTABLELAYOUT);

                var array = new ExpressionxportablebuildXleve_Y[list.Count];

                list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}

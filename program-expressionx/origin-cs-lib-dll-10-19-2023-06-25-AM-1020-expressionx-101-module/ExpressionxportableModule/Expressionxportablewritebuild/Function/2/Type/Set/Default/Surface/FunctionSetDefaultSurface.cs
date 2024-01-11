using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XDouble
        {
            public static ExpressionxportablebuildXl_velY[] FunctionDefaultSetSurface(ExpressionxportablebuildX_evelY[] Level_ARRAY)
            {
                ExpressionxportablebuildXl_velY[] arrayResult = default;

                var list = FunctionDefaultSet(Level_ARRAY);

                var array = new ExpressionxportablebuildXl_velY[list.Count];

                list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}

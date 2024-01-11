using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XQuadruple
        {
            public static ExpressionxportablebuildXlev_lY[] FunctionDefaultSetSurface(ExpressionxportablebuildXle_elY[] LeveL_ARRAY)
            {
                ExpressionxportablebuildXlev_lY[] arrayResult = default;

                var list = FunctionDefaultSet(LeveL_ARRAY);

                var array = new ExpressionxportablebuildXlev_lY[list.Count];

                list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

                arrayResult = array;    

                return arrayResult;
            }
        }
    }
}

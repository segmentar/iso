using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XSextuple
        {
            public static ExpressionxportablebuildU_evelV[] FunctionDefaultSetSurface(ExpressionxportablebuildXleve_Y[] Level_ARRAY)
            {
                ExpressionxportablebuildU_evelV[] arrayResult = default;

                var list = FunctionXlev__YSet(Level_ARRAY);

                var array = new ExpressionxportablebuildU_evelV[list.Count];

                list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}

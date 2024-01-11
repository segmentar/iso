using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablereadModule
    {
        public static ExpressionxportablebuildUlev_lV[] FunctionDefaultSetSurface(ExpressionxportablebuildUle_elV[] Level_ARRAY)
        {
            ExpressionxportablebuildUlev_lV[] arrayResult = default;

            var list = FunctionDefaultSet(Level_ARRAY);

            var array = new ExpressionxportablebuildUlev_lV[list.Count];

            list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}

using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XOctuple
        {
            public static ExpressionxportablebuildUle_elV[] FunctionDefaultSetSurface(ExpressionxportablebuildUl_velV[] Level_ARRAY)
            {
                ExpressionxportablebuildUle_elV[] arrayResult = default;

                var list = FunctionDefaultSet(Level_ARRAY);

                var array = new ExpressionxportablebuildUle_elV[list.Count];

                list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}

using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XSentuple
        {
            public static ExpressionxportablebuildUl_velV[] FunctionDefaultSetSurface(ExpressionxportablebuildU_evelV[] Level_ARRAY)
            {
                ExpressionxportablebuildUl_velV[] arrayResult = default;

                var list = FunctionDefaultSet(Level_ARRAY);

                var array = new ExpressionxportablebuildUl_velV[list.Count];

                list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}

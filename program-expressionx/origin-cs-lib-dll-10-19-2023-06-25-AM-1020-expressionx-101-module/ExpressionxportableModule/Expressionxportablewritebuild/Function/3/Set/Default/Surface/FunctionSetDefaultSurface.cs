using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XTriple
        {
            public static ExpressionxportablebuildXle_elY[] FunctionDefaultSetSurface(ExpressionxportablebuildXl_velY[] Level_ARRAY, Expressionxportable[] array_EXPRESSIONXPORTABLE)
            {
                ExpressionxportablebuildXle_elY[] arrayResult = default;
                
                var list = FunctionDefaultSet(Level_ARRAY, array_EXPRESSIONXPORTABLE);

                var array = new ExpressionxportablebuildXle_elY[list.Count];

                list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}

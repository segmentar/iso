using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XSingle
        {
            public static ExpressionxportablebuildX_evelY[] FunctionDefaultSetSurface(Expressionxportable[] array_EXPRESSIONXPORTABLE)
            {
                ExpressionxportablebuildX_evelY[] arrayResult = default;
                
                var list = FunctionDefaultSet(array_EXPRESSIONXPORTABLE);

                var array = new ExpressionxportablebuildX_evelY[list.Count];

                list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}

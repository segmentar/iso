using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XQuintuple
        {
            public static XQuintuple ForgeLevel(ExpressionxportablebuildXlev_lY[] Level_ARRAY, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT)
            {
                XQuintuple xquintupleResult = default;

                var array = FunctionDefaultSetSurface(Level_ARRAY, value_EXPRESSIONXPORTABLELAYOUT);

                XQuintuple xquintuple;

                xquintuple = new XQuintuple(array);

                xquintupleResult = xquintuple;

                return xquintupleResult;
            }
        }
    }
}

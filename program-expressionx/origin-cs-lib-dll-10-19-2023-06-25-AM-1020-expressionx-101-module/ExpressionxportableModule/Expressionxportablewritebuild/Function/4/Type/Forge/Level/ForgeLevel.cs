using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XQuadruple
        {
            public static XQuadruple ForgeLevel(ExpressionxportablebuildXle_elY[] Level_ARRAY)
            {
                XQuadruple xquadrupleResult = default;

                var array = FunctionDefaultSetSurface(Level_ARRAY);

                XQuadruple xquadruple;

                xquadruple = new XQuadruple(array);

                xquadrupleResult = xquadruple;

                return xquadrupleResult;
            }
        }
    }
}

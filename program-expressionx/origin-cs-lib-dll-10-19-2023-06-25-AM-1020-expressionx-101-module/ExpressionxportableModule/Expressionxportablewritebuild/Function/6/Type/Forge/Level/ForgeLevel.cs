using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XSextuple
        {
            public static XSextuple ForgeLevel(ExpressionxportablebuildXleve_Y[] Level_ARRAY)
            {
                XSextuple xsextupleResult = default;

                var array = FunctionDefaultSetSurface(Level_ARRAY);

                XSextuple xsextuple;

                xsextuple = new XSextuple(array);

                xsextupleResult = xsextuple;

                return xsextupleResult;
            }
        }
    }
}

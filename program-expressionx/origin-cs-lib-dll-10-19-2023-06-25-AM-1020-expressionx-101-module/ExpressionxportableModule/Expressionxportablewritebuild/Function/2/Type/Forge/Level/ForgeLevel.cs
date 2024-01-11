using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XDouble
        {
            public static XDouble ForgeLevel(ExpressionxportablebuildX_evelY[] Level_ARRAY)
            {
                XDouble xdoubleResult = default;

                var array = FunctionDefaultSetSurface(Level_ARRAY);

                XDouble xdouble;

                xdouble = new XDouble(array);

                xdoubleResult = xdouble;

                return xdoubleResult;
            }
        }
    }
}

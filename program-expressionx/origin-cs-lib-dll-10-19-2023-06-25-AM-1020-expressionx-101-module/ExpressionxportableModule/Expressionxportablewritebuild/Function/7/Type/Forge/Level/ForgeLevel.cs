using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XSentuple
        {
            public static XSentuple ForgeLevel(ExpressionxportablebuildU_evelV[] Level_ARRAY)
            {
                XSentuple xsentupleResult = default;

                var array = FunctionDefaultSetSurface(Level_ARRAY);

                XSentuple xsentuple;

                xsentuple = new XSentuple(array);

                xsentupleResult = xsentuple;

                return xsentupleResult;
            }
        }
    }
}

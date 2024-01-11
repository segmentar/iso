using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablereadModule
    {
        public partial class XQuintuple
        {
            public static XQuintuple ForgeLevel(ExpressionxportablebuildUlev_lV[] Level_ARRAY)
            {
                XQuintuple xquintupleResult = default;

                var result = ForgeRoot(Level_ARRAY);

                XQuintuple xquintuple;

                xquintuple = new XQuintuple(result);

                xquintupleResult = xquintuple;

                return xquintupleResult;
            }
        }
    }
}

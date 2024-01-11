using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablereadModule
    {
        public partial class XQuadruple
        {
            public static void FunctionDefaultVoid(ExpressionxportablebuildUlev_lV[] Level_ARRAY)
            {
                foreach (ExpressionxportablebuildUlev_lV Level_ITEM in Level_ARRAY)
                {
                    foreach (ExpressionxportablebuildUlev_lV Level_ENTRY in Level_ARRAY)
                    {
                        Boolean isEqualCheck, shouldContinueCheck;

                        isEqualCheck = Object.Equals(Level_ITEM.Ordinal, Level_ENTRY.Relation) is true;

                        shouldContinueCheck = isEqualCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        var list = Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(Level_ITEM.Expression.LayerArrayListObject);

                        list.Add(Level_ENTRY.Expression);

                        continue;
                    }

                    continue;
                }

                return;
            }
        }
    }
}

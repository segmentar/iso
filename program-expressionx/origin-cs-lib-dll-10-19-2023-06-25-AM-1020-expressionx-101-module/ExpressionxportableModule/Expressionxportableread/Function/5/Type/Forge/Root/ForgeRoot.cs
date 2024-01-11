using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablereadModule 
    {
        public static ExpressionxportablebuildUlev_lV ForgeRoot(ExpressionxportablebuildUlev_lV[] Level_ARRAY)
        {
            ExpressionxportablebuildUlev_lV levelResult = default;

            foreach (ExpressionxportablebuildUlev_lV Level_VALUE in Level_ARRAY)
            {
                Boolean isEqualCheck, shouldContinueCheck;

                isEqualCheck = Object.Equals(Level_VALUE.Relation, 0) is true;

                shouldContinueCheck = isEqualCheck is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                levelResult = Level_VALUE;

                break;
            }

            return levelResult;
        }
    }
}

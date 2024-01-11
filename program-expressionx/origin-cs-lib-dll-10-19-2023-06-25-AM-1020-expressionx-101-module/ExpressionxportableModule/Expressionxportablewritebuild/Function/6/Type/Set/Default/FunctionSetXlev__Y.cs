using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XSextuple
        {
            public static IList<ExpressionxportablebuildU_evelV> FunctionXlev__YSet(ExpressionxportablebuildXleve_Y[] Level_ARRAY)
            {
                ICollection<ExpressionxportablebuildU_evelV> collectionResult = default;

                collectionResult = new List<ExpressionxportablebuildU_evelV>();

                foreach (ExpressionxportablebuildXleve_Y Level_VALUE in Level_ARRAY)
                {
                    ExpressionxportablebuildU_evelV level;

                    level = new ExpressionxportablebuildU_evelV();

                    level.Type = Level_VALUE.Type;

                    level.Ordinal = Level_VALUE.Ordinal;

                    level.Layer = Level_VALUE.Layer;

                    level.Relation = Level_VALUE.Relation;

                    level.ObjectStartAddress = Level_VALUE.ObjectStartAddress;

                    level.ObjectEndAddress = Level_VALUE.ObjectEndAddress;

                    level.TypeStartAddress = Level_VALUE.TypeStartAddress;

                    level.TypeEndAddress = Level_VALUE.TypeEndAddress;

                    level.Value = ((Expressionxportablestringsafe)Level_VALUE.Expression.StringIdentity).Value;

                    level.Expression = Level_VALUE.Expression;

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ExpressionxportablebuildU_evelV>(collectionResult);
            }
        }
    }
}

using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XSentuple
        {
            public static IList<ExpressionxportablebuildUl_velV> FunctionDefaultSet(ExpressionxportablebuildU_evelV[] Level_ARRAY)
            {
                ICollection<ExpressionxportablebuildUl_velV> collectionResult = default;

                collectionResult = new List<ExpressionxportablebuildUl_velV>();

                foreach (ExpressionxportablebuildU_evelV Level_VALUE in Level_ARRAY)
                {
                    ExpressionxportablebuildUl_velV level;

                    level = new ExpressionxportablebuildUl_velV();

                    level.Type = Level_VALUE.Type;

                    level.Ordinal = Level_VALUE.Ordinal;

                    level.Layer = Level_VALUE.Layer;

                    level.Relation = Level_VALUE.Relation;

                    level.ObjectStartAddress = Level_VALUE.ObjectStartAddress;

                    level.ObjectEndAddress = Level_VALUE.ObjectEndAddress;

                    level.TypeStartAddress = Level_VALUE.TypeStartAddress;

                    level.TypeEndAddress = Level_VALUE.TypeEndAddress;

                    level.Value = Level_VALUE.Value;

                    level.Expression = Level_VALUE.Expression;

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ExpressionxportablebuildUl_velV>(collectionResult);
            }
        }
    }
}

using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XOctuple
        {
            public static IList<ExpressionxportablebuildUle_elV> FunctionDefaultSet(ExpressionxportablebuildUl_velV[] Level_ARRAY)
            {
                ICollection<ExpressionxportablebuildUle_elV> collectionResult = default;

                collectionResult = new List<ExpressionxportablebuildUle_elV>();

                foreach (ExpressionxportablebuildUl_velV Level_VALUE in Level_ARRAY)
                {
                    ExpressionxportablebuildUle_elV level;

                    level = new ExpressionxportablebuildUle_elV();

                    level.Type = Level_VALUE.Type;

                    level.Ordinal = Level_VALUE.Ordinal;

                    level.Layer = Level_VALUE.Layer;

                    level.Relation = Level_VALUE.Relation;

                    level.ObjectStartAddress = Level_VALUE.ObjectStartAddress;

                    level.ObjectEndAddress = Level_VALUE.ObjectEndAddress;

                    level.TypeStartAddress = Level_VALUE.TypeStartAddress;

                    level.TypeEndAddress = Level_VALUE.TypeEndAddress;

                    level.Value = Level_VALUE.Value;

                    level.RemoteArray = (Byte[])Level_VALUE.Expression.RemoteArrayObject;

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ExpressionxportablebuildUle_elV>(collectionResult);
            }
        }
    }
}

using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ExpressionxportablereadModule
    {
        public static IList<ExpressionxportablebuildUlev_lV> FunctionDefaultSet(ExpressionxportablebuildUle_elV[] LeveL_ARRAY)
        {
            ICollection<ExpressionxportablebuildUlev_lV> collectionResult = default;

            collectionResult = new Collection<ExpressionxportablebuildUlev_lV>();

            foreach (ExpressionxportablebuildUle_elV Level_VALUE in LeveL_ARRAY)
            {
                var result = Expressionxportableremoteout.Remote(Level_VALUE.RemoteArray, Level_VALUE.Type);

                Expressionxportable expression;

                expression = new ExpressionxportableSimple(Level_VALUE.Value, result).Result;

                ExpressionxportablebuildUlev_lV level;

                level = new ExpressionxportablebuildUlev_lV();

                level.Type = Level_VALUE.Type;

                level.Ordinal = Level_VALUE.Ordinal;

                level.Layer = Level_VALUE.Layer;

                level.Relation = Level_VALUE.Relation;

                level.ObjectStartAddress = Level_VALUE.ObjectStartAddress;

                level.ObjectEndAddress = Level_VALUE.ObjectEndAddress;

                level.TypeStartAddress = Level_VALUE.TypeStartAddress;

                level.TypeEndAddress = Level_VALUE.TypeEndAddress;

                level.Value = Level_VALUE.Value;

                level.RemoteArray = Level_VALUE.RemoteArray;

                level.Expression = expression;

                collectionResult.Add(level);

                continue;
            }

            return new List<ExpressionxportablebuildUlev_lV>(collectionResult);
        }
    }
}

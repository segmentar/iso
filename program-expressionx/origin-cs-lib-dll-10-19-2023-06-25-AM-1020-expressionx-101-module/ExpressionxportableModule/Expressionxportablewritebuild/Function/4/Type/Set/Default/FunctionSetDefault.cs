using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XQuadruple
        {
            public static IList<ExpressionxportablebuildXlev_lY> FunctionDefaultSet(ExpressionxportablebuildXle_elY[] LeveL_ARRAY)
            {
                ICollection<ExpressionxportablebuildXlev_lY> collectionResult = default;

                collectionResult = new Collection<ExpressionxportablebuildXlev_lY>();

                foreach (ExpressionxportablebuildXle_elY Level_ITEM in LeveL_ARRAY)
                {
                    var relation = 0;

                    foreach (ExpressionxportablebuildXle_elY LevelLevel_ENTRY in LeveL_ARRAY)
                    {
                        var list = Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(LevelLevel_ENTRY.Expression.LayerArrayListObject);

                        if (list.Contains(Level_ITEM.Expression) is false)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        relation = LevelLevel_ENTRY.Ordinal;

                        break;
                    }

                    ExpressionxportablebuildXlev_lY level;

                    level = new ExpressionxportablebuildXlev_lY();

                    level.Type = Level_ITEM.Type;

                    level.Ordinal = Level_ITEM.Ordinal;

                    level.Layer = Level_ITEM.Layer;

                    level.Relation = relation;

                    level.Expression = Level_ITEM.Expression;

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ExpressionxportablebuildXlev_lY>(collectionResult);
            }
        }
    }
}

using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XQuintuple
        {
            public static IList<ExpressionxportablebuildXleve_Y> FunctionDefaultSet(ExpressionxportablebuildXlev_lY[] Level_ARRAY, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT)
            {
                ICollection<ExpressionxportablebuildXleve_Y> collectionResult = default;

                collectionResult = new List<ExpressionxportablebuildXleve_Y>();

                var index = value_EXPRESSIONXPORTABLELAYOUT.StartAddressObjectTable;

                foreach (ExpressionxportablebuildXlev_lY Level_VALUE in Level_ARRAY)
                {
                    ExpressionxportablebuildXleve_Y level;

                    level = new ExpressionxportablebuildXleve_Y();

                    level.Type = Level_VALUE.Type;

                    level.Ordinal = Level_VALUE.Ordinal;

                    level.Layer = Level_VALUE.Layer;

                    level.Relation = Level_VALUE.Relation;

                    level.ObjectStartAddress = level.ObjectStartAddress + index;

                    level.ObjectEndAddress = level.ObjectEndAddress + index;

                    level.ObjectEndAddress = level.ObjectEndAddress + ((Byte[])Level_VALUE.Expression.RemoteArrayObject).Length;

                    level.ObjectEndAddress = level.ObjectEndAddress - 1;

                    level.TypeStartAddress = level.TypeStartAddress + level.ObjectStartAddress;

                    level.TypeStartAddress = level.TypeStartAddress + ((Byte[])Level_VALUE.Expression.RemoteArrayObject).Length;

                    level.TypeEndAddress = level.TypeEndAddress + level.ObjectStartAddress;

                    level.TypeEndAddress = level.TypeEndAddress + ((Byte[])Level_VALUE.Expression.RemoteArrayObject).Length;

                    level.TypeEndAddress = level.TypeEndAddress + Level_VALUE.Type.Length;

                    level.TypeEndAddress = level.TypeEndAddress - 1;

                    level.Expression = Level_VALUE.Expression;

                    collectionResult.Add(level);

                    index = index + ((Byte[])Level_VALUE.Expression.RemoteArrayObject).Length;

                    index = index + level.Type.Length;

                    continue;
                }

                return new List<ExpressionxportablebuildXleve_Y>(collectionResult);
            }
        }
    }
}

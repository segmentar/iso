using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XTriple
        {
            public static IList<ExpressionxportablebuildXle_elY> FunctionDefaultSet(ExpressionxportablebuildXl_velY[] Level_ARRAY, Expressionxportable[] array_EXPRESSIONXPORTABLE)
            {
                ICollection<ExpressionxportablebuildXle_elY> collectionResult = default;

                collectionResult = new List<ExpressionxportablebuildXle_elY>();

                var inflect = new Object[2];

                inflect[0] = new ArrayList(array_EXPRESSIONXPORTABLE);

                inflect[1] = new ArrayList(new ExpressionxportablebuildXl_velY[] { Level_ARRAY[0] });

                var layer = 1;

                do
                {
                    Boolean shouldBreakCheck;

                    shouldBreakCheck = Object.Equals(Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(inflect[0]).Count, 0) is true;

                    if (shouldBreakCheck is true)
                    {
                        break;
                    }
                    else
                        "false".ToString();

                    var list = Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(inflect[1]);

                    list = Expressionxportablemagic.ExpressionxportablemagicArrayListDispenser(list);

                    foreach (ExpressionxportablebuildXl_velY value_LEVEL in list)
                    {
                        Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(inflect[0]).Remove(value_LEVEL.Expression);

                        ExpressionxportablebuildXle_elY level;

                        level = new ExpressionxportablebuildXle_elY();

                        level.Type = value_LEVEL.Type;

                        level.Ordinal = value_LEVEL.Ordinal;

                        level.Layer = layer;

                        level.Expression = value_LEVEL.Expression;

                        collectionResult.Add(level);

                        continue;
                    }

                    Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(inflect[1]).Clear();

                    foreach (ExpressionxportablebuildXl_velY item_LEVEL in list)
                    {
                        var reflect = (Expressionxportable[])(Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(item_LEVEL.Expression.LayerArrayListObject).ToArray(typeof(Expressionxportable)) as Expressionxportable[]);

                        foreach (Expressionxportable expression in reflect)
                        {
                            foreach (ExpressionxportablebuildXl_velY entry_LEVEL in Level_ARRAY)
                            {
                                Boolean isReferenceCheck, shouldContinueCheck;

                                isReferenceCheck = Object.ReferenceEquals(expression, entry_LEVEL.Expression) is true;

                                shouldContinueCheck = isReferenceCheck is false;

                                if (shouldContinueCheck is true)
                                {
                                    continue;
                                }
                                else
                                    "false".ToString();

                                Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(inflect[1]).Add(entry_LEVEL);

                                continue;
                            }

                            continue;
                        }

                        continue;
                    }

                    layer = layer + 1;

                    continue;

                } while (true);

                return new List<ExpressionxportablebuildXle_elY>(collectionResult);
            }
        }
    }
}

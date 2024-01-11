using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Expressionxportable
    {
        public static IList<Expressionxportable> ExpressionTemplateSet(Expressionxportable[] array_EXPRESSION)
        {
            ICollection<Expressionxportable> collectionResult = default;

            collectionResult = new Collection<Expressionxportable>();

            try
            {
                var array = ExpressionTemplateContainerSurface<Tuple<Expressionxportable, Expressionxportable>>(array_EXPRESSION);

                foreach (Tuple<Expressionxportable, Expressionxportable> value in array)
                {
                    collectionResult.Add(value.Item2);

                    continue;
                }

                foreach (Tuple<Expressionxportable, Expressionxportable> item in array)
                {
                    foreach (Tuple<Expressionxportable, Expressionxportable> entry in array)
                    {
                        var list = Interop.InteropArrayListCastDispenser(item.Item1.LayerArrayListObject);

                        if (list.Contains(entry.Item1) is true)
                        { 
                            Interop.InteropArrayListCastDispenser(item.Item2.LayerArrayListObject).Add(entry.Item2);
                        }
                        else
                            "false".ToString();

                        continue;
                    }

                    continue;
                }
            }
            catch (Exception exception)
            {
                Interop.Render($"{ExpressionCode.RenderPath.Core_Expression_Fatal}", new Expressionfatal.Template().Initialize(new String[0], exception));
            }

            return new List<Expressionxportable>(collectionResult);
        }
    }
}

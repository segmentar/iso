using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Expressionxportableset
    {
        public static IList<Expressionxportable> ExpressionxportableAllSet(Expressionxportable value_EXPRESSIONXPORTABLE, Boolean answer_SELF_should)
        {
            ICollection<Expressionxportable> collectionResult = default;

            collectionResult = new Collection<Expressionxportable>();

            if (answer_SELF_should is true)
            {
                collectionResult.Add(value_EXPRESSIONXPORTABLE);
            }
            else
                "false".ToString();

            try
            {
                var list = Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(value_EXPRESSIONXPORTABLE.LayerArrayListObject);

                foreach (Expressionxportable item in Expressionxportablemagic.ExpressionxportablemagicArrayListDispenser(list))
                {
                    var array = ExpressionxportableAllSetSurface(item, answer_SELF_should);

                    foreach (Expressionxportable entry in array)
                    {
                        collectionResult.Add(entry);

                        continue;
                    }

                    continue;
                }

            } catch (Exception exception)
            {
                Expressionxportablerender.Render($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.All().Initialize(new String[0], exception));
            }

            return new List<Expressionxportable>(collectionResult);
        }
    }
}

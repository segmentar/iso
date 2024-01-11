using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void BindInt32(Expression value_EXPRESSION, Object item_OBJECT)
        {
            String stringItem;

            stringItem = item_OBJECT.ToString();

            var parse = Int32.Parse(stringItem);

            Bind(value_EXPRESSION, parse);

            return;
        }
    }
}

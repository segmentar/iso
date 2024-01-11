using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void IBind(Expression value_EXPRESSION, Object Bind_Object)
        {
            var list = Interop.InteropLinkedListCastDispenser(Expression.ViewLinkedListObject);

            var reflect = (Expression)(list.Last.Value as Object);

            reflect.ObjectIdentity = Bind_Object;

            return;
        }
    }
}

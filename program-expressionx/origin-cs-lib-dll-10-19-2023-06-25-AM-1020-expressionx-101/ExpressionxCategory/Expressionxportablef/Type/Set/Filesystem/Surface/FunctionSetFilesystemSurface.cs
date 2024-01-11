namespace Core
{
    using System;

    public partial class Expressionxportable
    {
        public static Object[] FunctionSetFilesystemSurface(Expressionxportable value_EXPRESSION, String LastName__VALUE, Boolean answer_SELF_should)
        {
            Object[] arrayResult = default;

            var list = FunctionSetFilesystem(value_EXPRESSION, LastName__VALUE, answer_SELF_should);

            var array = new Object[list.Count];

            list.CopyTo(array, ExpressionPolicy.ExpressionIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}

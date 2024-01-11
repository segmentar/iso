using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static Object[] Load(String filename, Expressionxportableloadcontext expressionxportableloadcontext)
        {
            Object[] arrayResult = default;

            arrayResult = Expressionxportableload.Load(filename, expressionxportableloadcontext);

            return arrayResult;
        }
    }
}

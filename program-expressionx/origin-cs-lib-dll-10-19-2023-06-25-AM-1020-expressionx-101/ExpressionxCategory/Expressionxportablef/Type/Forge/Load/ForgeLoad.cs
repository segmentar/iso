using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expressionxportable
    {
        public static Object[] ForgeLoad(String Path_VALUE, Boolean answer_DESTROY_should)
        {
            Object[] arrayResult = default;

            ExpressionreadModule expressionreadModule = ExpressionreadModule.Action(Path_VALUE);

            Expressionreadclose expressionreadclose;

            expressionreadclose = new Expressionreadclose();

            expressionreadclose.FileStreamClose = true;

            expressionreadclose.MemoryStreamCoreClose = true;

            ExpressionreadfileModule expressionreadfileModule = ExpressionreadfileModule.Action(expressionreadclose);

            if (answer_DESTROY_should is true)
            {
                File.Delete(Path_VALUE);
            }
            else
                "false".ToString();

            var inflect = new Object[2];

            inflect[0] = expressionreadModule;

            inflect[1] = expressionreadfileModule;

            arrayResult = inflect;

            return arrayResult;
        }
    }
}

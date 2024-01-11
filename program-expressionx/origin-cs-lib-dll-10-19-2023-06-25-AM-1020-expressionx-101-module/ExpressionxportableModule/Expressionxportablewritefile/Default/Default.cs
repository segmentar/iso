using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class ExpressionxportablewritefileModule
    {
        public static ExpressionxportablewritefileModule Default(String Filename_VALUE, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT, Expressionxportablewriteclose value_EXPRESSIONXPORTABLEWRITECLOSE, MemoryStream[] array_MEMORYSTREAM, Byte[][] jagged_BYTE)
        {
            ExpressionxportablewritefileModule module;

            module = new ExpressionxportablewritefileModule();

            var inflect = new Object[5];

            inflect[0] = Filename_VALUE;

            inflect[1] = value_EXPRESSIONXPORTABLELAYOUT;

            inflect[2] = value_EXPRESSIONXPORTABLEWRITECLOSE;

            inflect[3] = array_MEMORYSTREAM;

            inflect[4] = jagged_BYTE;

            ExpressionxportablewritefileCycle.XZeroth = new XZeroth(inflect);

            module = module.XOne(module);

            XZeroth.FunctionDefaultVoid(value_EXPRESSIONXPORTABLEWRITECLOSE, array_MEMORYSTREAM);

            return module;
        }
    }
}

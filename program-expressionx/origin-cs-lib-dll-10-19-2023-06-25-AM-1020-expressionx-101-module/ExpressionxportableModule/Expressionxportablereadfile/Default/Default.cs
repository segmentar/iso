using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class ExpressionxportablereadfileModule
    {
        public static ExpressionxportablereadfileModule Default(Expressionxportablereadclose value_EXPRESSIONXPORTABLEREADCLOSE, FileStream value_FILESTREAM, MemoryStream value_MEMORYSTREAM)
        {
            ExpressionxportablereadfileModule module;

            module = new ExpressionxportablereadfileModule();

            var inflect = new Object[3];

            inflect[0] = value_EXPRESSIONXPORTABLEREADCLOSE;

            inflect[1] = value_FILESTREAM;

            inflect[2] = value_MEMORYSTREAM;

            ExpressionxportablereadfileCycle.XZeroth = new XZeroth(inflect);

            XZeroth.FunctionDefaultVoid(value_EXPRESSIONXPORTABLEREADCLOSE, value_FILESTREAM, value_MEMORYSTREAM);

            return module;
        }
    }
}

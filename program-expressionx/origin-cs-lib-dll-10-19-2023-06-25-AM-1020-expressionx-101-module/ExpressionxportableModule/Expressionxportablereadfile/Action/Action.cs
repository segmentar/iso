using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class ExpressionxportablereadfileModule
    {
        public static ExpressionxportablereadfileModule Action(Expressionxportablereadclose value_EXPRESSIONXPORTABLEREADCLOSE, FileStream value_FILESTREAM, MemoryStream value_MEMORYSTREAM)
        {
            ExpressionxportablereadfileModule module;

            module = Default(value_EXPRESSIONXPORTABLEREADCLOSE, value_FILESTREAM, value_MEMORYSTREAM);

            if (ExpressionxportablePolicy.ExpressionxportablereadfilePolicy is true)
            {
                try
                {
                    Expressionxportablerender.Render($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablereadfileModule)}-0", ExpressionxportablereadfileCycle.XZeroth);
                }
                catch (Exception exception)
                {
                    Expressionxportablerender.Render($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Fatal}", exception);
                }
            }
            else
                "false".ToString();

            return module;
        }
    }
}

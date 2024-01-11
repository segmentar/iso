using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class ExpressionxportablewritefileModule
    {
        public static ExpressionxportablewritefileModule Action(String Filename_VALUE, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT, Expressionxportablewriteclose value_EXPRESSIONXPORTABLEWRITECLOSE, MemoryStream[] array_MEMORYSTREAM, Byte[][] jagged_ARRAY)
        {
            ExpressionxportablewritefileModule module;

            module = Default(Filename_VALUE, value_EXPRESSIONXPORTABLELAYOUT, value_EXPRESSIONXPORTABLEWRITECLOSE, array_MEMORYSTREAM, jagged_ARRAY);

            if (ExpressionxportablePolicy.ExpressionxportablewritefilePolicy is true)
            {
                try
                {
                    Expressionxportablerender.Render($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablewritefileModule)}-0", ExpressionxportablewritefileCycle.XZeroth);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablewritefileModule)}-1", ExpressionxportablewritefileCycle.XPrimary.XSingle);
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

using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewriteModule
    {
        public static ExpressionxportablewriteModule Action(String Filename_VALUE, Expressionxportable[] array_EXPRESSIONXPORTABLE, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT, Expressionxportablebuild value_EXPRESSIONXPORTABLEBUILD)
        {
            ExpressionxportablewriteModule module;

            module = Default(Filename_VALUE, array_EXPRESSIONXPORTABLE, value_EXPRESSIONXPORTABLELAYOUT, value_EXPRESSIONXPORTABLEBUILD);
            
            if (ExpressionxportablePolicy.ExpressionxportablewritePolicy is true)
            {
                try
                {
                    Expressionxportablerender.Render($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablewriteModule)}-0", ExpressionxportablewriteCycle.XZeroth);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablewriteModule)}-1", ExpressionxportablewriteCycle.XPrimary.XSingle);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablewriteModule)}-2", ExpressionxportablewriteCycle.XSecondary.XDouble);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablewriteModule)}-3", ExpressionxportablewriteCycle.XTertiary.XTriple);
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

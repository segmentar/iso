using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablereadModule
    {
        public static ExpressionxportablereadModule Action(String Filename_VALUE)
        {
            ExpressionxportablereadModule module;

            module = Default(Filename_VALUE);

            if (ExpressionxportablePolicy.ExpressionxportablereadPolicy is true)
            {
                try
                {
                    Expressionxportablerender.Render($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablereadModule)}-0", ExpressionxportablereadCycle.XZeroth);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablereadModule)}-1", ExpressionxportablereadCycle.XPrimary.XSingle);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablereadModule)}-2", ExpressionxportablereadCycle.XSecondary.XDouble);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablereadModule)}-3", ExpressionxportablereadCycle.XTertiary.XTriple);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablereadModule)}-4", ExpressionxportablereadCycle.XQuaternary.XQuadruple);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablereadModule)}-5", ExpressionxportablereadCycle.XQuinary.XQuintuple);
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

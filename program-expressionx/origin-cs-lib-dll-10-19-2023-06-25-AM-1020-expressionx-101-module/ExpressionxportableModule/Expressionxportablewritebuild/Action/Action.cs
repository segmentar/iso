using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public static ExpressionxportablewritebuildModule Action(Expressionxportable[] array_EXPRESSIONXPORTABLE, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT)
        {
            ExpressionxportablewritebuildModule module;

            module = Default(array_EXPRESSIONXPORTABLE, value_EXPRESSIONXPORTABLELAYOUT);

            if (ExpressionxportablePolicy.ExpressionxportablewritebuildPolicy is true)
            {
                try
                {
                    Expressionxportablerender.Render($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablewritebuildModule)}-0", ExpressionxportablewritebuildCycle.XZeroth);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablewritebuildModule)}-1", ExpressionxportablewritebuildCycle.XPrimary.XSingle);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablewritebuildModule)}-2", ExpressionxportablewritebuildCycle.XSecondary.XDouble);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablewritebuildModule)}-3", ExpressionxportablewritebuildCycle.XTertiary.XTriple);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablewritebuildModule)}-4", ExpressionxportablewritebuildCycle.XQuatenary.XQuadruple);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablewritebuildModule)}-5", ExpressionxportablewritebuildCycle.XQuinary.XQuadruple);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablewritebuildModule)}-6", ExpressionxportablewritebuildCycle.XSenary.XSextuple);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablewritebuildModule)}-7", ExpressionxportablewritebuildCycle.XSeptenary.XSentuple);

                    Expressionxportablerender.Render($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablewritebuildModule)}-8", ExpressionxportablewritebuildCycle.XOctonary.XOctuple);
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

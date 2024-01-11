using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablelinearModule
    {
        public static ExpressionxportablelinearModule Action(ExpressionxportablelinearX_ortY Port_VALUE)
        {
            ExpressionxportablelinearModule module;

            module = new ExpressionxportablelinearModule();

            if (ExpressionxportablePolicy.ExpressionxportablelinearPolicy is true)
            {
                try
                {
                    foreach (Object objectValue in Port_VALUE.LevelArrayList)
                    {
                        Expressionxportablerender.Render($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Render}-{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-{nameof(ExpressionxportablelinearModule)}-{ExpressionxportablePolicy.ExpressionxportableIdentityPolicy}-1", objectValue);

                        continue;
                    }
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

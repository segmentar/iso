using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void HBind(Expression expression, String value, String lower, String[] array)
        {
            try
            {
                var inflect = new Object[2];

                inflect[0] = lower.Split();

                inflect[1] = value.Split();

                var oth = ((String[])inflect[0])[0];

                Boolean isEqualCheck, shouldReturnCheck;

                isEqualCheck = Object.Equals(ExpressionName.EntityInstructionBind, oth) is true;

                shouldReturnCheck = isEqualCheck is false;

                if (shouldReturnCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                var aoth = ((String[])inflect[1]).Length;

                var roth = (aoth - 1);

                var eoth = ((String[])inflect[1])[roth];

                var format = Expressionformat.ForgeDashlessFormat(eoth);

                Bind(expression, format);
            }
            catch (Exception exception)
            {
                Interop.Render($"{ExpressionCode.RenderPath.Core_Expression_Fatal}", new Expressionfatal.Lock().Initialize(new String[0], exception));
            }

            return;
        }
    }
}

using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expressionxportableinstruction
    {
        public static void HView(Expressionxportable expressionxportable, String value, String lower, String[] array)
        {
            try
            {
                var deflect = new IEnumerable[2];

                deflect[0] = value.Split();

                deflect[1] = lower.Split();

                var inflect = new Object[1];

                inflect[0] = ((String[])deflect[1])[0];

                Boolean isEqualCheck, shouldReturnCheck;

                isEqualCheck = Object.Equals(Expressionxportablename.EntityInstructionView, (String)inflect[0]) is true;

                shouldReturnCheck = isEqualCheck is false;

                if (shouldReturnCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                View(expressionxportable);

            } catch (Exception exception)
            {
                var information = new String[] {

                    nameof(HView)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.View().Initialize(information, exception));
            }

            return;
        }
    }
}

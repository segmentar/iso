using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expressionxportableinstruction
    {
        public static void HOperation(Expressionxportable expressionxportable, String value, String lower, String[] array)
        {
            try
            {
                var deflect = new IEnumerable[2];

                deflect[0] = value.Split();

                deflect[1] = lower.Split();

                var inflect = new Object[2];

                inflect[0] = ((String[])deflect[1])[0];

                Boolean isEqualCheck, shouldReturnCheck;

                isEqualCheck = Object.Equals(Expressionxportablename.EntityInstructionOperation, (String)inflect[0]) is true;

                shouldReturnCheck = isEqualCheck is false;

                if (shouldReturnCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                var first  = ((String[])deflect[1])[1];

                inflect[1] = Expressionxportableformat.DashfulFormat(first);

                Operation(expressionxportable, (String)inflect[1], array);

            }
            catch (Exception exception)
            {
                var information = new String[] { 

                    nameof(HOperation)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Operation().Initialize(information, exception));
            }

            return;
        }
    }
}

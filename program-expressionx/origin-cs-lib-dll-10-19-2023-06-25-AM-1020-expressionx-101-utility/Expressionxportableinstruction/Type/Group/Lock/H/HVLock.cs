using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expressionxportableinstruction
    {
        public static void HVLock(Expressionxportable expressionxportable, String value, String lower, String[] array)
        {
            try
            {
                var deflect = new IEnumerable[2];

                deflect[0] = lower.Split();

                deflect[1] = value.Split();

                var inflect = new Object[5];

                inflect[0] = ((String[])deflect[0])[0]; 

                Boolean isEqualCheck, shouldReturnCheck;

                isEqualCheck = Object.Equals(Expressionxportablename.EntityInstructionVLock, (String)inflect[0]) is true;

                shouldReturnCheck = isEqualCheck is false;

                if (shouldReturnCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                inflect[1] = ((String[])deflect[1]).Length;

                inflect[2] = ((Int32)inflect[1] - 1);

                inflect[3] = ((String[])deflect[1])[(Int32)inflect[2]];

                inflect[4] = Expressionxportableformat.DashlessFormat((String)inflect[3]);

                VLock(expressionxportable, (String)inflect[4]);
            }
            catch (Exception exception)
            {
                var information = new String[] { 
                
                    nameof(HVLock)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Lock().Initialize(information, exception));
            }

            return;
        }
    }
}

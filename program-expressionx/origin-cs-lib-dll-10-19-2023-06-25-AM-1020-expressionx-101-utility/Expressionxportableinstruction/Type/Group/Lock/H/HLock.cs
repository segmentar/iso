﻿using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expressionxportableinstruction
    {
        public static void HLock(Expressionxportable expressionxportable, String value, String lower, String[] array)
        {
            try
            {
                var deflect = new IEnumerable[2];

                deflect[0] = value.Split();

                deflect[1] = lower.Split();

                var inflect = new Object[5];

                inflect[0] = ((String[])deflect[1])[0];

                Boolean isEqualCheck, shouldReturnCheck;

                isEqualCheck = Object.Equals(Expressionxportablename.EntityInstructionLock, (String)inflect[0]) is true;

                shouldReturnCheck = isEqualCheck is false;

                if (shouldReturnCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                inflect[1] = ((String[])deflect[0]).Length;

                inflect[2] = ((Int32)inflect[1] - 1);

                inflect[3] = ((String[])deflect[0])[(Int32)inflect[2]];

                inflect[4] = Expressionxportableformat.DashlessFormat((String)inflect[3]);

                Lock(expressionxportable, (String)inflect[4]);
            }
            catch (Exception exception)
            {
                var information = new String[] { 
                
                    nameof(HLock)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Lock().Initialize(information, exception));
            }

            return;
        }
    }
}

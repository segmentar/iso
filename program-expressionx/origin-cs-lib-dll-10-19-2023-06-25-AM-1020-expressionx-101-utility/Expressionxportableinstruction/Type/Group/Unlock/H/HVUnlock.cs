﻿using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expressionxportableinstruction
    {
        public static void HVUnlock(Expressionxportable expressionxportable, String value, String lower, String[] array)
        {
            try
            {
                var deflect = new IEnumerable[2];

                deflect[0] = lower.Split();

                deflect[1] = value.Split();

                var inflect = new Object[1];

                inflect[0] = ((String[])deflect[0])[0];

                Boolean isEqualCheck, shouldReturnCheck;

                isEqualCheck = Object.Equals(Expressionxportablename.EntityInstructionVUnlock, (String)inflect[0]) is true;

                shouldReturnCheck = isEqualCheck is false;

                if (shouldReturnCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                var aoth = ((String[])deflect[1]).Length;

                var roth = (aoth - 1);

                var eoth = ((String[])deflect[1])[roth];

                var format = Expressionxportableformat.DashlessFormat(eoth);
        
                VUnlock(expressionxportable, format);

            }
            catch (Exception exception)
            {
                var information = new String[]
                {
                    nameof(HVUnlock)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Unlock().Initialize(information, exception));
            }

            return;
        }
    }
}

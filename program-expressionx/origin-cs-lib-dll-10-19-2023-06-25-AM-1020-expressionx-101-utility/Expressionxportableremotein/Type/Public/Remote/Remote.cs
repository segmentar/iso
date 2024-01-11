using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableremotein
    {
        public static void Remote(Expressionxportable value_EXPRESSIONXPORTABLE)
        {
            Boolean isDefaultCheck, shouldReturnCheck;

            isDefaultCheck = (value_EXPRESSIONXPORTABLE.ObjectIdentity == default) || (value_EXPRESSIONXPORTABLE.ObjectIdentity == default(Object));

            shouldReturnCheck = isDefaultCheck is true;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            if (isDefaultCheck)
            {
                GroupObject(value_EXPRESSIONXPORTABLE);
            }
            else if (value_EXPRESSIONXPORTABLE.ObjectIdentity is String)
            {
                GroupString(value_EXPRESSIONXPORTABLE);
            }
            else if (value_EXPRESSIONXPORTABLE.ObjectIdentity is Char)
            {
                GroupChar(value_EXPRESSIONXPORTABLE);
            }
            else if (value_EXPRESSIONXPORTABLE.ObjectIdentity is Boolean)
            {
                GroupBoolean(value_EXPRESSIONXPORTABLE);
            }
            else if (value_EXPRESSIONXPORTABLE.ObjectIdentity is Byte)
            {
                GroupByte(value_EXPRESSIONXPORTABLE);
            }
            else if (value_EXPRESSIONXPORTABLE.ObjectIdentity is Int64)
            {
                GroupInt64(value_EXPRESSIONXPORTABLE);
            }
            else if (value_EXPRESSIONXPORTABLE.ObjectIdentity is Int32)
            {
                GroupInt32(value_EXPRESSIONXPORTABLE);
            }
            else if (value_EXPRESSIONXPORTABLE.ObjectIdentity is Int16)
            {
                GroupInt16(value_EXPRESSIONXPORTABLE);
            }
            else if (value_EXPRESSIONXPORTABLE.ObjectIdentity is SByte)
            {
                GroupSByte(value_EXPRESSIONXPORTABLE);
            }
            else if (value_EXPRESSIONXPORTABLE.ObjectIdentity is UInt64)
            {
                GroupUInt16(value_EXPRESSIONXPORTABLE);
            }
            else if (value_EXPRESSIONXPORTABLE.ObjectIdentity is UInt32)
            {
                GroupUInt32(value_EXPRESSIONXPORTABLE);
            }
            else if (value_EXPRESSIONXPORTABLE.ObjectIdentity is UInt16)
            {
                GroupUInt64(value_EXPRESSIONXPORTABLE);
            }
            else
            {
                GroupObject(value_EXPRESSIONXPORTABLE);
            }

            return;
        }
    }
}

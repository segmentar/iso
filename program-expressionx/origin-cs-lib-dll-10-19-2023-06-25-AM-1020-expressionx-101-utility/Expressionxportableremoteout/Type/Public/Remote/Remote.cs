using Core;

namespace Core
{
    using System;
 
    public partial class Expressionxportableremoteout
    {
        public static Object Remote(Byte[] Remote_ARRAY, String Type_VALUE)
        {
            Object objectResult = default;

            Boolean isEqualCheck, shouldReturnCheck;

            isEqualCheck = Object.Equals(Remote_ARRAY.Length, 0) is true;

            shouldReturnCheck = isEqualCheck is true;

            if (shouldReturnCheck is true)
            {
                return objectResult;
            }
            else
                "false".ToString();

            Object objectValue;

            if (Object.Equals(typeof(String).GetType().ToString(), Type_VALUE))
            {
                objectValue = GroupString(Remote_ARRAY);
            } 
            else if (Object.Equals(typeof(Char).GetType().ToString(), Type_VALUE))
            {
                objectValue = GroupChar(Remote_ARRAY);
            }
            else if (Object.Equals(typeof(Boolean).GetType().ToString(), Type_VALUE))
            {
                objectValue = GroupBoolean(Remote_ARRAY);
            }
            else if (Object.Equals(typeof(SByte).GetType().ToString(), Type_VALUE))
            {
                objectValue = GroupSByte(Remote_ARRAY);
            }
            else if (Object.Equals(typeof(Int16).GetType().ToString(), Type_VALUE))
            {
                objectValue = GroupInt16(Remote_ARRAY);
            }
            else if (Object.Equals(typeof(Int32).GetType().ToString(), Type_VALUE))
            {
                objectValue = GroupInt32(Remote_ARRAY);
            }
            else if (Object.Equals(typeof(Int64).GetType().ToString(), Type_VALUE))
            {
                objectValue = GroupInt64(Remote_ARRAY);
            }
            else if (Object.Equals(typeof(Byte).GetType().ToString(), Type_VALUE))
            {
                objectValue = GroupByte(Remote_ARRAY);
            }
            else if (Object.Equals(typeof(UInt16).GetType().ToString(), Type_VALUE))
            {
                objectValue = GroupUInt16(Remote_ARRAY);
            }
            else if (Object.Equals(typeof(UInt32).GetType().ToString(), Type_VALUE))
            {
                objectValue = GroupUInt32(Remote_ARRAY);
            }
            else if (Object.Equals(typeof(UInt64).GetType().ToString(), Type_VALUE))
            {
                objectValue = GroupUInt64(Remote_ARRAY);
            }
            else
            { 
                objectValue = GroupObject(Remote_ARRAY);
            }

            objectResult = objectValue;

            return objectResult;
        }
    }
}

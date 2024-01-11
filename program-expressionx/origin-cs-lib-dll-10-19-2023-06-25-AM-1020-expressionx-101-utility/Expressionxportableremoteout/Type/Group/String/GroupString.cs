using Core;

namespace Core
{
    using System;

    using System.Text;

    public partial class Expressionxportableremoteout
    {
        public static Object GroupString(Byte[] Remote_ARRAY)
        {
            Object objectResult = default;

            var data = ((Encoding)Expressionxportable.ReaderRemoteEncodingObject).GetString(Remote_ARRAY);

            objectResult = data;

            return objectResult;
        }
    }
}

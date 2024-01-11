using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Text;

    public partial class ExpressionxportablewriteModule
    {
        public partial class XSingle
        {
            public static XSingle ForgeLeveL(Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT)
            {
                XSingle singleResult = default;

                MemoryStream memoryStream;

                memoryStream = new MemoryStream();

                BinaryWriter binaryWriter;

                binaryWriter = new BinaryWriter(memoryStream, (Encoding)Expressionxportable.WriterEncodingObject, true);

                using (binaryWriter)
                {
                    binaryWriter.Write(value_EXPRESSIONXPORTABLELAYOUT.ExpressionCount);

                    binaryWriter.Write(value_EXPRESSIONXPORTABLELAYOUT.StartAddressSubjectTable);

                    binaryWriter.Write(value_EXPRESSIONXPORTABLELAYOUT.StartAddressObjectTable);

                    binaryWriter.Close();

                    binaryWriter.Dispose();
                }

                var array = memoryStream.ToArray();

                XSingle single;

                single = new XSingle(memoryStream, binaryWriter, array);

                singleResult = single;

                return singleResult;
            }
        }
    }
}

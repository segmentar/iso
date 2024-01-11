using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Text;

    public partial class ExpressionxportablereadModule
    {
        public partial class XDouble
        {
            public static XDouble ForgeLevel(MemoryStream value_MEMORYSTREAM)
            {
                XDouble xdoubleResult = default;

                BinaryReader binaryReader;

                binaryReader = new BinaryReader(value_MEMORYSTREAM, (Encoding)Expressionxportable.ReaderEncodingObject, true);

                using (binaryReader)
                {
                    Expressionxportablelayout expressionxportablelayout;

                    expressionxportablelayout = new Expressionxportablelayout();

                    expressionxportablelayout.ExpressionCount = Convert.ToInt32(binaryReader.ReadUInt32());

                    expressionxportablelayout.StartAddressSubjectTable = Convert.ToInt32(binaryReader.ReadUInt32());

                    expressionxportablelayout.StartAddressObjectTable = Convert.ToInt32(binaryReader.ReadUInt64());

                    XDouble xdouble;

                    xdouble = new XDouble(binaryReader, expressionxportablelayout);

                    xdoubleResult = xdouble;

                    binaryReader.Close();

                    binaryReader.Dispose();
                }

                return xdoubleResult;
            }
        }
    }
}

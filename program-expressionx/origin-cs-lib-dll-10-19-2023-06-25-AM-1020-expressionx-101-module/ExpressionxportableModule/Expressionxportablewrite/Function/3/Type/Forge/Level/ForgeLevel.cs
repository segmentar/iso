using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Text;

    public partial class ExpressionxportablewriteModule
    {
        public partial class XTriple
        {
            public static XTriple ForgeLeveL(ExpressionxportablebuildUle_elV[] Level_ARRAY)
            {
                XTriple xtripleResult = default;

                MemoryStream memoryStream;

                memoryStream = new MemoryStream();

                BinaryWriter binaryWriter;

                binaryWriter = new BinaryWriter(memoryStream, (Encoding)Expressionxportable.WriterEncodingObject, true);

                using (binaryWriter)
                {
                    foreach (ExpressionxportablebuildUle_elV Level_VALUE in Level_ARRAY)
                    {
                        binaryWriter.Write(Level_VALUE.RemoteArray);

                        var data = ((Encoding)Expressionxportable.WriterEncodingObject).GetBytes(Level_VALUE.Type);

                        binaryWriter.Write(data);

                        continue;
                    }

                    binaryWriter.Close();

                    binaryWriter.Dispose();
                }

                var array = memoryStream.ToArray();

                XTriple xtriple;

                xtriple = new XTriple(memoryStream, binaryWriter, array);

                xtripleResult = xtriple;

                return xtripleResult;
            }
        }
    }
}

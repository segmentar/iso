using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Text;

    public partial class ExpressionxportablewritefileModule
    {
        public static XSingle ForgeLevel(String Path_VALUE, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT, Byte[][] jagged_BYTE)
        {
            XSingle xsingleResult = default;

            if (File.Exists(Path_VALUE) is true)
            {
                File.Delete(Path_VALUE);
            }
            else
                "false".ToString();

            FileStream fileStream;

            fileStream = File.Create(Path_VALUE);

            MemoryStream memoryStream;

            memoryStream = new MemoryStream();

            fileStream.CopyTo(memoryStream);

            BinaryWriter binaryWriter;

            binaryWriter = new BinaryWriter(memoryStream, (Encoding)Expressionxportable.WriterEncodingObject, true);

            using (binaryWriter)
            {
                binaryWriter.Write(jagged_BYTE[0]);

                binaryWriter.BaseStream.Seek(value_EXPRESSIONXPORTABLELAYOUT.StartAddressSubjectTable, SeekOrigin.Begin);

                binaryWriter.Write(jagged_BYTE[1]);

                binaryWriter.BaseStream.Seek(value_EXPRESSIONXPORTABLELAYOUT.StartAddressObjectTable, SeekOrigin.Begin);

                binaryWriter.Write(jagged_BYTE[2]);

                binaryWriter.Close();

                binaryWriter.Dispose();
            }

            memoryStream.Position = 0;

            memoryStream.CopyTo(fileStream);

            XSingle xsingle;

            xsingle = new XSingle(fileStream, memoryStream, binaryWriter);

            xsingleResult = xsingle;

            return xsingleResult;
        }
    }
}

using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Text;

    public partial class ExpressionxportablewriteModule
    {
        public partial class XDouble
        {
            public static XDouble ForgeLevel(Expressionxportablebuild value_EXPRESSIONXPORTABLEBUILD)
            {
                XDouble xdoubleResult = default;

                MemoryStream memoryStream;

                memoryStream = new MemoryStream();

                BinaryWriter binaryWriter;

                binaryWriter = new BinaryWriter(memoryStream, (Encoding)Expressionxportable.WriterEncodingObject, true);

                using (binaryWriter)
                {
                    var position = binaryWriter.BaseStream.Position;

                    foreach (ExpressionxportablebuildU_evelV Level_VALUE in value_EXPRESSIONXPORTABLEBUILD.LevelLevelLevelLevelLevelLevel)
                    {
                        binaryWriter.BaseStream.Seek(position, SeekOrigin.Begin);

                        binaryWriter.Write(Convert.ToUInt32(Level_VALUE.Ordinal));

                        binaryWriter.Write(Convert.ToUInt32(Level_VALUE.Layer));

                        binaryWriter.Write(Convert.ToUInt32(Level_VALUE.Relation));

                        binaryWriter.Write(Convert.ToUInt32(Level_VALUE.ObjectStartAddress));

                        binaryWriter.Write(Convert.ToUInt32(Level_VALUE.ObjectEndAddress));

                        binaryWriter.Write(Convert.ToUInt32(Level_VALUE.TypeStartAddress));

                        binaryWriter.Write(Convert.ToUInt32(Level_VALUE.TypeEndAddress));

                        binaryWriter.Write(Level_VALUE.Value);

                        position = position + Expressionxportable.BoundarySize;

                        continue;
                    }

                    binaryWriter.Close();

                    binaryWriter.Dispose();
                }

                var array = memoryStream.ToArray();

                XDouble xdouble;

                xdouble = new XDouble(memoryStream, binaryWriter, array);

                xdoubleResult = xdouble;

                return xdoubleResult;
            }
        }
    }
}

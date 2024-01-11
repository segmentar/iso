using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Text;

    public partial class ExpressionxportablereadModule
    {
        public partial class XQuadruple
        {
            public static XQuadruple ForgeLevel(MemoryStream value_MEMORYSTREAM)
            {
                XQuadruple xquadrupleResult = default;

                BinaryReader binaryReader;

                binaryReader = new BinaryReader(value_MEMORYSTREAM, (Encoding)Expressionxportable.ReaderEncodingObject, true);

                var array = FunctionDefaultSetSurface(ExpressionxportablereadCycle.XTertiary.XTriple.LevelArray);

                FunctionDefaultVoid(array);

                XQuadruple xquadruple;

                xquadruple = new XQuadruple(binaryReader, array);

                xquadrupleResult = xquadruple;

                return xquadrupleResult;
            }
        }
    }
}

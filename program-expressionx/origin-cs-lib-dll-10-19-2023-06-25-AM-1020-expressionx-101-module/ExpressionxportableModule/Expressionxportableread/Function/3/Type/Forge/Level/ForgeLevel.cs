using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Text;

    public partial class ExpressionxportablereadModule
    {
        public partial class XTriple
        {
            public static XTriple ForgeLevel(MemoryStream value_MEMORYSTREAM, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT)
            {
                XTriple xtripleResult = default;

                BinaryReader binaryReader;

                binaryReader = new BinaryReader(value_MEMORYSTREAM, (Encoding)Expressionxportable.ReaderEncodingObject, true);

                var array = FunctionDefaultSetSurface(binaryReader, value_EXPRESSIONXPORTABLELAYOUT);

                XTriple xtriple;

                xtriple = new XTriple(binaryReader, array);

                /*var inflect = new Object[4];

                inflect[0] = FunctionUp_rtVSetSurface(binaryReader, Expressionlayout_VALUE);

                inflect[1] = FunctionExpressionSetSurface((Up_rtV[])inflect[0]);

                inflect[2] = ForgeRoot((Upo_tV[])inflect[1]);

                FunctionLinkVoid((Upo_tV[])inflect[1]);

                inflect[3] = ((Upo_tV)inflect[2]).Expression;

                XTriple triple;

                triple = new XTriple
(
binaryReader, 
(Up_rtV[])inflect[0],
(Upo_tV[])inflect[1],
(Upo_tV)inflect[2],
(Expressionxportable)inflect[3]
);*/

                xtripleResult = xtriple;

                return xtripleResult;
            }
        }
    }
}

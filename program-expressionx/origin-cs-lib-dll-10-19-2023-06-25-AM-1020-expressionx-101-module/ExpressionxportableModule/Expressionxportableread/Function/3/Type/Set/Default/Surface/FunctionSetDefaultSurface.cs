using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class ExpressionxportablereadModule
    {
        public partial class XTriple
        {
            public static ExpressionxportablebuildUle_elV[] FunctionDefaultSetSurface(BinaryReader value_BINARYREADER, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT)
            {
                ExpressionxportablebuildUle_elV[] arrayResult = default;

                var list = FunctionDefaultSet(value_BINARYREADER, value_EXPRESSIONXPORTABLELAYOUT);

                var array = new ExpressionxportablebuildUle_elV[list.Count];

                list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}

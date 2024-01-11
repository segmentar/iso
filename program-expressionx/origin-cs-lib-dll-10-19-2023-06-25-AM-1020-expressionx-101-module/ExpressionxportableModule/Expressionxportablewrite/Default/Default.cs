using Core;

namespace Core
{
    using System;
    using System.Collections;
    using System.IO;

    public partial class ExpressionxportablewriteModule
    {
        public static ExpressionxportablewriteModule Default(String Filename_VALUE, Expressionxportable[] array_EXPRESSIONXPORTABLE, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT, Expressionxportablebuild value_EXPRESSIONXPORTABLEBUILD)
        {
            ExpressionxportablewriteModule module;

            module = new ExpressionxportablewriteModule();

            var inflect = new Object[4];

            inflect[0] = Filename_VALUE;

            inflect[1] = Expressionxportablemagic.ExpressionxportablemagicArrayListDispenser(array_EXPRESSIONXPORTABLE);

            inflect[2] = value_EXPRESSIONXPORTABLELAYOUT;

            inflect[3] = value_EXPRESSIONXPORTABLEBUILD;

            ExpressionxportablewriteCycle.XZeroth = new XZeroth(inflect);

            module = module.XOne(module);

            module = module.XTwo(module);

            module = module.XThree(module);

            var deflect = new IEnumerable[2];

            deflect[0] = new MemoryStream[3];

            ((MemoryStream[])deflect[0])[0] = ExpressionxportablewriteCycle.XPrimary.XSingle.MemoryStream;

            ((MemoryStream[])deflect[0])[1] = ExpressionxportablewriteCycle.XSecondary.XDouble.MemoryStream;

            ((MemoryStream[])deflect[0])[2] = ExpressionxportablewriteCycle.XTertiary.XTriple.MemoryStream;

            deflect[1] = new Byte[3][];

            ((Byte[][])deflect[1])[0] = ExpressionxportablewriteCycle.XPrimary.XSingle.ByteArray;

            ((Byte[][])deflect[1])[1] = ExpressionxportablewriteCycle.XSecondary.XDouble.ByteArray;

            ((Byte[][])deflect[1])[2] = ExpressionxportablewriteCycle.XTertiary.XTriple.ByteArray;

            module.MemoryStreamArray = ((MemoryStream[])deflect[0]);

            module.ByteJaggedArray = ((Byte[][])deflect[1]);

            return module;
        }
    }
}

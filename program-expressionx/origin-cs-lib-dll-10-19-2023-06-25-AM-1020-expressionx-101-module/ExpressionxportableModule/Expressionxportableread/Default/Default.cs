using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablereadModule
    {
        public static ExpressionxportablereadModule Default(String Filename_VALUE)
        {
            ExpressionxportablereadModule module;

            module = new ExpressionxportablereadModule();

            var inflect = new Object[1];

            inflect[0] = Filename_VALUE;

            ExpressionxportablereadCycle.XZeroth = new XZeroth(inflect);

            module = module.XOne(module);

            module = module.XTwo(module);

            module = module.XThree(module);

            module = module.XFour(module);

            module = module.XFive(module);

            module.FileStream = ExpressionxportablereadCycle.XPrimary.XSingle.FileStream;

            module.MemoryStream = ExpressionxportablereadCycle.XPrimary.XSingle.MemoryStream;

            module.Expressionxportable = ExpressionxportablereadCycle.XQuinary.XQuintuple.Level.Expression;

            module.Type = ExpressionxportablereadCycle.XQuinary.XQuintuple.Level.Type;

            module.RemoteArray = ExpressionxportablereadCycle.XQuinary.XQuintuple.Level.RemoteArray;

            return module;
        }
    }
}

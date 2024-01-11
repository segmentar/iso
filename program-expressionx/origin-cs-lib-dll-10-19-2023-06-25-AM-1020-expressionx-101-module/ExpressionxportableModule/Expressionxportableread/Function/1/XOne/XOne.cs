using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablereadModule
    {
        public ExpressionxportablereadModule XOne(ExpressionxportablereadModule module)
        {
            var level = XSingle.ForgeLevel((String)ExpressionxportablereadCycle.XZeroth.ObjectArray[0]);

            XFirst xfirst;

            xfirst = new XFirst(level);

            ExpressionxportablereadCycle.XPrimary = xfirst;

            return module;
        }
    }
}

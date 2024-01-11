using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expressionxportableload
    {
        public static Object[] Load(String Filename_VALUE, Expressionxportableloadcontext value_EXPRESSIONXPORTABLELOADCONTEXT)
        {
            Object[] arrayResult = default;

            ExpressionxportablereadModule expressionxportablereadModule = ExpressionxportablereadModule.Action(Filename_VALUE);

            Expressionxportablereadclose expressionreadclose;

            expressionreadclose = new Expressionxportablereadclose();

            expressionreadclose.FileStreamClose = true;

            expressionreadclose.FileStreamMemoryStreamClose = true;

            ExpressionxportablereadfileModule expressionxportablereadfileModule = ExpressionxportablereadfileModule.Action(expressionreadclose, expressionxportablereadModule.FileStream, expressionxportablereadModule.MemoryStream);

            var inflect = new Object[2];

            inflect[0] = expressionxportablereadModule;

            inflect[1] = expressionxportablereadfileModule;

            var result = inflect;

            arrayResult = result;

            if (value_EXPRESSIONXPORTABLELOADCONTEXT.ShouldExecute is true)
            {
                Expressionxportableremoteadapt.Adapt(expressionxportablereadModule.Expressionxportable, expressionxportablereadModule.Type, expressionxportablereadModule.RemoteArray);
            }
            else
                "false".ToString();

            if (value_EXPRESSIONXPORTABLELOADCONTEXT.ShouldDestroy is true)
            {
                //File.Delete(Filename_VALUE);
            }
            else
                "false".ToString();

            if (value_EXPRESSIONXPORTABLELOADCONTEXT.ShouldFilesystem is true)
            {
                //Filesystem(ExpressionreadModule.ExpressionreadCycle.Tertiary.Triple.PortPortPort);
            }
            else
                "false".ToString();

            return arrayResult;
        }
    }
}

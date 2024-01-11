using Core;

namespace Core
{
    using System;

    public partial class Expressionxportablesave
    {
        public static Object[] Save(Expressionxportable value_EXPRESSIONXPORTABLE, String Filename_VALUE, Expressionxportablesavecontext value_EXPRESSIONXPORTABLESAVECONTEXT)
        {
            Object[] arrayResult = default;

            if (value_EXPRESSIONXPORTABLESAVECONTEXT.ShouldRemote is true)
            {
                Expressionxportableremotein.RemoteAll(value_EXPRESSIONXPORTABLE);
            }
            else
                "false".ToString();

            var array = Expressionxportableset.ExpressionxportableAllSetSurface(value_EXPRESSIONXPORTABLE, true);

            Expressionxportablelayout expressionxportablelayout;

            expressionxportablelayout = new Expressionxportablelayout();

            expressionxportablelayout.ExpressionCount = array.Length;

            expressionxportablelayout.StartAddressSubjectTable = Expressionxportable.BoundaryStart;

            expressionxportablelayout.StartAddressObjectTable = expressionxportablelayout.StartAddressSubjectTable;

            expressionxportablelayout.StartAddressObjectTable = expressionxportablelayout.StartAddressObjectTable + (expressionxportablelayout.ExpressionCount * Expressionxportable.BoundarySize);

            ExpressionxportablewritebuildModule expressionxportablewritebuildModule = ExpressionxportablewritebuildModule.Action(array, expressionxportablelayout);

            ExpressionxportablewriteModule expressionxportablewriteModule = ExpressionxportablewriteModule.Action(Filename_VALUE, array, expressionxportablelayout, expressionxportablewritebuildModule.Expressionxportablebuild);

            Expressionxportablewriteclose expressionwriteclose;

            expressionwriteclose = new Expressionxportablewriteclose();

            expressionwriteclose.MemoryStreamHearderClose = true;

            expressionwriteclose.MemoryStreamSubjectTableClose = true;

            expressionwriteclose.MemoryStreamObjectTableClose = true;

            expressionwriteclose.FileStreamClose = true;

            expressionwriteclose.FileStreamMemoryStreamClose = true;

            ExpressionxportablewritefileModule expressionxportablewritefileModule = ExpressionxportablewritefileModule.Action(Filename_VALUE, expressionxportablelayout, expressionwriteclose, expressionxportablewriteModule.MemoryStreamArray, expressionxportablewriteModule.ByteJaggedArray);

            var inflect = new Object[3];

            inflect[0] = expressionxportablewritebuildModule;

            inflect[1] = expressionxportablewriteModule;

            inflect[2] = expressionxportablewritefileModule;

            var result = inflect;

            arrayResult = result;

            return arrayResult;
        }
    }
}

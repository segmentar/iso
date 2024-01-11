using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static void SaveToCurrentDirectoryFolder(Expressionxportable expressionxportable, String folderName, String name, Expressionxportablesavecontext expressionxportablesavecontext)
        {
            Expressionxportablesave.SaveToCurrentDirectoryFolder(expressionxportable, folderName, name, expressionxportablesavecontext);

            return;
        }
    }
}

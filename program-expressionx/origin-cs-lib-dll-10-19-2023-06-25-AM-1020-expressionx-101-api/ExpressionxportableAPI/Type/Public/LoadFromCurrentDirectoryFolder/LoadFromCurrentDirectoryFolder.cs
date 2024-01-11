using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static Expressionxportable LoadFromCurrentDirectoryFolder(String folder, String name, Expressionxportableloadcontext expressionxportableloadcontext)
        {
            Expressionxportable expressionxportableResult = default;

            expressionxportableResult = Expressionxportableload.LoadFromCurrentDirectoryFolder(folder, name, expressionxportableloadcontext);

            return expressionxportableResult;
        }
    }
}

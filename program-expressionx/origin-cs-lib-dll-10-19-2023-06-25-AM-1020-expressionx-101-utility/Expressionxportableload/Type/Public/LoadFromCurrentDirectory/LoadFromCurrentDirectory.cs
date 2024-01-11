using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expressionxportableload
    {
        public static Expressionxportable LoadFromCurrentDirectory(String Filename_VALUE, Expressionxportableloadcontext value_EXPRESSIONXPORTABLELOADCONTEXT)
        {
            Expressionxportable expressionxportableResult = default;

            var CurrentDirectory_PATH = Directory.GetCurrentDirectory();

            var path_FILE_filename = Path.Combine(CurrentDirectory_PATH, Filename_VALUE);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, Expressionxportablename.EntityExpressionExtension);

            var array = Load(path_FILE_filename_with_extension, value_EXPRESSIONXPORTABLELOADCONTEXT);

            var result = ((ExpressionxportablereadModule)array[0]).Expressionxportable;

            expressionxportableResult = result;

            return expressionxportableResult;
        }
    }
}

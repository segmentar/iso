using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expressionxportablesave
    {
        public static void SaveToCurrentDirectory(Expressionxportable value_EXPRESSIONXPORTABLE, String FileName__VALUE, Expressionxportablesavecontext value_EXPRESSIONXPORTABLESAVECONTEXT)
        {
            var CurrentDirectory__PATH = Directory.GetCurrentDirectory();

            var path_FILE_filename = Path.Combine(CurrentDirectory__PATH, FileName__VALUE);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, Expressionxportablename.EntityExpressionExtension);

            Save(value_EXPRESSIONXPORTABLE, path_FILE_filename_with_extension, value_EXPRESSIONXPORTABLESAVECONTEXT);

            return;
        }
    }
}

using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expressionxportablesave
    {
        public static void SaveToSpace(Expressionxportable value_EXPRESSIONXPORTABLE, Expressionxportablesavecontext value_EXPRESSIONXPORTABLESAVECONTEXT)
        {
            var CurrentDirectory__PATH = Directory.GetCurrentDirectory();

            var path_DIRECTORY_full_name = Path.Combine(CurrentDirectory__PATH, Expressionxportablename.EntitySpaceFolderName);

            if (Directory.Exists(path_DIRECTORY_full_name) is false)
            {
                DirectoryInfo directoryInfo;

                directoryInfo = Directory.CreateDirectory(path_DIRECTORY_full_name);

                path_DIRECTORY_full_name = directoryInfo.FullName;
            }
            else
                "false".ToString();

            var path_FILE_filename = Path.Combine(path_DIRECTORY_full_name, Expressionxportablename.EntitySpaceFileName);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, Expressionxportablename.EntityExpressionExtension);

            Save(value_EXPRESSIONXPORTABLE, path_FILE_filename_with_extension, value_EXPRESSIONXPORTABLESAVECONTEXT);

            return;
        }
    }
}

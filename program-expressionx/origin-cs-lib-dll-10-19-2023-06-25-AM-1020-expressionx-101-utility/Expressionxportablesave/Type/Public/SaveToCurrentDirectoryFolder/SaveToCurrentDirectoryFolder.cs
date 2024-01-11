using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expressionxportablesave
    {
        public static void SaveToCurrentDirectoryFolder(Expressionxportable value_EXPRESSIONXPORTABLE, String FolderName__VALUE, String FileName__VALUE, Expressionxportablesavecontext value_EXPRESSIONXPORTABLESAVECONTEXT)
        {
            var CurrentDirectory__PATH = Directory.GetCurrentDirectory();

            var path_DIRECTORY_full_name = Path.Combine(CurrentDirectory__PATH, FolderName__VALUE);

            if (Directory.Exists(path_DIRECTORY_full_name) is false)
            {
                DirectoryInfo directoryInfo;

                directoryInfo = Directory.CreateDirectory(path_DIRECTORY_full_name);

                path_DIRECTORY_full_name = directoryInfo.FullName;
            }
            else
                "false".ToString();

            var path_FILE_filename = Path.Combine(path_DIRECTORY_full_name, FileName__VALUE);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, Expressionxportablename.EntityExpressionExtension);

            Save(value_EXPRESSIONXPORTABLE, path_FILE_filename_with_extension, value_EXPRESSIONXPORTABLESAVECONTEXT);

            return;
        }
    }
}

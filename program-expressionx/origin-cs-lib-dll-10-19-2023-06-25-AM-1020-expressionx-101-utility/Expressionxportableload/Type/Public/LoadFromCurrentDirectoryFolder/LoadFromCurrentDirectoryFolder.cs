using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expressionxportableload
    {
        public static Expressionxportable LoadFromCurrentDirectoryFolder(String Folder_NAME, String Name_VALUE, Expressionxportableloadcontext value_EXPRESSIONXPORTABLELOADCONTEXT)
        {
            Expressionxportable expressionxportableResult = default;

            var CurrentDirectory_PATH = Directory.GetCurrentDirectory();

            var path_DIRECTORY_full_name = Path.Combine(CurrentDirectory_PATH, Folder_NAME);

            if (Directory.Exists(path_DIRECTORY_full_name) is false)
            {
                DirectoryInfo directoryInfo;

                directoryInfo = Directory.CreateDirectory(path_DIRECTORY_full_name);
            }
            else
                "false".ToString();

            var path_FILE_filename = Path.Combine(path_DIRECTORY_full_name, Name_VALUE);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, Expressionxportablename.EntityExpressionExtension);

            var array = Load(path_FILE_filename_with_extension, value_EXPRESSIONXPORTABLELOADCONTEXT);

            var result = ((ExpressionxportablereadModule)array[0]).Expressionxportable;

            expressionxportableResult = result;

            return expressionxportableResult;
        }
    }
}

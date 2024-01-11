using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expressionxportableload
    {
        public static Expressionxportable LoadFromSpace(Expressionxportableloadcontext value_EXPRESSIONXPORTABLELOADCONTEXT)
        {
            Expressionxportable expressionxportableResult = default;

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

            var array = Load(path_FILE_filename_with_extension, value_EXPRESSIONXPORTABLELOADCONTEXT);

            var result = ((ExpressionxportablereadModule)array[0]).Expressionxportable;

            expressionxportableResult = result;

            return expressionxportableResult;
        }
    }
}

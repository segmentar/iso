using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expressionxportable
    {
        public static void Filesystem(Upo_tV Level_VALUE)
        {
            foreach (Expressionxportable expression in ExpressionAllSetSurface(Level_VALUE.Expression, true))
            {
                Boolean isDefaultCheck, shouldContinueContinuousCheck;

                isDefaultCheck = (expression.ObjectIdentity == default) is true;

                shouldContinueContinuousCheck = isDefaultCheck is true;

                if (shouldContinueContinuousCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                Boolean isEqualCheck;

                isEqualCheck = Object.Equals(typeof(Expressionfilesystemfolder), expression.ObjectIdentity.GetType()) is true;

                shouldContinueContinuousCheck = isEqualCheck is false;

                if (shouldContinueContinuousCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                var array = FunctionSetFilesystemSurface(expression, String.Empty, true);

                foreach (var value in array)
                {
                    if (value is DirectoryInfo)
                    {
                        DirectoryInfo directoryInfo;

                        directoryInfo = (DirectoryInfo)value;

                        if (Directory.Exists(directoryInfo.FullName) is true)
                        {
                            Directory.Delete(directoryInfo.FullName, true);
                        }
                        else
                            "false".ToString();

                        if (Directory.Exists(directoryInfo.FullName) is false)
                        {
                            directoryInfo = Directory.CreateDirectory(directoryInfo.FullName);
                        }
                        else
                            "false".ToString();
                    }
                    else
                        "false".ToString();

                    if (value is FileInfo)
                    {
                        FileInfo fileInfo;

                        fileInfo = (FileInfo)value;

                        if (File.Exists(fileInfo.FullName) is true)
                        {
                            File.Delete(fileInfo.FullName);
                        }
                        else
                            "false".ToString();

                        if (File.Exists(fileInfo.FullName) is false)
                        {
                            FileStream fileStream;

                            fileStream = File.Create(fileInfo.FullName);

                            var list = Interop.InteropArrayListCastDispenser(FileStreamArrayListObject);

                            list.Add(fileStream);
                        }
                        else
                            "false".ToString();
                    }
                    else
                        "false".ToString();

                    continue;
                }

                continue;
            }

            return;
        }
    }
}

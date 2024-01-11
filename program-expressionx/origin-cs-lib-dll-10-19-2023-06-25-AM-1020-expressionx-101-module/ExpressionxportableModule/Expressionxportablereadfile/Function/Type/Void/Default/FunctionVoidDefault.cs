using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class ExpressionxportablereadfileModule
    {
        public partial class XZeroth
        {
            public static void FunctionDefaultVoid(Expressionxportablereadclose value_EXPRESSIONXPORTABLEREADCLOSE, FileStream value_FILESTREAM, MemoryStream value_MEMORYSTREAM)
            {
                if (value_EXPRESSIONXPORTABLEREADCLOSE.FileStreamClose is true)
                {
                    using (var stream = value_FILESTREAM)
                    {
                        stream.Close();

                        stream.Dispose();
                    }
                }
                else
                    "false".ToString();

                if (value_EXPRESSIONXPORTABLEREADCLOSE.FileStreamMemoryStreamClose is true)
                {
                    using (var stream = value_MEMORYSTREAM)
                    {
                        stream.Close();

                        stream.Dispose();
                    }
                }
                else
                    "false".ToString();

                return;
            }
        }
    }
}

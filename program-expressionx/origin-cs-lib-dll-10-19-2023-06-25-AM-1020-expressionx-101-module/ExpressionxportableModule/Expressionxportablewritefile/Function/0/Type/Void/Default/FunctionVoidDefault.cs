using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class ExpressionxportablewritefileModule
    {
        public partial class XZeroth
        {
            public static void FunctionDefaultVoid(Expressionxportablewriteclose value_EXPRESSIONXPORTABLEWRITECLOSE, MemoryStream[] array_MEMORYSTREAM)
            {
                if (value_EXPRESSIONXPORTABLEWRITECLOSE.MemoryStreamHearderClose is true)
                {
                    using (var stream = array_MEMORYSTREAM[0])
                    {
                        stream.Close();

                        stream.Dispose();
                    }
                }
                else
                    "false".ToString();

                if (value_EXPRESSIONXPORTABLEWRITECLOSE.MemoryStreamSubjectTableClose is true)
                {
                    using (var stream = array_MEMORYSTREAM[1])
                    {
                        stream.Close();

                        stream.Dispose();
                    }
                }
                else
                    "false".ToString();

                if (value_EXPRESSIONXPORTABLEWRITECLOSE.MemoryStreamObjectTableClose is true)
                {
                    using (var stream = array_MEMORYSTREAM[2])
                    {
                        stream.Close();

                        stream.Dispose();
                    }
                }
                else
                    "false".ToString();

                if (value_EXPRESSIONXPORTABLEWRITECLOSE.FileStreamClose is true)
                {
                    using (var stream = ExpressionxportablewritefileCycle.XPrimary.XSingle.FileStream)
                    {
                        stream.Close();

                        stream.Dispose();
                    }
                }
                else
                    "false".ToString();


                if (value_EXPRESSIONXPORTABLEWRITECLOSE.FileStreamMemoryStreamClose is true)
                {
                    using (var stream = ExpressionxportablewritefileCycle.XPrimary.XSingle.MemoryStream)
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

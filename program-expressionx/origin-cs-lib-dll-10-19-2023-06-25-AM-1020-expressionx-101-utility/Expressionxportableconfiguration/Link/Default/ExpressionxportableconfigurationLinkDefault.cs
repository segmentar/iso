using Core;

namespace Core
{
    using System;

    using System.Text;

    public partial class ExpressionxportableconfigurationDefault
    {
        public static Int32 BoundaryStartDefault;

        public static Int32 BoundarySizeDefalut;

        public static Object WriterEncodingObjectDefault;

        public static Object ReaderEncodingObjectDefault;

        public static Object WriterRemoteEncodingObjectDefault;

        public static Object ReaderRemoteEncodingOBjectDefault;

        public static Object FileStreamWriterEncodingDefault;

        public static Object FileStreamReaderEncodingDefault;

        static ExpressionxportableconfigurationDefault()
        {
            BoundaryStartDefault = 300;

            BoundarySizeDefalut = 300;

            WriterEncodingObjectDefault = Encoding.Default;

            ReaderEncodingObjectDefault = Encoding.Default;

            WriterRemoteEncodingObjectDefault = Encoding.Default;

            ReaderRemoteEncodingOBjectDefault = Encoding.Default;

            FileStreamWriterEncodingDefault = Encoding.Default;

            FileStreamReaderEncodingDefault = Encoding.Default;

            return;
        }
    }
}

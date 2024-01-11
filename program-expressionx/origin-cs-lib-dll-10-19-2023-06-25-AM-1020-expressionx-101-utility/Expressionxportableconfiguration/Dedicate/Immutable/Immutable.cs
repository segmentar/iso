using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportableconfigurationImmutable
    {
        public static readonly Int32 BoundaryStart;

        public static readonly Int32 BoundarySize;

        public static readonly Object WriterEncodingObject;

        public static readonly Object ReaderEncodingObject;

        public static readonly Object WriterRemoteEncodingObject;

        public static readonly Object ReaderRemoteEncodingObject;

        public static readonly Object FileStreamWriterEncoding;

        public static readonly Object FileStreamReaderEncoding;

        static ExpressionxportableconfigurationImmutable()
        {
            BoundaryStart = ExpressionxportableconfigurationDefault.BoundaryStartDefault;

            BoundarySize = ExpressionxportableconfigurationDefault.BoundarySizeDefalut;

            WriterEncodingObject = ExpressionxportableconfigurationDefault.WriterEncodingObjectDefault;

            ReaderEncodingObject = ExpressionxportableconfigurationDefault.ReaderEncodingObjectDefault;

            WriterRemoteEncodingObject = ExpressionxportableconfigurationDefault.WriterRemoteEncodingObjectDefault;

            ReaderRemoteEncodingObject = ExpressionxportableconfigurationDefault.ReaderRemoteEncodingOBjectDefault;

            FileStreamWriterEncoding = ExpressionxportableconfigurationDefault.FileStreamWriterEncodingDefault;

            FileStreamReaderEncoding = ExpressionxportableconfigurationDefault.FileStreamReaderEncodingDefault;

            return;
        }
    }
}

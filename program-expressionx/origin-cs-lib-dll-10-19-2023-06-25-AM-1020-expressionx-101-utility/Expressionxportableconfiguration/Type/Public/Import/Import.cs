using Core;

namespace Core
{
    using System;

    public partial struct Expressionxportableconfiguration
    {
        public static void Import(Expressionxportableconfiguration value_EXPRESSIONXPORTABLECONFIGURATION)
        {
            Expressionxportable.BoundaryStart = value_EXPRESSIONXPORTABLECONFIGURATION.BoundaryStart;

            Expressionxportable.BoundarySize = value_EXPRESSIONXPORTABLECONFIGURATION.BoundarySize;

            Expressionxportable.WriterEncodingObject = value_EXPRESSIONXPORTABLECONFIGURATION.WriterEncodingObject;

            Expressionxportable.ReaderEncodingObject = value_EXPRESSIONXPORTABLECONFIGURATION.ReaderEncodingObject;

            Expressionxportable.WriterRemoteEncodingObject = value_EXPRESSIONXPORTABLECONFIGURATION.WriterRemoteEncodingObject;

            Expressionxportable.ReaderRemoteEncodingObject = value_EXPRESSIONXPORTABLECONFIGURATION.ReaderRemoteEncodingObject;

            Expressionxportable.FileStreamWriterEncoding = value_EXPRESSIONXPORTABLECONFIGURATION.FileStreamWriterEncoding;

            Expressionxportable.FileStreamReaderEncoding = value_EXPRESSIONXPORTABLECONFIGURATION.FileStreamReaderEncoding;

            return;
        }
    }
}

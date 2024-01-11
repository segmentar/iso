using Core;

namespace Core
{
    using System;

    public partial struct Expressionxportableconfiguration
    {
        public static Expressionxportableconfiguration Copy(Expressionxportableconfiguration value_EXPRESSIONXPORTABLECONFIGURATION)
        {
            Expressionxportableconfiguration expressionxportableconfigurationResult = default;

            Expressionxportableconfiguration expressionxportableconfiguration;

            expressionxportableconfiguration = new Expressionxportableconfiguration();

            expressionxportableconfiguration.BoundaryStart = value_EXPRESSIONXPORTABLECONFIGURATION.BoundaryStart;

            expressionxportableconfiguration.BoundarySize = value_EXPRESSIONXPORTABLECONFIGURATION.BoundarySize;

            expressionxportableconfiguration.WriterEncodingObject = value_EXPRESSIONXPORTABLECONFIGURATION.WriterEncodingObject;

            expressionxportableconfiguration.ReaderEncodingObject = value_EXPRESSIONXPORTABLECONFIGURATION.ReaderEncodingObject;

            expressionxportableconfiguration.WriterRemoteEncodingObject = value_EXPRESSIONXPORTABLECONFIGURATION.WriterRemoteEncodingObject;

            expressionxportableconfiguration.ReaderRemoteEncodingObject = value_EXPRESSIONXPORTABLECONFIGURATION.ReaderRemoteEncodingObject;

            expressionxportableconfiguration.FileStreamWriterEncoding = value_EXPRESSIONXPORTABLECONFIGURATION.FileStreamWriterEncoding;

            expressionxportableconfiguration.FileStreamReaderEncoding = value_EXPRESSIONXPORTABLECONFIGURATION.FileStreamReaderEncoding;

            expressionxportableconfigurationResult = expressionxportableconfiguration;

            return expressionxportableconfigurationResult;
        }
    }
}

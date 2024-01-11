using Core;

namespace Core
{
    using System;

    public partial struct Expressionxportableconfiguration
    {
        public static Expressionxportableconfiguration Export()
        {
            Expressionxportableconfiguration expressionxportableconfigurationResult = default;

            Expressionxportableconfiguration expressionxportableconfiguration;

            expressionxportableconfiguration = new Expressionxportableconfiguration();

            expressionxportableconfiguration.BoundaryStart = Expressionxportable.BoundaryStart;

            expressionxportableconfiguration.BoundarySize = Expressionxportable.BoundarySize;

            expressionxportableconfiguration.WriterEncodingObject = Expressionxportable.WriterEncodingObject;

            expressionxportableconfiguration.ReaderEncodingObject = Expressionxportable.ReaderEncodingObject;

            expressionxportableconfiguration.WriterRemoteEncodingObject = Expressionxportable.WriterRemoteEncodingObject;

            expressionxportableconfiguration.ReaderRemoteEncodingObject = Expressionxportable.ReaderRemoteEncodingObject;

            expressionxportableconfiguration.FileStreamWriterEncoding = Expressionxportable.FileStreamWriterEncoding;

            expressionxportableconfiguration.FileStreamReaderEncoding = Expressionxportable.FileStreamReaderEncoding;

            expressionxportableconfigurationResult = expressionxportableconfiguration;

            return expressionxportableconfigurationResult;
        }
    }
}

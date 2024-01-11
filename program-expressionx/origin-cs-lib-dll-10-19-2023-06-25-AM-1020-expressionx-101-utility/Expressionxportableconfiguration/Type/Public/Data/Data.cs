using Core;

namespace Core
{
    using System;

    public partial struct Expressionxportableconfiguration
    {
        public static Expressionxportableconfiguration Data()
        {
            Expressionxportableconfiguration expressionxportableconfigurationResult = default;

            Expressionxportableconfiguration expressionxportableconfiguration;

            expressionxportableconfiguration = new Expressionxportableconfiguration();

            expressionxportableconfiguration.BoundaryStart = ExpressionxportableconfigurationImmutable.BoundaryStart;

            expressionxportableconfiguration.BoundarySize = ExpressionxportableconfigurationImmutable.BoundarySize;

            expressionxportableconfiguration.WriterEncodingObject = ExpressionxportableconfigurationImmutable.WriterEncodingObject;

            expressionxportableconfiguration.ReaderEncodingObject = ExpressionxportableconfigurationImmutable.ReaderEncodingObject;

            expressionxportableconfiguration.WriterRemoteEncodingObject = ExpressionxportableconfigurationImmutable.WriterRemoteEncodingObject;

            expressionxportableconfiguration.ReaderRemoteEncodingObject = ExpressionxportableconfigurationImmutable.ReaderRemoteEncodingObject;

            expressionxportableconfiguration.FileStreamWriterEncoding = ExpressionxportableconfigurationImmutable.FileStreamWriterEncoding;

            expressionxportableconfiguration.FileStreamReaderEncoding = ExpressionxportableconfigurationImmutable.FileStreamReaderEncoding;

            expressionxportableconfigurationResult = expressionxportableconfiguration;

            return expressionxportableconfigurationResult;
        }
    }
}

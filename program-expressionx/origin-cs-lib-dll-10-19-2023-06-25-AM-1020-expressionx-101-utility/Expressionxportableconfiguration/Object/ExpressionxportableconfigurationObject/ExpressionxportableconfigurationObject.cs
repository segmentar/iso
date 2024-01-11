using Core;

namespace Core
{
    using System;

    public partial struct Expressionxportableconfiguration
    {
        [Expressionxportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Expressionxportableconfiguration) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(BoundaryStart) + ':' + ' ' + BoundaryStart,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(BoundarySize) + ':' + ' ' + BoundarySize,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(WriterEncodingObject) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(ReaderEncodingObject) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(WriterRemoteEncodingObject) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(ReaderRemoteEncodingObject) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(FileStreamWriterEncoding) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "08" + ' ' + nameof(FileStreamReaderEncoding) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(WriterEncodingObject) + ':',
                String.Empty + WriterEncodingObject,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(ReaderEncodingObject) + ':',
                String.Empty + ReaderEncodingObject,
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(WriterRemoteEncodingObject) + ':',
                String.Empty + WriterRemoteEncodingObject,
                String.Empty,
                String.Empty + '~' + "40" + ' ' + nameof(ReaderRemoteEncodingObject) + ':',
                String.Empty + ReaderRemoteEncodingObject,
                String.Empty,
                String.Empty + '~' + "50" + ' ' + nameof(FileStreamWriterEncoding) + ':',
                String.Empty + FileStreamWriterEncoding,
                String.Empty,
                String.Empty + '~' + "60" + ' ' + nameof(FileStreamReaderEncoding) + ':',
                String.Empty + FileStreamReaderEncoding
            });
        }
    }
}

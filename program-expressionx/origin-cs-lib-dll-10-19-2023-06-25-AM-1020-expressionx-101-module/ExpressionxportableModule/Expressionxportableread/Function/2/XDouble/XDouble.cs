using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class ExpressionxportablereadModule
    {
        [Expressionxportableisc]
        public partial class XDouble
        {
            public BinaryReader BinaryReader;
                
            public Expressionxportablelayout Expressionxportablelayout;

            public XDouble(BinaryReader binaryReader, Expressionxportablelayout expressionxportablelayout)
            {
                this.BinaryReader = binaryReader;

                this.Expressionxportablelayout = expressionxportablelayout;

                return;
            }

            ~XDouble()
            {
                return;
            }

            [Expressionxportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {
                
                    String.Empty + nameof(XDouble) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(BinaryReader) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(Expressionxportablelayout) + ':' + ' ' + ". . .",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(BinaryReader) + ':',
                    String.Empty + BinaryReader,
                    String.Empty,
                    String.Empty + '~' + "20" + ' ' + nameof(Expressionxportablelayout) + ':',
                    String.Empty + Expressionxportablelayout
                });
            }
        }
    }
}

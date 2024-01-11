using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class ExpressionxportablereadModule
    {
        [Expressionxportableisc]
        public partial class XQuadruple
        {
            public BinaryReader BinaryReader;

            public ExpressionxportablebuildUlev_lV[] LevelArray;

            public XQuadruple(BinaryReader binaryReader, ExpressionxportablebuildUlev_lV[] levelArray)
            {
                this.BinaryReader = binaryReader;

                this.LevelArray = levelArray;

                return;
            }

            ~XQuadruple()
            {
                return;
            }

            [Expressionxportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(XQuadruple) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(BinaryReader) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(LevelArray) + ':' + ' ' + ". . ." + ' ' + $"<{LevelArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(BinaryReader) + ':',
                    String.Empty + BinaryReader,
                    String.Empty,
                    String.Empty + '~' + "20" + ' ' + nameof(LevelArray) + ':',
                    String.Empty + String.Join('\n'.ToString(), LevelArray)
                });
            }
        }
    }
}

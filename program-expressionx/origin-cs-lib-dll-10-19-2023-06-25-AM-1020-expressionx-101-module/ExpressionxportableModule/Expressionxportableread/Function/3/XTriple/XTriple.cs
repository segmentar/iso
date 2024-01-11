using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class ExpressionxportablereadModule
    {
        [Expressionxportableisc]
        public partial class XTriple
        {
            public BinaryReader BinaryReader;

            public ExpressionxportablebuildUle_elV[] LevelArray;

            public XTriple(BinaryReader binaryReader, ExpressionxportablebuildUle_elV[] levelArray)
            {
                this.BinaryReader = binaryReader;

                this.LevelArray = levelArray;

                return;
            }

            ~XTriple()
            {
                return;
            }

            [Expressionxportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(XTriple) + ' ' + "::" + ' ' + '{',
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

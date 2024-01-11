using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        [Expressionxportableisc]
        public partial class XSentuple
        {
            public ExpressionxportablebuildUl_velV[] LevelArray;

            public XSentuple(ExpressionxportablebuildUl_velV[] levelArray)
            {
                this.LevelArray = levelArray;

                return;
            }

            XSentuple()
            {
                return;
            }

            [Expressionxportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] { 
                
                    String.Empty + nameof(XSentuple) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(LevelArray) + ':' + ' ' + ". . ." + ' ' + $"<{LevelArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(LevelArray) + ':',
                    String.Empty + String.Join('\n'.ToString(), LevelArray)
                });
            }
        }
    }
}

using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablereadModule
    {
        [Expressionxportableisc]
        public partial class XQuintuple
        {
            public ExpressionxportablebuildUlev_lV Level;

            public XQuintuple(ExpressionxportablebuildUlev_lV level)
            {
                this.Level = level;

                return;
            }

            ~XQuintuple()
            {
                return;
            }

            [Expressionxportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(XQuintuple) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(Level) + ':' + ' ' + ". . .",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(Level) + ':',
                    String.Empty + Level
                });
            }
        }
    }
}

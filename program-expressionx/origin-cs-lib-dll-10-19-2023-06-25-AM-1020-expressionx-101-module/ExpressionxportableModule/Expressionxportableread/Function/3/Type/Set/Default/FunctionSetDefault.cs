using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Text;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ExpressionxportablereadModule
    {
        public partial class XTriple
        {
            public static IList<ExpressionxportablebuildUle_elV> FunctionDefaultSet(BinaryReader value_BINARYREADER, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT)
            {
                ICollection<ExpressionxportablebuildUle_elV> collectionResult = default;

                collectionResult = new Collection<ExpressionxportablebuildUle_elV>();

                var indexer = 0;

                do
                {
                    Boolean shouldBreakCheck;

                    shouldBreakCheck = Object.Equals(value_EXPRESSIONXPORTABLELAYOUT.ExpressionCount, indexer) is true;

                    if (shouldBreakCheck is true)
                    {
                        break;
                    }
                    else
                        "false".ToString();

                    var position = 0;

                    position = position + value_EXPRESSIONXPORTABLELAYOUT.StartAddressSubjectTable;

                    position = position + (indexer * Expressionxportable.BoundarySize);

                    value_BINARYREADER.BaseStream.Seek(position, SeekOrigin.Begin);

                    ExpressionxportablebuildUle_elV level;

                    level = new ExpressionxportablebuildUle_elV();

                    level.Ordinal = Convert.ToInt32(value_BINARYREADER.ReadUInt32());

                    level.Layer = Convert.ToInt32(value_BINARYREADER.ReadUInt32());

                    level.Relation = Convert.ToInt32(value_BINARYREADER.ReadUInt32());

                    level.ObjectStartAddress = Convert.ToInt32(value_BINARYREADER.ReadUInt32());

                    level.ObjectEndAddress = Convert.ToInt32(value_BINARYREADER.ReadUInt32());

                    level.TypeStartAddress = Convert.ToInt32(value_BINARYREADER.ReadUInt32());

                    level.TypeEndAddress = Convert.ToInt32(value_BINARYREADER.ReadUInt32());

                    level.Value = value_BINARYREADER.ReadString();

                    var inflect = new Object[2];

                    inflect[0] = ((level.ObjectEndAddress - level.ObjectStartAddress) + 1);

                    inflect[1] = ((level.TypeEndAddress - level.TypeStartAddress) + 1);

                    value_BINARYREADER.BaseStream.Seek(level.ObjectStartAddress, SeekOrigin.Begin);

                    level.RemoteArray = value_BINARYREADER.ReadBytes((Int32)inflect[0]);

                    value_BINARYREADER.BaseStream.Seek(level.TypeStartAddress, SeekOrigin.Begin);

                    level.Type = ((Encoding)Expressionxportable.ReaderEncodingObject).GetString(value_BINARYREADER.ReadBytes((Int32)inflect[1]));

                    collectionResult.Add(level);

                    indexer = indexer + 1;

                    continue;

                } while (true);

                return new List<ExpressionxportablebuildUle_elV>(collectionResult);
            }
        }
    }
}

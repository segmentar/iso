using Core;

namespace Core
{
    using System;

    public partial class Expressionxportable
    {
        public static Int32 BoundaryStart;

        public static Int32 BoundarySize;

        public static Object WriterEncodingObject;

        public static Object ReaderEncodingObject;

        public static Object WriterRemoteEncodingObject;

        public static Object ReaderRemoteEncodingObject;

        public static Object FileStreamWriterEncoding;

        public static Object FileStreamReaderEncoding;
    }
}

namespace Core
{
    using System;

    public partial class Expressionxportable
    {
        public static Object LockObject = new Object();

        public static Object ScheduleArrayListObject = Expressionxportablemagic.ExpressionxportablemagicArrayListDispenser(new Object[0]);

        public static Object ExecuteLinkedListObject = Expressionxportablemagic.ExpressionxportablemagicLinkedListDispenser(new Object[0]);

        public static Object ParameterArrayListObject = Expressionxportablemagic.ExpressionxportablemagicArrayListDispenser(new Object[0]);

        public static Object ViewLinkedListObject = Expressionxportablemagic.ExpressionxportablemagicLinkedListDispenser(new Object[0]);

        public static Object EnumeratorObject = new Object();

        public static Object FileStreamArrayListObject = Expressionxportablemagic.ExpressionxportablemagicArrayListDispenser(new Object[0]);

        public static Object FileStreamObject = new Object();

        public static Object SeekOriginObject = new Object();

        public static Object InternalSelfObject = new Object();

        public static Object ContributeObject = new Object();

        public static Object SpaceObject = new Object();
    }
}
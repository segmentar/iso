using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Runtime.Serialization;

    using System.Runtime.Serialization.Formatters;

    using System.Runtime.Serialization.Formatters.Binary;

    public partial class Expressionxportableremotein
    {
        public static void GroupObject(Expressionxportable value_EXPRESSIONXPORTABLE)
        {
            Boolean isEqualCheck, shouldReturnCheck;

            isEqualCheck = Attribute.IsDefined(value_EXPRESSIONXPORTABLE.ObjectIdentity.GetType(), typeof(SerializableAttribute)) is true;

            shouldReturnCheck = isEqualCheck is false;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            MemoryStream memoryStream;

            memoryStream = new MemoryStream();

            using (memoryStream)
            {
                IFormatter formatter;

                formatter = new BinaryFormatter();

                formatter.Serialize(memoryStream, value_EXPRESSIONXPORTABLE.ObjectIdentity);

                var array = memoryStream.ToArray();

                value_EXPRESSIONXPORTABLE.RemoteArrayObject = array;

                memoryStream.Close();

                memoryStream.Dispose();
            }

            return;
        }
    }
}

using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Expressionxportable
    {
        public static IList<Object> FunctionSetFilesystem(Expressionxportable value_EXPRESSION, String LastName__VALUE, Boolean answer_SELF_should)
        {
            ICollection<Object> collectionResult = default;

            collectionResult = new Collection<Object>();

            var name = value_EXPRESSION.StringIdentity.StringValue;

            var zee = (LastName__VALUE + name);

            if (answer_SELF_should is true)
            {
                var value = ((value_EXPRESSION.ObjectIdentity == default) ? new Object() : value_EXPRESSION.ObjectIdentity);

                var CurrentDirectory_PATH = Directory.GetCurrentDirectory();

                var result = Path.Combine(CurrentDirectory_PATH, LastName__VALUE, name);

                if (Object.Equals(typeof(Expressionfilesystemfile), value.GetType()))
                {
                    FileInfo fileInfo;

                    fileInfo = new FileInfo(result);

                    collectionResult.Add(fileInfo);
                }
                else
                {
                    DirectoryInfo directoryInfo;

                    directoryInfo = new DirectoryInfo(result);

                    collectionResult.Add(directoryInfo);
                }
            }
            else
                "false".ToString();

            foreach (Expressionxportable expression in Interop.InteropArrayListCastDispenser(value_EXPRESSION.LayerArrayListObject))
            {
                var array = FunctionSetFilesystemSurface(expression, zee, answer_SELF_should);

                foreach (Object value in array)
                {
                    collectionResult.Add(value);

                    continue;
                }

                continue;
            }

            return new List<Object>(collectionResult);
        }
    }
}

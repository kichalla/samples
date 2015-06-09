using System;
using System.IO;
using System.Runtime.Serialization;

namespace AppSupportingCoreClr
{
    public static class MyXmlSerializer
    {
        public static string GetXml(Type type, Object obj)
        {
            var dcs = new DataContractSerializer(type);
            var ms = new MemoryStream();
            dcs.WriteObject(ms, obj);
            ms.Position = 0;
            var reader = new StreamReader(ms);

            return reader.ReadToEnd();
        }
    }
}

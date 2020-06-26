using System;
using System.Xml.Linq;

namespace Project1
{
    public class ConfigManager
    {
        private static string configFileName = @"Config.xml";
        public static string GetValue(params string[] args)
        {
            string result = string.Empty;

            try
            {
                XDocument xDoc = XDocument.Load(configFileName);
                result = GetNodeValue(xDoc.FirstNode as XElement, 0, args);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                result = string.Empty;
            }

            return result;
        }

        private static string GetNodeValue(XElement node, int idx, params string[] args)
        {
            string result = string.Empty;
            if (args.Length > idx + 1)
                result = GetNodeValue(node.Element(args[idx]), ++idx, args);
            else
                result = node.Element(args[idx]).Value.ToString();
            return result;
        }
    }
}

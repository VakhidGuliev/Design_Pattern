using Strategy.Strategy.DOCUMENT.Strategy.Implement;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Strategy.DOCUMENT
{
    public  class Document
    {
        private readonly IFormatStrategy formatStrategy;
        StringBuilder builder;
        public Document(DocumentFormat format)
        {
            builder = new StringBuilder();

            switch (format)
            {
                case DocumentFormat.XML:
                    formatStrategy = new Xml();
                    break;
                case DocumentFormat.JSON:
                    formatStrategy = new Json();
                    break;
                default:
                    break;
            }
            formatStrategy.Init(builder);
        }
        public Document Append(string title, string value)
        {
            formatStrategy.AddElement(builder, title, value);
            return this;
        }
        public string Save()
        {
            formatStrategy.Close(builder);
            return builder.ToString();
        }
        public static string Convert(Dictionary<string, string> dic, IFormatStrategy formatStrategy)
        {
            StringBuilder t = new StringBuilder();
            formatStrategy.Init(t);

            foreach (var item in dic)
            {
                formatStrategy.AddElement(t, item.Key, item.Value);
            }

            formatStrategy.Close(t);
            return t.ToString();
        }

    }
}

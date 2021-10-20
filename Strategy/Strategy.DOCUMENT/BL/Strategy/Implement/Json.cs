using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Strategy.DOCUMENT.Strategy.Implement
{
    public class Json : IFormatStrategy
    {
        public static Json Provider = new Json();
        public void AddElement(StringBuilder sb, string title, string value)
        {
            sb.Append($"  '{title}': '{value}',\n");
        }

        public void Close(StringBuilder sb)
        {
            sb.Append('}');
        }

        public void Init(StringBuilder sb)
        {
            sb.Append("{\n");
        }
    }
}

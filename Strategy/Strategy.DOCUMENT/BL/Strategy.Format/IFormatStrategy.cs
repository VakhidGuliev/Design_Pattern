using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Strategy.DOCUMENT
{
   public interface IFormatStrategy
    {
        void Init(StringBuilder sb);
        void AddElement(StringBuilder sb, string title, string value);
        void Close(StringBuilder sb);
    }
}

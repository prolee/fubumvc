using System.Collections.Generic;

namespace FubuMVC.Core.Runtime.Formatters
{
    public interface IFormatter
    {
        IEnumerable<string> MatchingMimetypes { get; }
        void Write<T>(T target, string mimeType);
        T Read<T>();
    }
}
using System.Collections.Generic;

namespace Section03 {
    internal interface IAbbreviations {
        string this[string abbr] { get; }

        int Count {
            get;
        }

        void Add(string abbr, string japanese);
        IEnumerable<KeyValuePair<string, string>> FindAll(string substring);
        bool Remove(string abb);
        string ToAbbreviation(string japanese);
    }
}
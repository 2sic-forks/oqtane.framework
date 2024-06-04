using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Oqtane.Models;

namespace Oqtane.Services
{
    public interface ISearchIndexManager
    {
        int Priority { get; }

        string Name { get; }

        bool IsIndexEnabled(int siteId);

        int IndexContent(int siteId, DateTime? startTime, Action<IList<SearchContent>> processSearchContent, Action<string> handleError);
    }
}

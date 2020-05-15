
using IocDemo.Core.Enum;

namespace IocDemo.Core
{
    public class GridParameter
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }

        public string SortColumn { get; set; }
        public GridSortOrder SortOrder { get; set; }
    }
}
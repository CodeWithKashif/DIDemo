using System.ComponentModel;

namespace IocDemo.Core.Enum
{
    /// <summary>
    /// Here value for Descending/Ascending is mapped/set according to Prime NG Grid
    /// https://www.primefaces.org/primeng/#/datatable/lazy
    /// event.sortOrder = Sort order as number, 1 for asc and -1 for dec
    /// </summary>
    public enum GridSortOrder
    {
        [Description("ASC")]
        Unspecified = 0,

        [Description("ASC")]
        Ascending = 1,

        [Description("DESC")]
        Descending = -1,
    }
}
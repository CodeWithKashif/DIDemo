using IocDemo.Core.Enum;

namespace IocDemo.Core.DomainModel
{
    public class ProgramYear : TEntity
    {
        public ProgramType ProgramType { get; set; }
        public string ProgramYearName { get; set; }
        public int MinimumNumberOfSession { get; set; }
        public int MidRangeStartNumber { get; set; }
        public int MidRangeEndNumber { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}

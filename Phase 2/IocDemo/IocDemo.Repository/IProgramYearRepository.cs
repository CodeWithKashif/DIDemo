using System.Collections.Generic;
using IocDemo.Core;
using IocDemo.Core.DomainModel;
using IocDemo.Core.Enum;

namespace IocDemo.Repository
{
    public interface IProgramYearRepository
    {
        ProgramYear Add(ProgramYear programYear);
        void Update(ProgramYear programYear);
        List<ProgramYear> List(ProgramType? programType, bool? isActive, GridParameter filter);
        ProgramYear Get(int id);
    }
}
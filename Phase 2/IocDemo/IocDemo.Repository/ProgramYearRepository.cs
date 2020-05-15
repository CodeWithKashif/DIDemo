using IocDemo.Core;
using IocDemo.Core.Enum;
using System.Collections.Generic;
using IocDemo.Core.DomainModel;

namespace IocDemo.Repository
{
    public class ProgramYearRepository : IProgramYearRepository
    {
        public ProgramYear Add(ProgramYear programYear)
        {
            return new ProgramYear();
        }

        public void Update(ProgramYear programYear)
        {
        }

        public List<ProgramYear> List(ProgramType? programType, bool? isActive, GridParameter filter)
        {
            return new List<ProgramYear>();
        }

        public ProgramYear Get(int id)
        {
            return new ProgramYear {Id = 1, ProgramYearName = "ProgramYearName 1" };
        }
    }
}
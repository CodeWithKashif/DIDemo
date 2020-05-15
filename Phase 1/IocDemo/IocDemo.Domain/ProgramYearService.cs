using IocDemo.Core.DomainModel;
using IocDemo.Repository;
using IocDemo.ViewModel;

namespace IocDemo.Domain
{
    public class ProgramYearService: IProgramYearService
    {
        private readonly IProgramYearRepository _programYearRepository;

        public ProgramYearService(IProgramYearRepository programYearRepository)
        {
            _programYearRepository = programYearRepository;
        }

        public ApiResult Add(ProgramYearAddUpdate model)
        {
            return new ApiResult { IsSuccess = true };
        }

        public ApiResult Update(ProgramYearAddUpdate model)
        {
            return new ApiResult {IsSuccess = true};
        }

        public GridResult List(ProgramYearList model)
        {
            return new GridResult();
        }

        public ProgramYearViewModel Get(int id)
        {
            ProgramYear programYear = _programYearRepository.Get(id);
            return new ProgramYearViewModel {Id = programYear.Id, ProgramYearName = programYear.ProgramYearName};
        }
    }
}

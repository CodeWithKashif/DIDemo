using IocDemo.ViewModel;

namespace IocDemo.Domain
{
    public interface IProgramYearService
    {
        ApiResult Add(ProgramYearAddUpdate model);
        ApiResult Update(ProgramYearAddUpdate model);
        GridResult List(ProgramYearList model);
        ProgramYearViewModel Get(int id);

    }
}
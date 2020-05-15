using IocDemo.Domain;
using IocDemo.ViewModel;
using System.Web.Http;

namespace IocDemo.Api.Controllers
{
    public class ProgramYearController : ApiController
    {
        private readonly IProgramYearService _programYearService;

        public ProgramYearController(IProgramYearService programYearService)
        {
            _programYearService = programYearService;
        }

        [HttpPost]
        [Route("api/ProgramYear/Add")]
        public IHttpActionResult Add(ProgramYearAddUpdate model)
        {
            ApiResult result = _programYearService.Add(model);
            return Ok(result);
        }

        [HttpPost]
        [Route("api/ProgramYear/Update")]
        public IHttpActionResult Update(ProgramYearAddUpdate model)
        {

            ApiResult result = _programYearService.Update(model);
            return Ok(result);
        }

        //[Authorize]
        [HttpGet]
        [Route("api/ProgramYear/View/{id}")]
        public IHttpActionResult View(int id)
        {
            ProgramYearViewModel result = _programYearService.Get(id);
            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [Authorize]
        [HttpGet]
        [Route("api/ProgramYear/ViewTest/{id}")]
        public IHttpActionResult ViewTest(int id)
        {
            ProgramYearViewModel result = _programYearService.Get(id);
            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet]
        [Route("api/ProgramYear/Edit/{id}")]
        public IHttpActionResult Edit(int id)
        {
            ProgramYearViewModel result = _programYearService.Get(id);
            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/ProgramYear/List")]
        public IHttpActionResult List(ProgramYearList model)
        {
            GridResult result = _programYearService.List(model);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

    }
}

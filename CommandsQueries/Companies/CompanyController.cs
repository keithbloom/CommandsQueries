using System.Net.Http;
using System.Web.Http;

namespace CommandsQueries.Companies
{
    public class CompanyController : ApiController
    {
        readonly IMediator _mediator;

        public CompanyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public HttpResponseMessage Get(int companyId)
        {
            var query = new SearchForCompanyDetails
                {
                    CompanyId = companyId
                };
            var result = _mediator.Request(query);
            return Request.CreateResponse(result);
        }

        public HttpResponseMessage Post(AddCompanyCommand command)
        {
            _mediator.Send(command);
            return Request.CreateResponse();
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using BestEmployeePoll.Shared.Resources;
using Core.Server.Web.Controllers;

namespace BestEmployeePoll.Web.Controllers
{
    public class PollVoteController : 
        RestController<PollVoteCreateResource, PollVoteUpdateResource, PollVoteResource>
    {
    }
}
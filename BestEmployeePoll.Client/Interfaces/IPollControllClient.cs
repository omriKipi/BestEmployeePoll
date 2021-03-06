using BestEmployeePoll.Shared.Resources;
using Core.Server.Client.Interfaces;

namespace BestEmployeePoll.Standard.Client.Interfaces
{
    public interface IPollControllClient :
        IRestClient<PollCreateResource,PollUpdateResource, PollResource>
    {
    }
}

using BestEmployeePoll.Shared.Resources;
using Core.Server.Common.Applications;
using System.Threading.Tasks;

namespace BestEmployeePoll.Common.Applications
{
    public interface IPollGroupsApplication : IRestApplication<PollGroupCreateResource, PollGroupResource>
    {
        Task<bool> AreInSameVoteGroup(string pollId, params string[] emplyees);
    }
}

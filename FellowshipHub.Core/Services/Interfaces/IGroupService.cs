using FellowshipHub.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowshipHub.Core.Services.Interfaces
{
    public interface IGroupService
    {
        Task<ApiResponse<List<SmallGroup>>> GetUserGroupsAsync();
        Task<ApiResponse<SmallGroup>> GetGroupAsync(Guid groupId);
        Task<ApiResponse<SmallGroup>> CreateGroupAsync(SmallGroup group);
        Task<ApiResponse<SmallGroup>> UpdateGroupAsync(SmallGroup group);
        Task<ApiResponse<bool>> DeleteGroupAsync(Guid groupId);
        Task<ApiResponse<bool>> JoinGroupAsync(Guid groupId);
        Task<ApiResponse<bool>> JoinGroupByInviteCodeAsync(string inviteCode);
        Task<ApiResponse<bool>> LeaveGroupAsync(Guid groupId);
        Task<ApiResponse<List<GroupMember>>> GetGroupMembersAsync(Guid groupId);
        Task<ApiResponse<bool>> UpdateMemberRoleAsync(Guid groupId, Guid userId, GroupRole role);
        Task<ApiResponse<bool>> RemoveMemberAsync(Guid groupId, Guid userId);
    }
}

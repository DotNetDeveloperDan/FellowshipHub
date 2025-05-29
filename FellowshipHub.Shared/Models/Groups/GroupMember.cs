using FellowshipHub.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FellowshipHub.Shared.Models.Groups
{
    [Table("GroupMembers")]
    public class GroupMember : BaseEntity
    {
        [JsonPropertyName("groupId")]
        public Guid GroupId { get; set; }

        [JsonPropertyName("userId")]
        public Guid UserId { get; set; }

        [JsonPropertyName("role")]
        public GroupRole Role { get; set; } = GroupRole.Member;

        [JsonPropertyName("joinedAt")]
        public DateTime JoinedAt { get; set; } = DateTime.UtcNow;

        [JsonPropertyName("isApproved")]
        public bool IsApproved { get; set; } = true;
    }
}

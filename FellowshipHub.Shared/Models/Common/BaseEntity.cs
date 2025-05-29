using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FellowshipHub.Shared.Models.Common
{
    public abstract class BaseEntity
    {
        // Primary key
        [PrimaryKey]
        [JsonPropertyName("id")]
        public Guid Id { get; set; } = Guid.NewGuid();

        // When the record was created (UTC)
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // When it was last updated (UTC), if ever
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        // Who created it (e.g. user ID or system)
        [JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

        // Who last updated it
        [JsonPropertyName("updatedBy")]
        public string? UpdatedBy { get; set; }

        // Soft-delete flag (so we can “hide” records without hard-deleting)
        [JsonPropertyName("isDeleted")]
        public bool IsDeleted { get; set; } = false;
    }

}

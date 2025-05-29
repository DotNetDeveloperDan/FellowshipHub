using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowshipHub.Core.Services.Interfaces
{
    public interface IChatService
    {
        Task<ApiResponse<List<Message>>> GetGroupMessagesAsync(Guid groupId, int page = 1, int pageSize = 50);
        Task<ApiResponse<List<Message>>> GetPrivateMessagesAsync(Guid userId, int page = 1, int pageSize = 50);
        Task<ApiResponse<Message>> SendMessageAsync(Message message);
        Task<ApiResponse<bool>> MarkMessageAsReadAsync(Guid messageId);
        Task<ApiResponse<bool>> DeleteMessageAsync(Guid messageId);
        Task<ApiResponse<Message>> EditMessageAsync(Guid messageId, string newContent);
        Task StartListeningForMessagesAsync();
        Task StopListeningForMessagesAsync();
        event EventHandler<Message>? MessageReceived;
        event EventHandler<Message>? MessageUpdated;
        event EventHandler<Guid>? MessageDeleted;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowshipHub.Shared.Constants
{
    public static class AppConstants
    {
        public static class Api
        {
            public const string BaseUrl = "https://fellowshiphub-api.azurewebsites.net";
            public const string SignalRUrl = "https://fellowshiphub-signalr.service.signalr.net";
            public const int TimeoutSeconds = 30;
        }

        public static class Cache
        {
            public const int DefaultCacheMinutes = 15;
            public const int UserCacheMinutes = 60;
            public const int GroupCacheMinutes = 30;
        }

        public static class Database
        {
            public const string LocalDbName = "FellowshipHub.db3";
            public const int SyncIntervalMinutes = 5;
        }

        public static class Limits
        {
            public const int MaxMessageLength = 2000;
            public const int MaxGroupNameLength = 100;
            public const int MaxGroupDescriptionLength = 500;
            public const int MaxFileSize = 10 * 1024 * 1024; // 10MB
        }
    }
}

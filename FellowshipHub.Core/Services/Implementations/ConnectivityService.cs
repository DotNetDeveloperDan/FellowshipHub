using FellowshipHub.Core.Services.Interfaces;
using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace FellowshipHub.Core.Services.Implementations
{
    public class ConnectivityService : IConnectivityService
    {
        public bool IsConnected => Connectivity.NetworkAccess == NetworkAccess.Internet;

        public event EventHandler<bool>? ConnectivityChanged;

        public ConnectivityService()
        {
            Connectivity.ConnectivityChanged += OnConnectivityChanged;
        }

        public async Task<bool> CheckConnectivityAsync()
        {
            try
            {
                var networkAccess = Connectivity.NetworkAccess;
                return networkAccess == NetworkAccess.Internet;
            }
            catch
            {
                return false;
            }
        }

        private void OnConnectivityChanged(object? sender, ConnectivityChangedEventArgs e)
        {
            var isConnected = e.NetworkAccess == NetworkAccess.Internet;
            ConnectivityChanged?.Invoke(this, isConnected);
        }
    }
}

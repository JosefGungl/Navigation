public sealed class NetworkConnection
{
    public static bool IsConnected { get; set; }
    public delegate void OnNetworkStatusChange(bool IsConnected);
    public static event OnNetworkStatusChange? NetworkStatusChanged = null;
    public static readonly NetworkConnection Instance = new NetworkConnection();

    private NetworkConnection()
    {
        IsConnected = Connectivity.Current.NetworkAccess != NetworkAccess.None;

        Connectivity.Current.ConnectivityChanged += Connectivity_ConnectivityChanged;

        void Connectivity_ConnectivityChanged(object? sender, ConnectivityChangedEventArgs e)
        {
            IsConnected = e.NetworkAccess == NetworkAccess.None;
            NetworkStatusChanged?.Invoke(IsConnected);
        }
    }


}
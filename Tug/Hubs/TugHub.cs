using Microsoft.AspNetCore.SignalR;

namespace Tug.Hubs;

public class TugHub : Hub {
    public async Task NewMessage(long username, string message) =>
        await Clients.All.SendAsync("messageReceived, username, message");
}
using Microsoft.AspNetCore.SignalR;
using SignalRChatMessage.Models;

namespace SignalRChatMessage.Service_Hub
{
    public class EmployeeHub:Hub
    {
        public async Task AddEmployee(Employee employee)
        {
            await Clients.All.SendAsync("ReceiveEmployee", employee);
        }
    }
}

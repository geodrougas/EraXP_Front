using System.Net;
using System.Net.Http.Json;
using EraXP_Back.Models.Dto;
using Microsoft.AspNetCore.Components;

namespace EraXp.Frontend.Controller;

public class UserController(
    HttpClient client,
    NavigationManager navManager
)
{
    public event UserDelegate? UserEvent;

    public delegate void UserDelegate(UserDto? dto);
    
    public async Task GetUser()
    {
        try
        {
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, "user");
            HttpResponseMessage response = await client.SendAsync(message);

            if (response.StatusCode == HttpStatusCode.Unauthorized && !navManager.Uri.ToLower().EndsWith("login"))
            {
                navManager.NavigateTo("/login");
                return;
            }

            UserDto? user = await response.Content.ReadFromJsonAsync<UserDto>();
            
            UserEvent?.Invoke(user);
        }
        catch (Exception ex)
        {
            navManager.NavigateTo("/login");
            Console.Write(ex);
            UserEvent?.Invoke(null);
        }
    }
}
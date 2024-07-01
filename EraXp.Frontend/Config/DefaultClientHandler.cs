using System.Net;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Http;

namespace EraXp.Frontend.Config;

public class DefaultClientHandler : DelegatingHandler
{
    private readonly NavigationManager _manager;

    public DefaultClientHandler(NavigationManager manager)
    {
        _manager = manager;
        this.InnerHandler = new HttpClientHandler();
    }
    
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        request.SetBrowserRequestCredentials(BrowserRequestCredentials.Include);
        HttpResponseMessage message = await base.SendAsync(request, cancellationToken);
        
        if (message.StatusCode == HttpStatusCode.Unauthorized && !_manager.Uri.Contains("login"))
            _manager.NavigateTo("login");
        
        if (message.IsSuccessStatusCode && _manager.Uri.Contains("login"))
            _manager.NavigateTo("");

        return message;
    }
}
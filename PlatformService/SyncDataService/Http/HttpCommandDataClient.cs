﻿using PlatformService.Dtos;
using System.Text;
using System.Text.Json;

namespace PlatformService.SyncDataService.Http;

public class HttpCommandDataClient : ICommandDataClient
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;

    public HttpCommandDataClient(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _configuration = configuration;
    }

    public async Task SendPlatformToCommand(PlatformReadDto plat)
    {
        var httpContent = new StringContent(
                       JsonSerializer.Serialize(plat),
                                  Encoding.UTF8,
                                             "application/json");

        var sendTo = _configuration["CommandService:PlatformUrl"];

        var response = await _httpClient.PostAsync(sendTo, httpContent);

        if (response.IsSuccessStatusCode)
        {
            Console.WriteLine("--> Sync POST to CommandService was OK!");
        }
        else
        {
            Console.WriteLine("--> Sync POST to CommandService was NOT OK!");
        }
    }
}

using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace AuthorWebsite.Tests;

public class ContactEmailTests : IClassFixture<WebApplicationFactory<Program>>
{
    private const string ContactEmail = "sgresearchauthorrepo@gmail.com";
    private readonly HttpClient client;

    public ContactEmailTests(WebApplicationFactory<Program> factory)
    {
        client = factory.CreateClient();
    }

    [Fact]
    public async Task HomePageShowsCorrectReaderContactEmail()
    {
        var response = await client.GetAsync("/");
        var html = await response.Content.ReadAsStringAsync();

        response.EnsureSuccessStatusCode();
        Assert.Contains($"href=\"mailto:{ContactEmail}\"", html);
        Assert.Contains($">{ContactEmail}</a>", html);
    }

    [Fact]
    public async Task BooksPageUsesCorrectAuthorContactEmail()
    {
        var response = await client.GetAsync("/Books");
        var html = await response.Content.ReadAsStringAsync();

        response.EnsureSuccessStatusCode();
        Assert.Contains($"href=\"mailto:{ContactEmail}\"", html);
    }
}
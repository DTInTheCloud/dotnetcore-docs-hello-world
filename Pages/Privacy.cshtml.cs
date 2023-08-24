using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs.Specialized;
using Azure.Identity;

namespace dotnetcoresample.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        // connect to blob storage and read blob contents
        BlobServiceClient client = new (
            new Uri($"https://stprivatewebspp.blob.core.windows.net"),
            new DefaultAzureCredential());

        BlobContainerClient containerClient = client.GetBlobContainerClient("test");
        BlobClient blobClient = containerClient.GetBlobClient("TestFileWebApp2.txt");

    }
}


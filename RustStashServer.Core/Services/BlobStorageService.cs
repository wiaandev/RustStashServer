namespace RustStashServer.Core.Services;

using Azure.Storage.Blobs;

public class BlobStorageService
{
    public async Task<string> UploadFile(string containerName, IFormFile file)
    {
        containerName = "rust-stash-container";
        const string connectionString = @"DefaultEndpointsProtocol=https;AccountName=ruststashstorage;AccountKey=wzanScd+JH+LWDcLyF1E5srV0FC/TH7J5MjDoGbcBi59ao5hgD1OkGXb1gEULVpYDZXbKHXXHmPm+AStDOhL2A==;EndpointSuffix=core.windows.net";

        BlobContainerClient blobClientContainer = new BlobContainerClient(connectionString, containerName);

        BlobClient blobClient = blobClientContainer.GetBlobClient(file.FileName);
        var memoryStream = new MemoryStream();
        await file.CopyToAsync(memoryStream);
        memoryStream.Position = 0;
        await blobClient.UploadAsync(memoryStream);
        var path = blobClient.Uri.AbsoluteUri;
        return path;
    }
}
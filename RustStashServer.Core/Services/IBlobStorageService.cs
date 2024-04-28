namespace RustStashServer.Core.Services;

public interface IBlobStorageService
{
    public Task<string> UploadFile(string containerName, IFormFile file);
}
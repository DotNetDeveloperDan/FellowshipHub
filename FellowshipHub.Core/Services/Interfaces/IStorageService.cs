namespace FellowshipHub.Core.Services.Interfaces;

public interface IStorageService
{
    Task<string> UploadImageAsync(Stream imageStream, string fileName);
    Task<string> UploadFileAsync(Stream fileStream, string fileName, string contentType);
    Task<bool> DeleteFileAsync(string fileUrl);
    Task<Stream> DownloadFileAsync(string fileUrl);
    Task<string> GetFileUrlAsync(string fileName);
}
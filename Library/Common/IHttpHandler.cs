namespace Library.Common;

public interface IHttpHandler
{
    Task<T> DeleteAsync<T>(string endpoint, CancellationToken cancellationToken);
    Task<T> GetAsync<T>(string endpoint, CancellationToken cancellationToken);
    Task<T> PostAsync<T>(string endpoint, object payload, CancellationToken cancellationToken);
    Task PostStream(string endpoint, object payload, Action<string> callback);
    Task<T> PutAsync<T>(string endpoint, object payload, CancellationToken cancellationToken);
}
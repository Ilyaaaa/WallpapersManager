using Core.Models;
using Refit;
using System.Threading.Tasks;

namespace Core.Interfaces.Services
{
    public interface IUnsplashApiService
    {
        Task<ApiResponse<Image>> GetRandomImage();
    }
}

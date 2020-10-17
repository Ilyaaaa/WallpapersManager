using Core.Models;
using Refit;
using System.Threading.Tasks;

namespace Core.API
{
    [Headers("Authorization: Client-ID dfac8227201571f39873414fc71c7a0e70155dfda5c2926f9906e72d97693724")]
    interface IUnsplashAPI
    {
        [Get("/photos/random")]
        Task<ApiResponse<Image>> GetRandomImage();
    }
}

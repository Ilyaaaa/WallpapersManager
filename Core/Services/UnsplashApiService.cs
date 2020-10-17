using Core.API;
using Core.Interfaces.Services;
using Core.Models;
using Refit;
using System.Threading.Tasks;

namespace Core.Services
{
    public class UnsplashApiService : IUnsplashApiService
    {
        #region Properties

        private IUnsplashAPI Api;

        #endregion

        #region Constructors

        public UnsplashApiService()
        {
            Api = RestService.For<IUnsplashAPI>("https://api.unsplash.com");
        }

        #endregion

        #region Public functions

        public async Task<ApiResponse<Image>> GetRandomImage() => await Api.GetRandomImage();

        #endregion
    }
}

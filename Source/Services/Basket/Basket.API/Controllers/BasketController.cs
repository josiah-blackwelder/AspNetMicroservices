using Basket.API.Repositories;

namespace Basket.API.Controllers
{
    public class BasketController
    {
        private readonly IBasketRepository _basketRepository;

        public BasketController(IBasketRepository basketRepository)
        {
            _basketRepository = basketRepository;
        }


    }
}

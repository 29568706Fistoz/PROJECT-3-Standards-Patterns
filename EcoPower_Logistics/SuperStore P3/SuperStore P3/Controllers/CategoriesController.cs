using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize]
public class CategoriesController : Controller
{
    private readonly ProductRepository _productsRepository;

    public CategoriesController(ProductRepository productsRepository)
    {
        _productsRepository = productsRepository;
    }

}

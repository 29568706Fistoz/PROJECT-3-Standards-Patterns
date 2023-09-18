using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize]
public class ZonesController : Controller
{
    private readonly CustomerRepository _customersRepository;

    public ZonesController(CustomerRepository customersRepository)
    {
        _customersRepository = customersRepository;
    }

}

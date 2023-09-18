using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize]
public class DevicesController : Controller
{
    private readonly OrderRepository _ordersRepository;

    public DevicesController(OrderRepository ordersRepository)
    {
        _ordersRepository = ordersRepository;
    }

}

using APBD_04.Model;
using APBD_04.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_04.Controlers;

[Route("api/[controller]")]
[ApiController]
public class WarehouseController : ControllerBase
{
    private IWarehouseService _warehouseService;

    public WarehouseController(IWarehouseService warehouseService)
    {
        _warehouseService = warehouseService;
    }
    
    /// <summary>
    /// Endpoints used to return Add Product To Warehouse.
    /// </summary>
    /// <param name="product">New product data</param>
    /// <returns>201 Created</returns>
    [HttpPost]
    public IActionResult AddProductToWarehouse(int IdProduct, int IdWarehouse, int Amount, string CreatedAt)
    {
        var key = _warehouseService.AddProductToWarehouse(IdProduct, IdWarehouse, Amount, CreatedAt);
        return Ok(key);
    }
}
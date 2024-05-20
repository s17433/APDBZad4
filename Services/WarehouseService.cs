using APBD_04.Repositories;

namespace APBD_04.Services;

public class WarehouseService : IWarehouseService
{
    private readonly IWarehouseRepository _warehouseRepository;

    public WarehouseService(WarehouseRespository warehouseRepository)
    {
        _warehouseRepository = warehouseRepository;
    }

    public int AddProductToWarehouse(int IdProduct, int IdWarehouse, int Amount, string CreatedAt)
    {
        return _warehouseRepository.AddProductToWarehouse(IdProduct, IdWarehouse, Amount, CreatedAt);
    }
}
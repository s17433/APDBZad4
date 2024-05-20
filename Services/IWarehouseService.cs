using APBD_04.Model;

namespace APBD_04.Services;

public interface IWarehouseService
{
    int AddProductToWarehouse(int IdProduct, int IdWarehouse, int Amount, string CreatedAt);
    
}
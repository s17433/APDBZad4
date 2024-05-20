namespace APBD_04.Repositories;

public interface IWarehouseRepository
{
    int AddProductToWarehouse(int IdProduct, int IdWarehouse, int Amount, string CreatedAt);

}
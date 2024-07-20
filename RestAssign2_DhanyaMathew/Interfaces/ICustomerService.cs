


using RestAssign2_DhanyaMathew.Dtos;

namespace RestAssign2_DhanyaMathew.Interfaces
{
    public interface ICustomerService
    {
        List<CustomerDto> GetAllCustomers();
        CustomerDto GetCustomerById(int id);
        void AddCustomer(CustomerDto customerDto);
        void UpdateCustomer(CustomerDto customerDto);
        void DeleteCustomer(int id);
    }
}

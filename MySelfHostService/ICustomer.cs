using System.ServiceModel;

namespace MySelfHostService
{
    [ServiceContract]
    public interface ICustomer
    {
        [OperationContract]
        Customer CreateCustomer(int customerId, string name, string email);

        [OperationContract]
        Customer GetCustomerByName(string customerName);

        [OperationContract]
        Customer[] GetAllCustomers();
    }
}

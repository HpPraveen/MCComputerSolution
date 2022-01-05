using MCComputerSolution.Models;
using MCComputerSolution.Repository;

namespace MCComputerSolution.DbContexts
{
    public interface IGenericUnitOfWork
    {
        public GenericRepository<Order> OrderRepository { get; }
        public GenericRepository<Product> ProductRepository { get; }
        public void SaveChanges();

        public void Dispose();
    }
}

using ECommerceApp.Models;

namespace ECommerceApp.Repositories.Interfaces;

public interface ITransactionRepository
{
    List<Transaction> GetAllTransactions();
    Transaction GetById(int transactionId);
    bool Insert(Transaction transaction);
    bool Update(Transaction transaction);
    bool Delete(int transactionId);  
}
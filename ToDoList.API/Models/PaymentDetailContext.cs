using Microsoft.EntityFrameworkCore;

namespace ToDoList.API.Models
{
    public class PaymentDetailContext : DbContext
    {
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options): base(options)
        {
            
        }

        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
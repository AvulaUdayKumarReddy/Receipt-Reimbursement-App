using Microsoft.EntityFrameworkCore;

namespace Receipt_Reimbursement_App.Models
{
    public class ReimbursementDbContext : DbContext
    {
        public ReimbursementDbContext(DbContextOptions options): base(options) { }

        public DbSet<Reimbursement> Reimbursements { get; set;}
    }
}

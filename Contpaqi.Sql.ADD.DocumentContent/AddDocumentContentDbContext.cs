using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace Contpaqi.Sql.ADD.DocumentContent
{
    public class AddDocumentContentDbContext : DbContext
    {
        protected AddDocumentContentDbContext()
        {
        }

        protected AddDocumentContentDbContext(DbCompiledModel model) : base(model)
        {
        }

        public AddDocumentContentDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public AddDocumentContentDbContext(string nameOrConnectionString, DbCompiledModel model) : base(nameOrConnectionString, model)
        {
        }

        public AddDocumentContentDbContext(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
        {
        }

        public AddDocumentContentDbContext(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection) : base(existingConnection, model, contextOwnsConnection)
        {
        }

        public AddDocumentContentDbContext(ObjectContext objectContext, bool dbContextOwnsObjectContext) : base(objectContext, dbContextOwnsObjectContext)
        {
        }

        public virtual DbSet<DocumentContent> DocumentContent { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DocumentContent>()
                .Property(e => e.DocumentType)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentContent>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentContent>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentContent>()
                .Property(e => e.SubDirectory)
                .IsUnicode(false);
        }
    }
}
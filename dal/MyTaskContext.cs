using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using dal;

namespace dal
{
    public partial class MyTaskContext : DbContext
    {
        public MyTaskContext() : base("name=myModel") { }

        public virtual DbSet<MyTask> tasks { get; set; }
        public virtual DbSet<User> users { get; set; }
        public virtual DbSet<Group> groups { get; set; }
        public virtual DbSet<Stat> stats { get; set; }
        public virtual DbSet<Reminder> reminders { get; set; }
        public virtual DbSet<Activity> activities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MyTask>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<MyTask>()
                .Property(e => e.header)
                .IsUnicode(false);

            modelBuilder.Entity<MyTask>()
                .Property(e => e.content_text)
                .IsUnicode(false);

            modelBuilder.Entity<MyTask>()
                .Property(e => e.condition)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.groups)
                .WithRequired(e => e.user)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.reminders)
                .WithRequired(e => e.user)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.tasks)
                .WithRequired(e => e.user)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.groups)
                .WithRequired(e => e.user)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.password)
                .IsUnicode(false);        
        }
    }
}

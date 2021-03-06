using Lecture1_Identity.Domain;
using Microsoft.EntityFrameworkCore;

namespace Lecture1_Identity.Data
{
    internal class CategoryModeling
    {
        private readonly ModelBuilder _modelo;
        public CategoryModeling(ModelBuilder modelo)
        {
            _modelo = modelo;
        }

        public void CriarModelo(){
            _modelo.Entity<Category>().ToTable("Categoria");
            _modelo.Entity<Category>().Property(p => p.Name).HasMaxLength(100).IsRequired();
        }
    }
}
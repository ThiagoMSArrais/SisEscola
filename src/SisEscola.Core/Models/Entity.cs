using FluentValidation;
using FluentValidation.Results;

namespace SisEscola.Core.Models
{
    public abstract class Entity<TEntity> : AbstractValidator<TEntity> where TEntity : class
    {
        protected Entity()
        {
            ValidationResult = new ValidationResult();
        }

        public ValidationResult ValidationResult { get; protected set; }
        public abstract bool EhValido();
    }
}

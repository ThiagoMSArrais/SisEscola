using FluentValidation;
using SisEscola.Core.Models;
using System;
using System.Collections.Generic;

namespace SisEscola.Cadastro.Domain.Models
{
    public class Aluno : Entity<Aluno>
    {
        
        public Guid IdAluno { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public Segmento Segmento { get; private set; }
        public string FotoPerfil { get; private set; }
        public string Email { get; private set; }
        public ICollection<Responsavel> Responsaveis { get; private set; }

        #region Validacões

        public override bool EhValido()
        {
            Validar();
            return ValidationResult.IsValid;
        }

        private void Validar()
        {
            ValidarNome();
            ValidarDataNascimento();
            ValidarSegmento();
            ValidarFotoPerfil();
            ValidarEmail();
            ValidarResponsaveis();

            ValidationResult = Validate(this);
        }

        private void ValidarNome()
        {
            RuleFor(e => e.Nome)
                .NotEmpty().WithMessage("Informe o nome do aluno.")
                .Length(3, 90).WithMessage("O limite de caracteres para o nome do alunão são de 3 a 90.");
        }

        private void ValidarDataNascimento()
        {
            RuleFor(e => e.DataNascimento)
                .NotEmpty().WithMessage("Informe a data de nascimento do aluno.");
        }

        private void ValidarSegmento()
        {
            RuleFor(e => e.Segmento)
                .IsInEnum().WithMessage("Informe o segmento do aluno.");
        }

        private void ValidarFotoPerfil()
        {
            RuleFor(e => e.FotoPerfil)
                .NotEmpty().WithMessage("Forneça uma foto de perfil do aluno.");
        }

        private void ValidarEmail()
        {
            When(e => e.Segmento == Segmento.ENSINOFUNDAMENTAL, () =>
            {
                RuleFor(e => e.Email).EmailAddress().WithMessage("Informe um e-mail do aluno.");
            });
                
        }

        private void ValidarResponsaveis()
        {
            RuleFor(e => e.Responsaveis)
                .NotNull().WithMessage("Informe um responsável do aluno.");
        }


        #endregion
    }
}

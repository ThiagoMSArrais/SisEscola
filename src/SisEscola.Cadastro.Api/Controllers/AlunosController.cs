using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SisEscola.Cadastro.Domain.Notificacoes.Interfaces;
using SisEscola.Cadastro.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisEscola.Cadastro.Api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/alunos")]
    public class AlunosController : MainController
    {
        private readonly IAlunoService _alunoService;
        private readonly IMapper _mapper;

        public AlunosController(IAlunoService alunoService,
                                IMapper mapper,
                                INotificador notificador) : base(notificador)
        {
            _alunoService = alunoService;
            _mapper = mapper;
        }


    }
}

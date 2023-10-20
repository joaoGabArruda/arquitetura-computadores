using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using rotaOesteAPI.DTO;
using rotaOesteAPI.interfaces;
using rotaOesteAPI.Interfaces;

namespace rotaOesteAPI.Services
{
    public class AlertasService : IResponseTraduzido
    {
        private readonly IMapper _mapper;
        private readonly IAlertasApi _alertasApi;
        public Task<ResponseGenerico<ResponseModelTraduzido>> ImportarAlertas(int id)
        {
            throw new NotImplementedException();
        }
    }
}
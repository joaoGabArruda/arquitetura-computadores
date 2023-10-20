using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using rotaOesteAPI.DTO;

namespace rotaOesteAPI.Interfaces
{
    public interface IResponseTraduzido
    {
        Task<ResponseGenerico<ResponseModelTraduzido>> ImportarAlertas(int id);
    }
}
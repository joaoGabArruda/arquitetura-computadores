using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using rotaOesteAPI.DTO;
using rotaOesteAPI.Models;

namespace rotaOesteAPI.interfaces
{
    public interface IAlertasApi
    {
        Task<ResponseGenerico<AlertaModel>> ImportarAlertas(int id);
    }
}
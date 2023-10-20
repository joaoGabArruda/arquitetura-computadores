using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using rotaOesteAPI.DTO;
using rotaOesteAPI.interfaces;
using rotaOesteAPI.Models;

namespace rotaOesteAPI.Rest
{
    public class JhonDeereRest : IAlertasApi
    {
        public async Task<ResponseGenerico<AlertaModel>> ImportarAlertas(int id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://sandboxapi.deere.com/platform/machines/{id}/alerts");

            var response = new ResponseGenerico<AlertaModel>();
            using (var cliente = new HttpClient()) {
                var responseAlertas = await cliente.SendAsync(request);
                var contentResp = await responseAlertas.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<AlertaModel>(contentResp);

                if (responseAlertas.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseAlertas.StatusCode;
                    response.DadosRetorno = objResponse;
                } 
                else
                {
                    response.CodigoHttp = responseAlertas.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }
            return response;
        }
    }
}
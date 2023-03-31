using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Aula08.Handler;
using System.Globalization;

namespace Aula08.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExemploController : ControllerBase
    {
        [HttpGet]
        [Route("dateTime")]
        public string GetDateTime()
        {
            //Now
            //DateTime data = new DateTime.Now;

            //Ano
            //data.year

            //Mês
            //data.Month

            //Dia
            //data.Day

            //Hora
            //data.Hour

            //Minutos
            //data.minutes

            //Segundos
            //data.seconds

            //Parse - Converte string para data
            //DateTime data = DateTime.Parse("19/03/2009", new CultureInfo("pt-BR"));
            //return data;

            //ParseExact - Coverte em um formato exato
            //DateTime data = DateTime.ParseExact("03/19/2009", "MM/dd/yyyy", new CultureInfo("pt-BR"));
            //return data;

            //ToString permite você formatar da forma que você preferir
            //DateTime data = DateTime.Now;
            //return data.ToString("dd.MM.yyyy hh-mm-ss");

            //AddYears, ...Months - é usado números inteiros para adicionar
            //AddDays, ...Hours, ...Minutes, ...Seconds - é usado números double para adicionar

            DateTime data = DateTime.ParseExact
                ("15/06/1999 22:52:14","dd/MM/yyyy HH:mm:ss",new CultureInfo("pt-BR"));
            
            DateTime newData = data.AddYears(5);
            newData = newData.AddMonths(8);
            newData = newData.AddDays(5);
            newData = newData.AddHours(5.67);
            newData = newData.AddMinutes(15);
            newData = newData.AddSeconds(30);
            
            return newData.ToString("dd.MM.yyyy HH:mm:ss");
        }
    }
}

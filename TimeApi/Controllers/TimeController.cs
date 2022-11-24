using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;

namespace TimeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        public string Get()
        {
            // Gera um int aleatório para delay da requisição
            var delay = new Random().Next(
                minValue: 1000,
                maxValue: 10000);

            // Obtem o DateTime atual
            var time = DateTime.Now.ToString(format: "dddd, dd MMMM yyyy HH:mm:ss");

            // Segura requisição
            Thread.Sleep(millisecondsTimeout: delay);

            // Retorna DateTime atual
            return time;
        }
    }
}
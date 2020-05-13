using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


/*
 * API - Application-Program Interface
 * Интерфейс взаимодействия приложения и программ
 * Набор средств для обмена данными между приложениями
 *
 * Как правило - это часть информационной системы,
 * наряду с представлениями (для человека),
 * обеспечивающая использование и управление системой
 * через запросы.
 *
 * Полный API поддерживает идеологию CRUD
 * Web-API (запросы HTTP)
 * RFC 7231  Hypertext Transfer Protocol (HTTP/1.1): Semantics and Content
 *   4.3. Method Definitions
        4.3.1. GET - R (Read)
        4.3.2. HEAD - запрос заголовков (без тела) - в API не используется
        4.3.3. POST - U (Update) / C (Create)
        4.3.4. PUT - C (Create) / U (Update)
        4.3.5. DELETE - D (Delete)
        4.3.6. CONNECT - Туннелирование (часть серии запросов) - в API не используется
        4.3.7. OPTIONS - в API не используется
        4.3.8. TRACE - в API не используется
 */


/*
 * ASP-WebAPI - сборка на базе MVC, реализующая API
 * - наличие ValueController
 * - наличие инфо-страницы (HELP) -> AreaRegistration.RegisterAllAreas();
 * - изменена маршрутизация Values/Get -> api/values
 *      (распознавание метода контроллера - по методу запроса)
 *      a) Application_Start() -> GlobalConfiguration.Configure(WebApiConfig.Register);
 *      b) public static class WebApiConfig
 * - Результат возврата "оборачивается" в XML
 * 
 * Соглашения:
 *  - Количество методов ограничено
 *  - Имена методов контроллеров совпадают или начинаются с названия метода-запроса
 *  Get(), GetBook()
 *  Post(), PostBook()
 *  Либо указываются при помощи атрибутов
 *  [HttpPost]
 *  UpdateBook(...)
 * */


namespace WebApi_Basic.Controllers
{
    public class ValuesController : ApiController
    {
        List<String> strings { get; set; }

        public ValuesController()
        {
            strings = new List<string>()
            {
                "Some value 1",
                "Some value 2",
                "Some value 3",
                "Some value 4",
                "Some value 5"
            };

        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return strings;
        }

        // GET api/values/5
        public string Get(int id)
        {
            if (id > strings.Count)
                return $"Id {id} not available";
            return strings[id];
        }

        //// POST api/values
        //public void Post([FromBody]string value)
        //{
        //    strings.Add(value);
        //}

        // POST api/values
        public String Post([FromBody]string value)
        {
            strings.Add(value);
            return value;
        }

        // PUT api/values/5
        public String Put(int id, [FromBody]string value)
        {
            if (id >= strings.Count || id < 0)
                return $"Id {id} not available";
            strings[id] = value;
            return strings[id];
        }

        // DELETE api/values/5
        public String Delete(int id)
        {
            if (id > strings.Count)
                return $"Id {id} not available";
            strings.RemoveAt(id);
            return "Delete success";
        }
    }
}

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
        4.3.3. POST - U (Update)
        4.3.4. PUT - C (Create)
        4.3.5. DELETE - D (Delete)
        4.3.6. CONNECT - Туннелирование (часть серии запросов) - в API не используется
        4.3.7. OPTIONS - в API не используется
        4.3.8. TRACE - в API не используется
 */


namespace WebApi_Basic.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

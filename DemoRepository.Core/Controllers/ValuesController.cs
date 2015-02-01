using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

/// <summary>
/// Summary description for TestController
/// </summary>
public class ValuesController : ApiController
{
    // GET api/values
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2", "value4" };
    }

    // GET api/values/5
    public object Get(int id)
    {
        return new { name = "value", id = id };
    }
}
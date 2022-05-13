using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallHavenGetter.Utils
{
    public class JsonHelper
    {
        private ILogger<JsonHelper> _logger;

        public JsonHelper(ILogger<JsonHelper> logger)
        {
            _logger = logger;
        }

        public bool TryToObj<T>(string json,out T t)
        {
            try
            {
                t = JsonConvert.DeserializeObject<T>(json);
                return t != null;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                t = default;
                return false;
            }
        }
    }
}

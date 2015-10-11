using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AsyncGenericHandler
{
    /// <summary>
    /// AsyncHandler 的摘要描述
    /// </summary>
    public class AsyncHandler : HttpTaskAsyncHandler
    {
        public override async Task ProcessRequestAsync(HttpContext context)
        {
            await Task.Delay(0);
        }
    }
}
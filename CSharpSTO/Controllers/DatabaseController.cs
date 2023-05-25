using CSharpSTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSTO.Controllers
{
    internal class DatabaseController : IDisposable
    {
        public DatabaseController() { }

        public List<Master> GetMasters() => DatabaseContext.Instance.GetMasters();

        public void Dispose() { }
    }
}

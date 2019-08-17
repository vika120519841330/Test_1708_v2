using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEST_170819.Models;

namespace TEST_170819.Interfaces
{
    public interface IRequestRepository : IDisposable
    {
        void Dispose(bool disposing);

        void FixLog(FixRequest entry);
    }
}

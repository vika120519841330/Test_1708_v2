using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TEST_170819.Context;
using TEST_170819.Interfaces;
using TEST_170819.Models;

namespace TEST_170819.Services
{
    public class RequestRepository : IRequestRepository
    {
        private readonly MyContext context;
        public RequestRepository(MyContext _context)
        {
            this.context = _context;
        }
        public void FixLog(FixRequest entry)
        {
            context.FixRequests.Add(entry);
            context.SaveChanges();
        }


        private bool disposed = false;

        // реализация интерфейса IDisposable.
        public void Dispose()
        {
            Dispose(true);
            // подавляем финализацию
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Освобождаем управляемые ресурсы
                    context.Dispose();
                }
                // освобождаем неуправляемые объекты
                disposed = true;
            }
        }

        // Деструктор
        ~RequestRepository()
        {
            Dispose(false);
        }
    }
}
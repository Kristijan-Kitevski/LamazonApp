using Microsoft.EntityFrameworkCore;
using SEDC.Lamazon.DataAccess.Interfaces;
using SEDC.Lamazon.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.DataAccess.Repositories
{
    public class InvoiceRepository : BaseRepository, IRepository<Invoice>
    {
        public InvoiceRepository(LamazonDbContext context) : base(context)
        {

        }
       
        public IEnumerable<Invoice> GetAll()
        {
            return _context.Invoices
                .Include(o => o.)
                    .ThenInclude(po => po.)
                .Include(o => o.);
        }

        public Invoice GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Invoice entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Invoice entity)
        {
            throw new NotImplementedException();
        }
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

    }
}

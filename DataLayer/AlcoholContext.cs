using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class AlcoholContext : IDB<Alcohol, int>
    {
        private DrinkingPartiesDbContext _context;
        public AlcoholContext(DrinkingPartiesDbContext context)
        {
            _context = context;
        }
        public void Create(Alcohol item)
        {
            try
            {
                _context.Alcohols.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete(int key)
        {
            try
            {
                _context.Alcohols.Remove(Read(key));
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Alcohol Read(int key, bool noTracking = false, bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Alcohol> query = _context.Alcohols;

                if (noTracking)
                {
                    query = query.AsNoTrackingWithIdentityResolution();
                }


                return query.SingleOrDefault(i => i.ID == key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Alcohol> Read(int skip, int take, bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Alcohol> query = _context.Alcohols;

                return query.Skip(skip).Take(take).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Alcohol> ReadAll(bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Alcohol> query = _context.Alcohols;

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Alcohol item, bool useNavigationProperties = false)
        {
            try
            {
                Alcohol AlcoholFromDB = Read(item.ID, useNavigationProperties);

                _context.Entry(AlcoholFromDB).CurrentValues.SetValues(item);
                _context.SaveChanges();

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
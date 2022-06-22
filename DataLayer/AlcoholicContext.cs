using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class AlcoholicContext : IDB<Alcoholic, int>
    {
        private DrinkingPartiesDbContext _context;
        public AlcoholicContext(DrinkingPartiesDbContext context)
        {
            _context = context;
        }
        public void Create(Alcoholic item)
        {
            try
            {
                _context.Alcoholics.Add(item);
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
                _context.Alcoholics.Remove(Read(key));
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Alcoholic Read(int key, bool noTracking = false, bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Alcoholic> query = _context.Alcoholics;

                if (noTracking)
                {
                    query = query.AsNoTrackingWithIdentityResolution();
                }

                if (useNavigationProperties)
                {
                    query = query.Include(i => i.DrinkingBuddies).Include(i => i.FavouriteDrinks);
                }

                return query.SingleOrDefault(i => i.ID == key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Alcoholic> Read(int skip, int take, bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Alcoholic> query = _context.Alcoholics;

                if (useNavigationProperties)
                {
                    query = query.Include(i => i.DrinkingBuddies).Include(i => i.FavouriteDrinks);
                }

                return query.Skip(skip).Take(take).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<Alcoholic> ReadAll(bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Alcoholic> query = _context.Alcoholics;

                if (useNavigationProperties)
                {
                    query = query.Include(i => i.DrinkingBuddies).Include(i => i.FavouriteDrinks);
                }

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Alcoholic item, bool useNavigationProperties = false)
        {
            try
            {
                Alcoholic AlcoholicFromDB = Read(item.ID, useNavigationProperties);

                if (useNavigationProperties)
                {

                    List<Alcoholic> NewDrinkingbuddies = new List<Alcoholic>();

                    foreach (Alcoholic buddy in item.DrinkingBuddies)
                    {
                        Alcoholic BuddyFromDB = _context.Alcoholics.Find(buddy.ID);

                        if (BuddyFromDB != null)
                        {
                            NewDrinkingbuddies.Add(BuddyFromDB);
                        }
                        else
                        {
                            NewDrinkingbuddies.Add(buddy);
                        }
                    }

                    AlcoholicFromDB.DrinkingBuddies = NewDrinkingbuddies;

                    List<Alcohol> NewFavouriteDrinks = new List<Alcohol>();

                    foreach (Alcohol drink in item.FavouriteDrinks)
                    {
                        Alcohol DrinkFromDB = _context.Alcohols.Find(drink.ID);

                        if (DrinkFromDB != null)
                        {
                            NewFavouriteDrinks.Add(DrinkFromDB);
                        }
                        else
                        {
                            NewFavouriteDrinks.Add(drink);
                        }
                    }
                    AlcoholicFromDB.FavouriteDrinks = NewFavouriteDrinks;

                }

                _context.Entry(AlcoholicFromDB).CurrentValues.SetValues(item);
                _context.SaveChanges();

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
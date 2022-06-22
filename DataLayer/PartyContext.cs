using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PartyContext : IDB<Party, int>
    {
        private DrinkingPartiesDbContext _context;

        public PartyContext(DrinkingPartiesDbContext context)
        {
            _context = context;
        }
        public void Create(Party item)
        {
            try
            {
                _context.Parties.Add(item);
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
                _context.Parties.Remove(Read(key));
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Party Read(int key, bool noTracking = false, bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Party> query = _context.Parties;

                if (noTracking)
                {
                    query = query.AsNoTrackingWithIdentityResolution();
                }

                if (useNavigationProperties)
                {
                    query = query.Include(i => i.PartyMembers).Include(i => i.Drinks);
                }

                return query.SingleOrDefault(i => i.ID == key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Party> Read(int skip, int take, bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Party> query = _context.Parties;

                if (useNavigationProperties)
                {
                    query = query.Include(i => i.PartyMembers).Include(i => i.Drinks);
                }

                return query.Skip(skip).Take(take).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Party> ReadAll(bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Party> query = _context.Parties;

                if (useNavigationProperties)
                {
                    query = query.Include(i => i.PartyMembers).Include(i => i.Drinks);
                }

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Party item, bool useNavigationProperties = false)
        {
            try
            {
                Party PartyFromDB = Read(item.ID, useNavigationProperties);

                if (useNavigationProperties)
                {

                    List<Alcoholic> NewPartyMembers = new List<Alcoholic>();

                    foreach (Alcoholic member in item.PartyMembers)
                    {
                        Alcoholic MemberFromDB = _context.Alcoholics.Find(member.ID);

                        if (MemberFromDB != null)
                        {
                            NewPartyMembers.Add(MemberFromDB);
                        }
                        else
                        {
                            NewPartyMembers.Add(member);
                        }
                    }

                    PartyFromDB.PartyMembers = NewPartyMembers;

                    List<Alcohol> NewDrinks = new List<Alcohol>();

                    foreach (Alcohol drink in item.Drinks)
                    {
                        Alcohol DrinkFromDB = _context.Alcohols.Find(drink.ID);

                        if (DrinkFromDB != null)
                        {
                            NewDrinks.Add(DrinkFromDB);
                        }
                        else
                        {
                            NewDrinks.Add(drink);
                        }
                    }
                }

                _context.Entry(PartyFromDB).CurrentValues.SetValues(item);
                _context.SaveChanges();

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
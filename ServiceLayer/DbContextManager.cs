using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace ServiceLayer
{
    public static class DbContextManager
    {
        private static DrinkingPartiesDbContext _context;
        private static AlcoholContext _alcoholContext;
        private static AlcoholicContext _alcoholicContext;
        private static PartyContext _partyContext;

        #region DrinkingPartiesDbContext
        public static DrinkingPartiesDbContext CreateContext()
        {
            _context = new DrinkingPartiesDbContext();
            return _context;
        }

        public static DrinkingPartiesDbContext GetContext()
        {
            return _context;
        }

        public static void SetChangeTracking(bool value)
        {
            _context.ChangeTracker.AutoDetectChangesEnabled = value;
        }

        #endregion

        #region AlcoholContext
        public static AlcoholContext CreateAlcoholContext(DrinkingPartiesDbContext context)
        {
            _alcoholContext = new AlcoholContext(context);
            return _alcoholContext;
        }

        public static AlcoholContext GetAlcoholContext()
        {
            return _alcoholContext;
        }
        #endregion

        #region AlcoholicContext
        public static AlcoholicContext CreateAlcoholicContext(DrinkingPartiesDbContext context)
        {
            _alcoholicContext = new AlcoholicContext(context);
            return _alcoholicContext;
        }

        public static AlcoholicContext GetAlcoholicContext()
        {
            return _alcoholicContext;
        }
        #endregion

        #region PartyContext
        public static PartyContext CreatePartyContext(DrinkingPartiesDbContext context)
        {
            _partyContext = new PartyContext(context);
            return _partyContext;
        }

        public static PartyContext GetPartyContext()
        {
            return _partyContext;
        }
        #endregion
    }
}

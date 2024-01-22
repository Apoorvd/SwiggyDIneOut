using Dine.DataModel.ContextModel;
using Dine.DataModel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataModel
{
    public static class DineOutSeedData
    {
        public static void EnsureEnumSeedData(this DineOutGQLDbContext db)
        {
            if(!db.OfferApp.Any())
            {
                db.OfferApp.SeedEnumValuesAdd<OfferApp, OfferAppEnum>(@enum => @enum);
                db.SaveChanges();
            }
            if (!db.OfferBank.Any())
            {
                db.OfferBank.SeedEnumValuesAdd<OfferBank, OfferBankEnum>(@enum => @enum);
                db.SaveChanges();
            }
            if (!db.OfferType.Any())
            {
                db.OfferType.SeedEnumValuesAdd<OfferType, OfferTypeEnum>(@enum => @enum);
                db.SaveChanges();
            }
            if (!db.OrderStatus.Any())
            {
                db.OrderStatus.SeedEnumValuesAdd<OrderStatus, OrderStatusEnum>(@enum => @enum);
                db.SaveChanges();
            }
            if (!db.ReservationStatus.Any())
            {
                db.ReservationStatus.SeedEnumValuesAdd<ReservationStatus, ReservationStatusEnum>(@enum => @enum);
                db.SaveChanges();
            }
            if (!db.UserType.Any())
            {
                db.UserType.SeedEnumValuesAdd<UserType, UserTypeEnum>(@enum => @enum);
                db.SaveChanges();
            }
        }

        public static void SeedEnumValuesAdd<T, TEnum>(this DbSet<T> dbSet, Func<TEnum, T> converter)
        where T : class => Enum.GetValues(typeof(TEnum))
                               .Cast<object>()
                               .Select(value => converter((TEnum)value))
                               .ToList()
                               .ForEach(instance => dbSet.Add(instance));

        public static void SeedEnumValuesUpdate<T, TEnum>(this DbSet<T> dbSet, Func<TEnum, T> converter)
        where T : class => Enum.GetValues(typeof(TEnum))
                               .Cast<object>()
                               .Select(value => converter((TEnum)value))
                               .ToList()
                               .ForEach(instance => dbSet.Update(instance));
    }
}

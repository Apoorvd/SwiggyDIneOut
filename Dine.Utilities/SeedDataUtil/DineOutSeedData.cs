using Dine.DataModel.ContextModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dine.DataModel.Models;
using Dine.Utilities.Helper;
using System.Globalization;

namespace Dine.Utilities.SeedDataUtil
{
    public static class DineOutSeedData
    {
        public static void EnsureEnumSeedData(this DineOutGQLDbContext db)
        {
            if (!db.OfferApp.Any())
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
            if (!db.Users.Any() || !db.Address.Any())
            {
                var users = new List<User>
                {
                    new User {
                        FName = "Apoorv",
                        LName = "Dubey",
                        PhoneNumber = "92X094X9XX",
                        Email = "xxxapoorv@gmail.com",
                        Password = CryptHelper.EncryptionHelper("ABCD1234","YourSecretKey12345678901", "abcdefghi4"),
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        BirthDay = DateOnly.ParseExact("24 Mar 2000", "dd MMM yyyy", CultureInfo.InvariantCulture),
                        EmailConfirmed = false,
                        UserTypeId = 1,
                        AddressList = new List<Address>
                        {
                            new Address
                            {
                                StreetAddress = "blabla",
                                PostalCode = "192012",
                                HouseNumber = "1",
                                State = "a",
                                Landmark = "1",
                                UserId = 1,
                                IsDefault = true,
                                City = "1"
                            }
                        }
                    },
                    new User {
                        FName = "Dummy",
                        LName = "Dummy",
                        PhoneNumber = "92X094X9XX",
                        Email = "xxxdummyv@gmail.com",
                        Password = CryptHelper.EncryptionHelper("ABCD12345","YourSecretKey12345678901", "abcdefghi4"),
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        BirthDay = DateOnly.ParseExact("12 Oct 2013", "dd MMM yyyy", CultureInfo.InvariantCulture),
                        EmailConfirmed = false,
                        UserTypeId = 1,
                        AddressList = new List<Address>
                        {
                            new Address
                            {
                                StreetAddress = "blabla",
                                PostalCode = "192012",
                                HouseNumber = "1",
                                State = "a",
                                Landmark = "1",
                                UserId = 2,
                                IsDefault = true,
                                City = "1"
                            }
                        }
                    }
                };
                db.AddRange(users); db.SaveChanges();
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

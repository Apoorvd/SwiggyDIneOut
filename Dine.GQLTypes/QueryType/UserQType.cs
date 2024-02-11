using Dine.DataModel.Models;
using Dine.Service.Contracts;
using Dine.Service.Repositories;
using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dine.GQLTypes.QueryType
{
    public class UserQType : ObjectGraphType<User>
    {
        public UserQType(IAddressRepository addressRepository, IReviewRepository reviewRepository, IPaymentRepository paymentRepository) 
        {
            Field(m => m.Id, nullable: false) ;
            Field(m => m.FName);
            Field(m => m.LName);
            Field(m => m.PhoneNumber);
            Field(m => m.Email);
            Field(m => m.Password);
            Field(m => m.EmailConfirmed);
            Field(m => m.BirthDay);
            Field(m => m.DateCreated);
            Field(m => m.DateUpdated);
            Field(m => m.DefaultAddressId);
            Field(m => m.UserTypeId);
            Field<ListGraphType<AddressType>>("Address")
                .Arguments(new QueryArgument<BooleanGraphType> { Name = "GetDefault", Description = "Fetch the default Address" })
                .ResolveAsync(async context =>
                {
                    // we are not using the lambda expression to call because of implicit conversion of delegate type
                    var addresses = await addressRepository.GetAddressByUserID(context.Source.Id);
                    return addresses;
                });
            // new QueryArgumets parameter has become obsolete, and now we use Arguments() and Argument directly attached to field
            // with this we are able to resolve async context and make it thread safe
            Field<ListGraphType<ReviewType>>("Review")
                .Argument<BooleanGraphType>(name: "LastTenReviews", description: "Fetch the last 10 reviews")
                .ResolveAsync(async context =>
                {
                    var reviews = await reviewRepository.GetAllReviewforUser(context.Source.Id, context.GetArgument<bool>("LastTenReview"));
                    return reviews;
                });

            Field<ListGraphType<PaymentType>>("Payment")
                .Argument<NonNullGraphType<BooleanGraphType>>("LastPayment", "Fetch the last payment") // if we do not name: it is also fine to do so
                .Argument<NonNullGraphType<BooleanGraphType>>(name: "AllPayments", description: "Fetch all the payments")
                .ResolveAsync(async context =>
                {
                    if (context.GetArgument<bool>("LastPayment"))
                    {
                        var listPay = new List<Payment>();
                        var payments = await paymentRepository.GetLastPayment(context.Source.Id);
                        listPay.Add(payments);
                        return listPay;
                    }
                    else if (context.GetArgument<bool>("AllPayment"))
                    {
                        var payments = await paymentRepository.GetAllPaymentbyUser(context.Source.Id);
                        return payments;
                    }
                    else
                    {
                        return null;
                    }
                });
        }
    }
}

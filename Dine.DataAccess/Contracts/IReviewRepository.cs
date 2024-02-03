using Dine.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.Service.Contracts
{
    public interface IReviewRepository
    {
        Review GetReview(int id);
        Review GetAllReviewforUser(int userId);
        Review PostReview(Review review);
        Review UpdateReview(Review review);
        Review DeleteReview(int id);

    }
}

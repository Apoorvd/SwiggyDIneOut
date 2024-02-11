using Dine.Service.Contracts;
using Dine.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.Service.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        public Review DeleteReview(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Review> GetAllReviewforUser(long userId, bool getLastTenReview)
        {
            throw new NotImplementedException();
        }

        public Review GetReview(int id)
        {
            throw new NotImplementedException();
        }

        public Review PostReview(Review review)
        {
            throw new NotImplementedException();
        }

        public Review UpdateReview(Review review)
        {
            throw new NotImplementedException();
        }
    }
}

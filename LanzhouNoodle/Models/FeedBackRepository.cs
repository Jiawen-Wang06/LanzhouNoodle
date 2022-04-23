using System.Collections.Generic;

namespace LanzhouNoodle.Models
{
    public class FeedBackRepository : IFeedbackRepo
    {
        private AppDBContext _dbContext;
        public FeedBackRepository(AppDBContext context)
        {
            _dbContext = context;
        }
        public void AddFeedback(Feedback feedback)
        {
            _dbContext.Feedbacks.Add(feedback);
        }

        public IEnumerable<Feedback> GetAllFeedbacks()
        {
            return _dbContext.Feedbacks;
        }
    }
}

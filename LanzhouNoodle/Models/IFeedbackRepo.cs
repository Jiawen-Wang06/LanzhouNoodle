using System.Collections.Generic;

namespace LanzhouNoodle.Models
{
    public interface IFeedbackRepo
    {
        IEnumerable<Feedback> GetAllFeedbacks();
        void AddFeedback(Feedback feedback);
    }
}

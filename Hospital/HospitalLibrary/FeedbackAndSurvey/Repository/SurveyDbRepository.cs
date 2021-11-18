using ehealthcare.Model;
using HospitalLibrary.FeedbackAndSurvey.Model;
using HospitalLibrary.Repository.DbRepository;

namespace HospitalLibrary.FeedbackAndSurvey.Repository
{
    public class SurveyDbRepository : GenericDbRepository<Survey>, ISurveyRepository
    {
        public SurveyDbRepository(HospitalDbContext dbContext) : base(dbContext)
        {
        }
    }
}
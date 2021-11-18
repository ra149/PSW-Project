using System;
using System.Collections;
using System.Collections.Generic;
using ehealthcare.Model;
using HospitalLibrary.Model;

namespace HospitalLibrary.FeedbackAndSurvey.Model
{
    public class Survey : EntityDb
    {
        //public string PatientId { get; set; }
        //public virtual Patient Patient { get; set; }
        public DateTime SubmissionDate { get; set; }
        public virtual ICollection<Question> Questions { get; set; }

        public Survey(DateTime submissionDate)
        {
            SubmissionDate = submissionDate;
        }

        public Survey()
        {
        }

    }
}
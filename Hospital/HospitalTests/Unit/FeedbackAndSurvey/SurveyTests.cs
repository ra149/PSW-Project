using System;
using System.Collections.Generic;
using HospitalAPI.DTO;
using HospitalLibrary.FeedbackAndSurvey.Model;
using Microsoft.VisualBasic.CompilerServices;
using Xunit;

namespace HospitalTests.Unit.FeedbackAndSurvey
{
    public class SurveyTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void Create_valid_survey_and_questions(int questionValue, bool valid)
        {
            Assert.Equal(Validate(questionValue), valid);
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { null, false },
                new object[] { -1, false },
                new object[] { 8, false },
                new object[] { 5, true }
            };

        private bool Validate(object questionValue)
        {
            return questionValue is int value && value >= 1 && value <= 5;
        }

    }
}
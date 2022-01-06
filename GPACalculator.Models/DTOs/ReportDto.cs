using System;
using System.Collections.Generic;

namespace GPACalculator.Models.DTOs
{
    public class ReportDto
    {
        public List<Result> Results;

        public ReportDto()
        {
            Results = new List<Result>();
        }
    }
}

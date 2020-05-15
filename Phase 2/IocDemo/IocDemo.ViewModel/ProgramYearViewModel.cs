using System;
using System.Collections.Generic;
using IocDemo.Core;
using IocDemo.Core.Enum;

namespace IocDemo.ViewModel
{
    public class ProgramYearAddUpdate
    {
        public int Id { get; set; }
        public ProgramType ProgramType { get; set; }
        public string ProgramYearName { get; set; }
        public int MinimumNumberOfSession { get; set; }
        public int MidRangeStartNumber { get; set; }
        public int MidRangeEndNumber { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class ProgramYearList : GridParameter
    {
        public ProgramType? ProgramType { get; set; }
        public bool? IsActive { get; set; }
    }

    public class ProgramYearGridResult 
    {
        public int Id { get; set; }
        public ProgramType ProgramType { get; set; }
        public string ProgramYearName { get; set; }
        public int MinimumNumberOfSession { get; set; }
        public int MidRangeStartNumber { get; set; }
        public int MidRangeEndNumber { get; set; }
        public bool IsActive { get; set; }
    }

    public class GridResult
    {
        public int TotalRecordFound { get; set; }
        public List<ProgramYearGridResult> Results { get; set; }

        public GridResult()
        {
            Results=new List<ProgramYearGridResult>();
        }
    }

    public class ProgramYearViewModel
    {
        public int Id { get; set; }
        public ProgramType ProgramType { get; set; }
        public string ProgramYearName { get; set; }
        public int MinimumNumberOfSession { get; set; }
        public int MidRangeStartNumber { get; set; }
        public int MidRangeEndNumber { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
        public string CreatedByFirstName { get; set; }
        public string CreatedByMiddleName { get; set; }
        public string CreatedByLastName { get; set; }
        public string LastEditedByFirstName { get; set; }
        public string LastEditedByMiddleName { get; set; }
        public string LastEditedByLastName { get; set; }
    }
}
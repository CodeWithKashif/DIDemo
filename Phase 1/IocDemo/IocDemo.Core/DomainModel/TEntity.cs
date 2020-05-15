using System;

namespace IocDemo.Core.DomainModel
{
    public class TEntity
    {
        public int Id { get; set; }
        //public bool IsActive { get; set; }
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
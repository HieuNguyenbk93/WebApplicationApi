using System.ComponentModel.DataAnnotations;

namespace WebApplicationApi.Data
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte LevelDepartment { get; set; }
        public int ParentId { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public ICollection<SetOfIndices> SetOfIndices { get; set; }
    }
}

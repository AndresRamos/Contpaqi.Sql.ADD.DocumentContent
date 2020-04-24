using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.DocumentContent
{
    [Table("DocumentContent")]
    public class DocumentContent
    {
        [Key]
        public Guid GuidDocument { get; set; }

        [StringLength(50)]
        public string DocumentType { get; set; }

        [StringLength(255)]
        public string FileName { get; set; }

        [Column(TypeName = "text")]
        public string Content { get; set; }

        [StringLength(2)]
        public string SubDirectory { get; set; }

        public DateTime? DocumentDate { get; set; }

        public DateTime? CreationDate { get; set; }
    }
}
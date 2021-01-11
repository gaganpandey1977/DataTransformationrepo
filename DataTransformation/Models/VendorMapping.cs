using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataTransformation.Models
{
    public class VendorMapping
    {
        [Key]
        public int MappingID { get; set; }
        public string DT_XML { get; set; }
        public string RO_XML { get; set; }
        public string DDDS_XML { get; set; }
        public string RO_TRSFM_LOGIC { get; set; }
        public string DT_TRSFM_LOGIC { get; set; }
        public string DDDS_TRSFM_LOGIC { get; set; }
        public string CDM_MAPPING { get; set; }
        public string DB_FIELD_NM { get; set; }
        public string UI_FIELD_NM { get; set; }
        public string COMMENTS { get; set; }

        [DataType(DataType.Date)]
        public DateTime CREATE_DT { get; set; }
        [DataType(DataType.Date)]
        public DateTime EDIT_DT { get; set; }

    }
}

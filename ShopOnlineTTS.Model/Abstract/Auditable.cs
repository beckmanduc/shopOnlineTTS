using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnlineTTS.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string UpdatedBy { set; get; }

        [MaxLength(256)]
        public string MetaKeyword { set; get; }
        [MaxLength(256)]
        public string MetaDescription { set; get; }

        public bool Status { set; get; }

    }
}

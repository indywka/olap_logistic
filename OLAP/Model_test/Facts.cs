//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OLAP.Model_test
{
    using System;
    using System.Collections.Generic;
    
    public partial class Facts
    {
        public int Id { get; set; }
        public int DataBaseId { get; set; }
        public string TableName { get; set; }
        public string RowName { get; set; }
        public string Name { get; set; }
    
        public virtual DataBases DataBases { get; set; }
    }
}

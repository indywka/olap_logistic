//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OLAP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class СостояниеЗаказа
    {
        public СостояниеЗаказа()
        {
            this.Заказы = new HashSet<Заказы>();
        }
    
        public int СостояниеID { get; set; }
        public string Состояние { get; set; }
    
        public virtual ICollection<Заказы> Заказы { get; set; }
    }
}

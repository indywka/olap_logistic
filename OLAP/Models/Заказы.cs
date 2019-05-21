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
    
    public partial class Заказы
    {
        public Заказы()
        {
            this.ЗаказаноТоваров = new HashSet<ЗаказаноТоваров>();
        }
    
        public int ЗаказID { get; set; }
        public System.DateTime СрокПоставки { get; set; }
        public System.DateTime ДатаЗаказа { get; set; }
        public int КлиентID { get; set; }
        public string МестоНазначения { get; set; }
        public int СостояниеID { get; set; }
        public Nullable<System.DateTime> ДатаДоставки { get; set; }
        public int ТрСредствоID { get; set; }
        public int ВодительID { get; set; }
    
        public virtual Водители Водители { get; set; }
        public virtual ICollection<ЗаказаноТоваров> ЗаказаноТоваров { get; set; }
        public virtual Клиенты Клиенты { get; set; }
        public virtual СостояниеЗаказа СостояниеЗаказа { get; set; }
        public virtual ТранспортноеСредство ТранспортноеСредство { get; set; }
    }
}

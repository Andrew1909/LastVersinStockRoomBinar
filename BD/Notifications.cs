//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StockroomBinar.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Notifications
    {
        public int ID { get; set; }
        public string Descriptiont { get; set; }
        public Nullable<int> Status { get; set; }

        public string NatitficationOne
        {
            get
            {
                if (Descriptiont != null) return Descriptiont;
                return null;
            }
        }
    }
}

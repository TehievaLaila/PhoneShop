//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhoneShop.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class ActRepair
    {
        public int ID_ActRepair { get; set; }
        public string Name { get; set; }
        public Nullable<int> ID_Client { get; set; }
        public Nullable<int> ID_Phone { get; set; }
        public Nullable<int> ID_TypeProblem { get; set; }
        public Nullable<int> ID_Material { get; set; }
        public string Price { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Material Material { get; set; }
        public virtual Phone Phone { get; set; }
        public virtual TypeProblem TypeProblem { get; set; }
    }
}
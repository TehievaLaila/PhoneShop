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
    
    public partial class Material
    {
        public Material()
        {
            this.ActRepair = new HashSet<ActRepair>();
        }
    
        public int ID_Material { get; set; }
        public string Name { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string Price { get; set; }
    
        public virtual ICollection<ActRepair> ActRepair { get; set; }
    }
}

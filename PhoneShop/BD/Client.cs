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
    
    public partial class Client
    {
        public Client()
        {
            this.ActRepair = new HashSet<ActRepair>();
            this.Application = new HashSet<Application>();
        }
    
        public int ID_Client { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public Nullable<int> ID_User { get; set; }
    
        public virtual ICollection<ActRepair> ActRepair { get; set; }
        public virtual ICollection<Application> Application { get; set; }
        public virtual User User { get; set; }
    }
}

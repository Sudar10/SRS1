//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace пр5.models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Postavshik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Postavshik()
        {
            this.Nakladnaya = new HashSet<Nakladnaya>();
        }
    
        public int ID { get; set; }
        public string Nazvanie { get; set; }
        public string Producti { get; set; }
        public decimal Stoimost { get; set; }
        public string Email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nakladnaya> Nakladnaya { get; set; }
    }
}

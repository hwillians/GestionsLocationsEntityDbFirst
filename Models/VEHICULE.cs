//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VEHICULE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VEHICULE()
        {
            this.LOUE = new HashSet<LOUE>();
        }
    
        public int ID { get; set; }
        public string IMMATRICULATION { get; set; }
        public string MODELE { get; set; }
        public string COULEUR { get; set; }
        public Nullable<int> ID_MARQUE { get; set; }
        public Nullable<int> ID_CATEGORIE { get; set; }
    
        public virtual CATEGORIE CATEGORIE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOUE> LOUE { get; set; }
        public virtual MARQUE MARQUE { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eAgoraV3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOT_PRODUITS_CHAMBRE_H41
    {
        public int H41_ID { get; set; }
        public Nullable<int> H41_ID_PRODUIT_F13 { get; set; }
        public Nullable<long> H41_ID_CHAMBRE_H03 { get; set; }
    
        public virtual FIN_PRODUITS_F13 FIN_PRODUITS_F13 { get; set; }
        public virtual HOT_CHAMBRE_H03 HOT_CHAMBRE_H03 { get; set; }
    }
}

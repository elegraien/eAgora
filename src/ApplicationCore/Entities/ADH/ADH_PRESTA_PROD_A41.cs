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
    
    public partial class ADH_PRESTA_PROD_A41
    {
        public int A41_ID { get; set; }
        public Nullable<int> A41_ID_PRESTA_A10 { get; set; }
        public Nullable<int> A41_ID_PRODUIT_F13 { get; set; }
        public Nullable<decimal> A41_PRIX_HT { get; set; }
    
        public virtual ADH_PRESTATION_A10 ADH_PRESTATION_A10 { get; set; }
        public virtual FIN_PRODUITS_F13 FIN_PRODUITS_F13 { get; set; }
    }
}
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
    
    public partial class FIN_CORRESPONDANCE_UNITE_F55
    {
        public int F55_ID { get; set; }
        public Nullable<int> F55_ID_PRODUIT_F13 { get; set; }
        public Nullable<decimal> F55_RATIO_FP { get; set; }
        public Nullable<decimal> F55_RATIO_PF { get; set; }
        public Nullable<decimal> F55_RATIO_FA { get; set; }
        public Nullable<decimal> F55_RATIO_AF { get; set; }
        public Nullable<decimal> F55_RATIO_PA { get; set; }
        public Nullable<decimal> F55_RATIO_AP { get; set; }
        public Nullable<int> F55_ID_UNITE_VENTE_F20 { get; set; }
        public Nullable<int> F55_ID_UNITE_ACHAT_F20 { get; set; }
        public Nullable<int> F55_ID_UNITE_PROD_F20 { get; set; }
    
        public virtual FIN_TYPE_UNITE_F20 FIN_TYPE_UNITE_F20 { get; set; }
        public virtual FIN_TYPE_UNITE_F20 FIN_TYPE_UNITE_F201 { get; set; }
        public virtual FIN_TYPE_UNITE_F20 FIN_TYPE_UNITE_F202 { get; set; }
    }
}

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
    
    public partial class FIN_PRODUIT_CATEG_F27
    {
        public int F27_ID { get; set; }
        public Nullable<int> F27_PRODUITS_F13 { get; set; }
        public Nullable<int> F27_CATEGORIE_PRODUIT_F02 { get; set; }
        public Nullable<decimal> F27_QTE { get; set; }
        public Nullable<decimal> F27_COEF { get; set; }
        public Nullable<short> F27_INSERT_AUTO { get; set; }
        public Nullable<short> F27_OBLIGATOIRE { get; set; }
        public Nullable<short> F27_ORDRE { get; set; }
        public Nullable<short> F27_FLAG_NOT { get; set; }
        public Nullable<short> F27_MODIFIABLE { get; set; }
        public Nullable<double> F27_RATIO { get; set; }
        public Nullable<float> F27_QTE_PAR_UNITE { get; set; }
        public Nullable<int> F27_UNITE_F31 { get; set; }
        public Nullable<short> F27_USE_RATIO { get; set; }
    
        public virtual FIN_CATEGORIE_PRODUIT_F02 FIN_CATEGORIE_PRODUIT_F02 { get; set; }
        public virtual FIN_PRODUITS_F13 FIN_PRODUITS_F13 { get; set; }
    }
}

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
    
    public partial class GRC_VOIRIE_G53
    {
        public int G53_ID { get; set; }
        public string G53_LIBELLE { get; set; }
        public Nullable<int> G53_NUM_VOIE { get; set; }
        public Nullable<int> G53_NUM_DEB { get; set; }
        public Nullable<int> G53_NUM_FIN { get; set; }
        public string G53_CODE_PAIR { get; set; }
        public string G53_PARITE { get; set; }
        public Nullable<int> G53_ID_QUARTIER_G57 { get; set; }
        public Nullable<int> G53_ID_TYPE_VOIRIE_G56 { get; set; }
        public Nullable<int> G53_ID_DETERMINANT_G55 { get; set; }
        public Nullable<int> G53_ID_CODE_RIVOLI_G58 { get; set; }
    
        public virtual GRC_CODE_RIVOLI_G58 GRC_CODE_RIVOLI_G58 { get; set; }
        public virtual GRC_DETERMINANT_G55 GRC_DETERMINANT_G55 { get; set; }
        public virtual GRC_QUARTIER_G57 GRC_QUARTIER_G57 { get; set; }
        public virtual GRC_TYPE_VOIRIE_G56 GRC_TYPE_VOIRIE_G56 { get; set; }
    }
}
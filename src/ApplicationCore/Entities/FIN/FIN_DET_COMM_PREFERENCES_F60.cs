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
    
    public partial class FIN_DET_COMM_PREFERENCES_F60
    {
        public long F60_ID { get; set; }
        public Nullable<long> F60_ID_DETAIL_COMMANDE_F07 { get; set; }
        public Nullable<int> F60_ID_PREFERENCES_F59 { get; set; }
    
        public virtual FIN_DETAILS_COMMANDES_F07 FIN_DETAILS_COMMANDES_F07 { get; set; }
        public virtual FIN_PREFERENCES_F59 FIN_PREFERENCES_F59 { get; set; }
    }
}

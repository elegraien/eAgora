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
    
    public partial class BIL_BADGE_MODELE_B02
    {
        public int B02_ID { get; set; }
        public string B02_LIBELLE { get; set; }
        public string B02_BACKGROUND_IMAGE { get; set; }
        public string B02_CONDITIONS_USER { get; set; }
        public Nullable<long> B02_ID_MANIF_M14 { get; set; }
        public Nullable<int> B02_ID_STATUT_A13 { get; set; }
        public string B02_LOGO_IMAGE { get; set; }
        public string B02_BANNER_IMAGE { get; set; }
        public string B02_NOM_CHAMP_HEADER { get; set; }
        public string B02_NOM_CHAMP_LINE1 { get; set; }
        public string B02_NOM_CHAMP_LINE2 { get; set; }
    
        public virtual ADH_STATUT_A13 ADH_STATUT_A13 { get; set; }
        public virtual MAN_MANIFESTATIONS_M14 MAN_MANIFESTATIONS_M14 { get; set; }
    }
}

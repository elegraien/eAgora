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
    
    public partial class INV_COL_GRDCTC_I04
    {
        public int I04_ID { get; set; }
        public Nullable<long> I04_ID_ADMIN_A48 { get; set; }
        public Nullable<int> I04_ORDRE { get; set; }
        public Nullable<short> I04_TYPEMAPPING { get; set; }
        public Nullable<short> I04_VISIBLE { get; set; }
        public string I04_NOM_TBL { get; set; }
        public string I04_NOM_COL { get; set; }
        public string I04_FILTRE { get; set; }
        public string I04_FORMAT { get; set; }
        public string I04_TYPE { get; set; }
        public string I04_SPECIFICSQL { get; set; }
        public string I04_FOREIGNKEY_FIELD_NAME { get; set; }
        public Nullable<int> I04_ID_CHAMP_DYNAMIQUE_C54 { get; set; }
        public string I04_FIELD_TYPE { get; set; }
        public string I04_LIST_SQL { get; set; }
        public Nullable<int> I04_ID_LIB { get; set; }
        public string I04_CPL_LIB { get; set; }
        public Nullable<short> I04_CONTROLE { get; set; }
    
        public virtual CFG_CHAMP_DYNAMIQUE_C54 CFG_CHAMP_DYNAMIQUE_C54 { get; set; }
    }
}
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
    
    public partial class PDC_TEMPLATE_P08
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PDC_TEMPLATE_P08()
        {
            this.FIN_EXPORT_COMPTA_AUTO_F49 = new HashSet<FIN_EXPORT_COMPTA_AUTO_F49>();
        }
    
        public int P08_ID { get; set; }
        public string P08_NOM { get; set; }
        public Nullable<int> P08_ID_APPLICATION_P03 { get; set; }
        public Nullable<int> P08_ID_TEMPLATE_LOCAL_P09 { get; set; }
        public Nullable<int> P08_ID_USER_C18 { get; set; }
        public Nullable<int> P08_ID_CONTEXTE_P01 { get; set; }
        public Nullable<int> P08_ID_DOSSIER_P05 { get; set; }
        public Nullable<int> P08_ID_REQUETE { get; set; }
        public Nullable<int> P08_ID_TYPE { get; set; }
        public string P08_NOM_MENU { get; set; }
        public string P08_REQUETE { get; set; }
        public Nullable<short> P08_MENU_DIRECT { get; set; }
        public Nullable<short> P08_TMP_DIR { get; set; }
        public Nullable<int> P08_ID_SOC_C13 { get; set; }
        public Nullable<short> P08_PDF { get; set; }
        public Nullable<short> P08_COPIE { get; set; }
        public string P08_TEXT { get; set; }
        public Nullable<short> P08_ISTEXT { get; set; }
        public string P08_DESC_USE { get; set; }
        public Nullable<short> P08_TACTILE { get; set; }
        public Nullable<int> P08_ID_IMPRIMANTE_P21 { get; set; }
        public Nullable<int> P08_TYPEDOC_C08 { get; set; }
        public Nullable<int> P08_ID_LANG_C40 { get; set; }
        public string P08_OBJETMAIL { get; set; }
        public Nullable<int> P08_SS_CONTEXTE { get; set; }
    
        public virtual CFG_SOCIETE_C13 CFG_SOCIETE_C13 { get; set; }
        public virtual CFG_UTILISATEURS_C18 CFG_UTILISATEURS_C18 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_EXPORT_COMPTA_AUTO_F49> FIN_EXPORT_COMPTA_AUTO_F49 { get; set; }
        public virtual PDC_CONTEXTE_P01 PDC_CONTEXTE_P01 { get; set; }
        public virtual PDC_DOCUMENT_EDITEUR_P03 PDC_DOCUMENT_EDITEUR_P03 { get; set; }
        public virtual PDC_DOSSIER_TEMPLATE_P05 PDC_DOSSIER_TEMPLATE_P05 { get; set; }
        public virtual PDC_TEMPLATE_LOCAL_P09 PDC_TEMPLATE_LOCAL_P09 { get; set; }
    }
}

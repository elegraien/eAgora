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
    
    public partial class ADH_EPARTICIPANT_ADMIN_A48
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ADH_EPARTICIPANT_ADMIN_A48()
        {
            this.ADH_LIST_IMPORT_A60 = new HashSet<ADH_LIST_IMPORT_A60>();
            this.CFG_CHAMP_DYNAMIQUE_C54 = new HashSet<CFG_CHAMP_DYNAMIQUE_C54>();
            this.INV_ADMIN_PROFILES_I201 = new HashSet<INV_ADMIN_PROFILES_I20>();
            this.INV_NOTIFICATION_I28 = new HashSet<INV_NOTIFICATION_I28>();
            this.INV_CHAMPS_PRIORISES_I29 = new HashSet<INV_CHAMPS_PRIORISES_I29>();
            this.USR_MESSAGE_U14 = new HashSet<USR_MESSAGE_U14>();
            this.USR_MESSAGE_ARCHIVE_U22 = new HashSet<USR_MESSAGE_ARCHIVE_U22>();
            this.USR_ITEM_PORTAIL_U33 = new HashSet<USR_ITEM_PORTAIL_U33>();
            this.USR_SITE_VITRINE_CONFIGURATION_U34 = new HashSet<USR_SITE_VITRINE_CONFIGURATION_U34>();
            this.USR_TYPE_ACTUALITES_U35 = new HashSet<USR_TYPE_ACTUALITES_U35>();
            this.USR_TYPE_OUTILS_U36 = new HashSet<USR_TYPE_OUTILS_U36>();
            this.USR_RESTRICTIONS_EDITEUR_U37 = new HashSet<USR_RESTRICTIONS_EDITEUR_U37>();
            this.WEB_EXTERNAL_MAPPINGS_W02 = new HashSet<WEB_EXTERNAL_MAPPINGS_W02>();
        }
    
        public int A48_ID { get; set; }
        public string A48_LOGIN { get; set; }
        public string A48_PASSWORD { get; set; }
        public string A48_NOM { get; set; }
        public string A48_PRENOM { get; set; }
        public Nullable<int> A48_TITRE_A15 { get; set; }
        public Nullable<int> A48_ID_MANIF_M14 { get; set; }
        public Nullable<int> A48_ID_DROIT_A49 { get; set; }
        public Nullable<long> A48_ID_CTC_G03 { get; set; }
        public string A48_EMAIL { get; set; }
        public string A48_TEMPLATE { get; set; }
        public Nullable<System.DateTime> A48_DATE_FIN_ABT { get; set; }
        public Nullable<int> A48_ID_ADM_A48 { get; set; }
        public Nullable<short> A48_ALL_EVT { get; set; }
        public string A48_LOGO { get; set; }
        public Nullable<short> A48_NBMAN { get; set; }
        public Nullable<short> A48_RV { get; set; }
        public Nullable<int> A48_ID_RV_A48 { get; set; }
        public Nullable<int> A48_MAX_PART { get; set; }
        public Nullable<int> A48_MAX_INVITE { get; set; }
        public Nullable<int> A48_MAX_MAIL { get; set; }
        public Nullable<short> A48_TAILLE_GAL { get; set; }
        public Nullable<short> A48_TROMBI { get; set; }
        public Nullable<short> A48_MUR { get; set; }
        public Nullable<short> A48_FACT { get; set; }
        public Nullable<short> A48_PAIEMENT_EL { get; set; }
        public Nullable<short> A48_ENQSAT { get; set; }
        public Nullable<short> A48_MULTILANG { get; set; }
        public Nullable<short> A48_GESTABLE { get; set; }
        public Nullable<int> A48_ID_LIEU_M07 { get; set; }
        public Nullable<short> A48_EBILLET { get; set; }
        public string A48_HMAIL_ADDRESS { get; set; }
        public Nullable<int> A48_HMAIL_ID { get; set; }
        public Nullable<int> A48_ID_PROFILE_I20 { get; set; }
        public string A48_SENDGRID_PASSWORD { get; set; }
        public string A48_SENDGRID_USER { get; set; }
        public Nullable<short> A48_PROTEGER_MDP { get; set; }
        public Nullable<short> A48_CREATE_EVENT { get; set; }
        public Nullable<short> A48_CONTACTS { get; set; }
        public string A48_MD5_HASH { get; set; }
        public Nullable<short> A48_PROFILS_CTC { get; set; }
        public Nullable<short> A48_APPROUVE_MAIL { get; set; }
        public Nullable<short> A48_APPROUVE_CPT_MAIL { get; set; }
        public Nullable<short> A48_ISOLE { get; set; }
        public Nullable<int> A48_ID_CSS_A51 { get; set; }
        public string A48_URL_GEN { get; set; }
        public Nullable<short> A48_HOTELIER { get; set; }
        public Nullable<int> A48_MAX_SMS { get; set; }
        public Nullable<short> A48_SMS { get; set; }
        public Nullable<short> A48_EMAILS_VIDES { get; set; }
        public Nullable<int> A48_LANGUE_C40 { get; set; }
        public Nullable<short> A48_DROIT_PAYBOX_BILLETTERIE { get; set; }
        public string A48_SMS_SENDER { get; set; }
        public Nullable<short> A48_HIERARCHIE { get; set; }
        public Nullable<short> A48_NB_ADMIN { get; set; }
        public string A48_CODE_AFFIL { get; set; }
        public string A48_CODE_AFFILIANT { get; set; }
        public Nullable<short> A48_MAILING { get; set; }
        public Nullable<short> A48_CATEGORIES { get; set; }
        public Nullable<short> A48_IS_DEDICATED { get; set; }
        public Nullable<int> A48_ID_FORM_U28 { get; set; }
        public Nullable<short> A48_APP_MOBILE { get; set; }
        public Nullable<short> A48_AFFICHAGE_CTC { get; set; }
        public Nullable<short> A48_INACTIF { get; set; }
        public Nullable<int> A48_TOKEN_NOTIFICATION { get; set; }
        public Nullable<int> A48_ID_USER_C18 { get; set; }
        public Nullable<short> A48_VITRINE { get; set; }
        public Nullable<short> A48_RESTRICT_COLOR { get; set; }
        public Nullable<short> A48_RESTRICT_FONT { get; set; }
        public Nullable<short> A48_RESTRICT_FONT_SIZE { get; set; }
    
        public virtual INV_ADMIN_PROFILES_I20 INV_ADMIN_PROFILES_I20 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADH_LIST_IMPORT_A60> ADH_LIST_IMPORT_A60 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CFG_CHAMP_DYNAMIQUE_C54> CFG_CHAMP_DYNAMIQUE_C54 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_ADMIN_PROFILES_I20> INV_ADMIN_PROFILES_I201 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_NOTIFICATION_I28> INV_NOTIFICATION_I28 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_CHAMPS_PRIORISES_I29> INV_CHAMPS_PRIORISES_I29 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USR_MESSAGE_U14> USR_MESSAGE_U14 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USR_MESSAGE_ARCHIVE_U22> USR_MESSAGE_ARCHIVE_U22 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USR_ITEM_PORTAIL_U33> USR_ITEM_PORTAIL_U33 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USR_SITE_VITRINE_CONFIGURATION_U34> USR_SITE_VITRINE_CONFIGURATION_U34 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USR_TYPE_ACTUALITES_U35> USR_TYPE_ACTUALITES_U35 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USR_TYPE_OUTILS_U36> USR_TYPE_OUTILS_U36 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USR_RESTRICTIONS_EDITEUR_U37> USR_RESTRICTIONS_EDITEUR_U37 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WEB_EXTERNAL_MAPPINGS_W02> WEB_EXTERNAL_MAPPINGS_W02 { get; set; }
    }
}

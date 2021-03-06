//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace aspprojet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Web;

    public partial class article
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nom d'article est obligatoire", AllowEmptyStrings = false)]
        public string nom_art { get; set; }
        [Required(ErrorMessage = "la description est obligatoire", AllowEmptyStrings = false)]
        public string description { get; set; }
        [Required(ErrorMessage = "la categorie est obligatoire", AllowEmptyStrings = false)]
        public string categorie { get; set; }
        [Required(ErrorMessage = "le prix est obligatoire", AllowEmptyStrings = false)]
        public double prix { get; set; }
        [DisplayName("")]
        public string img_art { get; set; }
        [Required(ErrorMessage = "la marque est obligatoire", AllowEmptyStrings = false)]
        public string marque { get; set; }

        public Nullable<int> fk_prop { get; set; }
        public Nullable<int> fk_offre { get; set; }

        public virtual offre offre { get; set; }
        public virtual proprietaire proprietaire { get; set; }
        public HttpPostedFileBase ImageFile { get; set; }
    }
}

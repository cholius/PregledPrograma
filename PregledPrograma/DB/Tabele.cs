using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PregledPrograma.DB
{
    [Table("Kosuljice")]
    public class Kosuljica
    {
        [Key]
        public int ID { get; set; }
        public DateTime? StartEmisije { get; set; }
        public TimeSpan? DuracijaEmisije { get; set; }
        public string NaslovEmisije { get; set; }
        public Zanr Zanr { get; set; }
        public TipEmitovanja TipEmitovanja { get; set; }
        public Redakcija Redakcija { get; set; }
        public int? BrojEpizode { get; set; }
        public string OpisEmisije { get; set; }
        public Rejting Rejting { get; set; }
        public string Komentar { get; set; }
        public string CodSat { get; set; }
    }
     [Table("Zanrovi")]
    public class Zanr
    {
        [Key]
        public int ID { get; set; }
        public string NazivZanra { get; set; }
    }
     [Table("TipoviEmitovanja")]
    public class TipEmitovanja
    {
        [Key]
        public int ID { get; set; }
        public string Tip { get; set; }
    }
     [Table("Redakcije")]
    public class Redakcija
    {
        [Key]
        public int ID { get; set; }
        public string NazivRedakcije { get; set; }
    }
     [Table("Rejtinzi")]
    public class Rejting
    {
        [Key]
        public int ID { get; set; }
        public string OznakaRejtinga { get; set; }
    }
}

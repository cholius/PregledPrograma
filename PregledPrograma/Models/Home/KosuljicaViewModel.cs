using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PregledPrograma.Models.Home
{
    public class KosuljicaViewModel
    {
        public int ID { get; set; }
        [DisplayFormat(DataFormatString = "{0:HH:mm}")]
        public DateTime? StartEmisije { get; set; }
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}")]
        public TimeSpan? DuracijaEmisije { get; set; }
        public string NaslovEmisije { get; set; }
        public string Zanr { get; set; }
        public string TipEmitovanja { get; set; }
        public string NazivRedakcije { get; set; }
        public int? BrojEpizode { get; set; }
        public string OpisEmisije { get; set; }
        public string Rejting { get; set; }
        public string Komentar { get; set; }
        public string CodSat { get; set; }
    }
}
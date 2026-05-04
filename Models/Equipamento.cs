using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace ValeAtivos324111440.Models
{
    public class Equipamento
    {
        [Key]
        public int Id {get; set;}

        [Required(ErrorMessage = "O nome do equipamento é obrigatório")]
        public string Nome {get; set;}

        [Required(ErrorMessage = "O tipo do equipamento é obrigatório")]
        public string Tipo {get; set;}

        [Required(ErrorMessage = "A localização do equipamento é obrigatória")]
        public string Localizacao {get; set;}

        [Required(ErrorMessage = "A capacidade de processamento do equipamento é obrigatória")]
        public double CapacidadeProcessamento {get; set;}

        public DateTime? DataUltimaManutencao {get; set;}

        [Required(ErrorMessage = "Por favor, informe se o equipamento está em operação no momento")]
        public bool EmOperacao {get; set;}
    }
}
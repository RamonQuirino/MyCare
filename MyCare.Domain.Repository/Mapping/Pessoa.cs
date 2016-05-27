using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using MyCare.Domain.Repository.Mapping.Enums.Pessoa;

namespace MyCare.Domain.Repository.Mapping
{
    public class Pessoa
    {
        public long ID { get; set; }
        public string Nome { get; set; }
        public string Sobreno { get; set; }
        public DateTime Nascimento { get; set; }
        public Sexo Sexo { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
    }

   
}

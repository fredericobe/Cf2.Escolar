using System;
using System.Collections.Generic;
using System.Text;

namespace Cf2.Escolar.Domain.Admin
{
    public class Sala
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Descricao { get; set; }
        public virtual int Capacidade { get; set; }
        public virtual string Referencia { get; set; }
    }
}

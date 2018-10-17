using System;
using System.Collections.Generic;

namespace Cf2.Escolar.Domain.Admin
{
    public class Escola
    {
        public virtual int Id { get; set; }

     
        public virtual string Nome { get; set; }

        public virtual string Cnpj { get; set; }

      
        public virtual string Rua { get; set; }

        public virtual string CEP { get; set; }

        public virtual string Complemento { get; set; }

        public virtual string Bairro { get; set; }
        
        public virtual string Cidade { get; set; }

        public virtual string Estado { get; set; }

       
        public virtual string Pais { get; set; }

        public virtual string ImagemLogo { get; set; }

        public virtual List<Filial> Filiais { get; set; }
    }
}

using System.Collections.Generic;

namespace Cf2.Escolar.Domain.Admin
{
    public class Filial
    {
        public Filial()
        {
            this.Salas = new List<Sala>();
        }
        public virtual int Id { get; set; }
        
        public virtual string Nome { get; set; }

        public virtual bool Matriz { get; set; }
   
        public virtual string Cnpj { get; set; }

        public virtual string Rua { get; set; }
 
        public virtual string CEP { get; set; }

        public virtual string Complemento { get; set; }
    
        public virtual string Bairro { get; set; }

        public virtual string Cidade { get; set; }

        public virtual string Estado { get; set; }

        public virtual string Pais { get; set; }

        public virtual Escola Escola { get; set; }

        public virtual IList<Sala> Salas { get; set; }
    }
}

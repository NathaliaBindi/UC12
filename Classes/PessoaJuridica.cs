using UC12.Interfaces;

namespace UC12.Classes
{
        public abstract class PessoaJuridica : Pessoa, IPessoaJuridica
        {

            public string? Cnpj { get; set; }

            public string? RazaoSocial { get; set; }  
            

                public bool ValidarCnpj(string cnpj)
                {
                        throw new NotImplementedException();
                }
        }
}
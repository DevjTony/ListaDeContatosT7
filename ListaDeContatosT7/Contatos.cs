using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatosT7
{
    internal class Contatos
    {
        private string nome;
        private string sobrenome;
        private string telefone;

        /*propriedades("get" e "set")
        é um controle de acesso as variáveis*/
        public string Nome
        {
            get
            {

                return nome;

            }
            set
            {

                nome = value;

            }
        }
        public string Sobrenome
        {
            get
            {

                return sobrenome;

            }
            set
            {

                sobrenome = value;

            }
        }
        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                if (value.Length == 13)
                {
                    telefone = value;
                }
                else
                {
                    /* Pais-Cidade-Telefone. ex, +55-11-91234-5678 */
                    telefone = "+00-00-00000-0000";
                }
            }
        }

        //o método que tem o mesmo nome da classe
        // e não retorna nada. é chamado CONSTRUTOR DA CLASSE.
        public Contatos()
        {
            nome = "Tony Cleyton";
            Sobrenome = "Gonçalves De Jesus";
            telefone = "+55-11-98123-7890";

        }
        public Contatos(string nome, string sobrenome, string telefone)
        {

            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;

        }
        //sobrescreve o método ToString();
        //"poliformismo"
        public override string ToString()
        {
            string saida = string.Empty;
            saida += string.Format("{0}, {1}" , Nome, Sobrenome);
            saida += string.Format("+{0} ({1}) {2}-{3}", 
                Telefone.Substring(0,2), //55
                Telefone.Substring(2,2), //11
                Telefone.Substring(4,5),//98567-
                Telefone.Substring(9,4) ); //0000
            return saida;
            
        }
    }
}

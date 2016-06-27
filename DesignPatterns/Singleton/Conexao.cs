using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesingnPatternsFCV.Singleton
{
    /// <summary>
    /// Exemplo do Pattern Singleton, garante uma única instáncia da classe
    /// </summary>
    public class Conexao
    {
        private static Conexao instance;

        protected Conexao() { }
                
        public static Conexao GetInstance()
        {
            if (instance == null)
                instance = new Conexao();

            return instance;                
        }
    }
}

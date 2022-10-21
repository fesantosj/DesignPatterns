using static System.Console;

namespace Singleton{
    /// <summary>
    /// Singleton
    /// </summary>
    public class LogEventos{
        /// <summary>
        /// Instancia
        /// </summary>
        private static LogEventos? _instancia;
        public static LogEventos Instance{
            get{
                if(_instancia == null)
                    _instancia = new LogEventos();                
                return _instancia;
            }
        }
        protected LogEventos(){

        }

        public void ImprimirConsole(string mensagem){
            WriteLine($"Aviso! -> {mensagem}");
        }  
    }
}

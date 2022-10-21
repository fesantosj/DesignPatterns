using Singleton;

    Console.Title = "Singleton Pattern";
    
    var log = LogEventos.Instance;
    var log2 = LogEventos.Instance;
    
    if((log2 is LogEventos) && log == log2)
        log.ImprimirConsole("Vejam só, Log2 é uma instancia de LogEventos, assim como log.");    

    log2.ImprimirConsole("Finalizando execução!");


    

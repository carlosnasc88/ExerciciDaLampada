bool lampadaLigada = true;
bool continunar = true;


while(continunar){
   
  
    if (lampadaLigada){
        System.Console.WriteLine("Esta do Lampada: Ligado");
    }else{
        System.Console.WriteLine("Estado a Lampada: Desligada");
    }
    

    System.Console.WriteLine();
    System.Console.WriteLine("Escolha um aopção");
    System.Console.WriteLine("1 - Ligar a Lampada");
    System.Console.WriteLine("2 - Desligar a Lampada");
    System.Console.WriteLine("3 - Ecenrrar  Programa");
    System.Console.WriteLine();
    System.Console.WriteLine("Opção: ");
    string opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
        if(lampadaLigada)
        {
            System.Console.WriteLine("A lapada já está ligada...");
        }
        else
        {            
            lampadaLigada =true;
        }
        break;

        case "2":
        if(lampadaLigada)
        {
            lampadaLigada=false;    
        }
        else
        {
            
           System.Console.WriteLine("A lampada já está desligada"); 
        }
        break;

        case "3":
        System.Console.WriteLine("Encerrando sisemta....");
        break;

        default:
        System.Console.WriteLine("Opacão invalida, tente novamente.");
        break;

    }
    System.Console.WriteLine();
    
}


using System; 
class URI {
static void Main(string[] args) { 

        string senha="2002";  
        string senhauser; 

        do{                    
            senhauser=Console.ReadLine();   

            if(senha != senhauser){

                Console.WriteLine("Senha Invalida"); 
            }

        }while(senha != senhauser);               

        Console.WriteLine("Acesso Permitido"); 

    }

}

namespace oop { 
    class Program {
        static void Main(){
            bool running = true;
                
            while (running){
                TryCatch.Test();
                Thread.Sleep(1500);
                
                Console.WriteLine("Do you want to exit? (y/n)");
                string input = Console.ReadLine();
                
                if (input.ToLower() == "no" || input.ToLower() == "ne" || input.ToLower() == "exit") {
                    running = false;
                }
                
                Jachym.Klir();
            }
            
        }    
    }

}
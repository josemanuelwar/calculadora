using System.Diagnostics.Contracts;

namespace calculadora
{
    public static class menu
    {
        
        public static void Options(){
            Operations op;
            int option=0;
            do
            {
                double numberA=0;
                double numberB=0;
                Console.WriteLine("---- Calculadora ---");
                Console.WriteLine("Que operacion nesecita realizar?");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Divicion");
                Console.WriteLine("5. Salir");
                
                
                
                option = Convert.ToInt32(Console.ReadLine());

                switch(option){
                    case 1:
                        Console.WriteLine("Ingresa el primer numero");
                        numberA=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingresa el segundo numero");
                        numberB=Convert.ToDouble(Console.ReadLine());
                        op = new Operations(numberA,numberB);
                        Console.WriteLine(op.sum());
                    break;

                    case 2:
                        Console.WriteLine("Ingresa el primer numero");
                        numberA=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingresa el segundo numero");
                        numberB=Convert.ToDouble(Console.ReadLine());
                        op = new Operations(numberA,numberB);
                        Console.WriteLine(op.subtraction());
                    break;
                    
                    case 3:
                        Console.WriteLine("Ingresa el primer numero");
                        numberA=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingresa el segundo numero");
                        numberB=Convert.ToDouble(Console.ReadLine());
                        op = new Operations(numberA,numberB);
                        Console.WriteLine(op.multiplication());
                    break;
                    
                    case 4:
                        Console.WriteLine("Ingresa el primer numero");
                        numberA=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingresa el segundo numero");
                        numberB=Convert.ToDouble(Console.ReadLine());
                        op = new Operations(numberA,numberB);
                        Console.WriteLine(op.division());
                    break;
                }
            } while (option!=5);
        }
    }
}
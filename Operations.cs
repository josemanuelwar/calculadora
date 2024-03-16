namespace calculadora
{
    public class Operations
    {
        public double oneNumber { get;set; }

        public double twoNumber { get;set; }

        public Operations(double oneNumber,double twoNumber){
            this.oneNumber=oneNumber;
            this.twoNumber=twoNumber;   
        }

        public double sum(){
            return this.oneNumber+this.twoNumber;
        }

        public double subtraction(){
            return this.oneNumber-this.twoNumber;
        }

        public double multiplication(){
            return this.oneNumber*this.twoNumber;
        }

        public double division(){
            if(this.oneNumber>0 && this.twoNumber>0){
                return this.oneNumber/this.twoNumber;
            }
            return 0;
        }
    }
}
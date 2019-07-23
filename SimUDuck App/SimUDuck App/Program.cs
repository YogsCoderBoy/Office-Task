using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck_App{
    

    public abstract class Duck
    {
         private  ISoundable Soundability;
         private Iflyable Flyability;
         public Duck()
         {

         
         }
      
        public abstract void Display();
        public virtual void Swim()
        {
            Console.WriteLine("I am Swiming");
        }
        
        public void DiffQuck()
        {
            Soundability.Quack();
        }
       
        public void FlyBehave()
        {
            Flyability.Fly();
        }
        public void SetSoundability(ISoundable ISD)
        {
            Soundability = ISD;
        }
        public void SetFlyability(Iflyable IFB)
        {
            Flyability = IFB;
        }
        
    }
    
    public interface Iflyable
    {
        void Fly();
    }
    public interface ISoundable
    {
        void Quack();
    }
    public class QuackVoice : ISoundable
    {
        public void Quack()
        {
            Console.WriteLine("My Voice : Quack");
        }
    }
   public class SqueakVoice : ISoundable
    {
            public void Quack()
            {
            Console.WriteLine("My Voice : Squeak");
        }
    }
    public class Silent : ISoundable
    {
        public void Quack()
        {
            Console.WriteLine("I am Silent");
        }
    }
    public class FlyDucks : Iflyable
    {
        public void Fly()
        {
            Console.WriteLine("I am Flying Duck");
        }
    }
    public class NonFlyDucks:Iflyable
    {
        public void Fly()
        {
            Console.WriteLine("I am NonFlying Duck");
        }
    }

   
    public class MallardDuck : Duck
    {
        
        
         public override void Display()  { Console.WriteLine("My Duck Type: MallardDuck"); }
       
    }


 public class RedhetDuck : Duck
    {
        
         public override void Display() { Console.WriteLine("My Duck Type: RedhetDuck"); }
      
    }

   public class RubberDuck : Duck 
    {
        public override void Display(){ Console.WriteLine("My Duck Type: RubberDuck"); }
       
    }
    public class WoodenDuck : Duck
    {
    
    public override void Display(){ Console.WriteLine("My Duck Type: WoodenDuck "); }
    }

    
   public class Ducktest
    {

       public static void Main(string[] args)
        {
            Duck MallarD = new MallardDuck();
            MallarD.Display();
            MallarD.SetFlyability(new FlyDucks());
            MallarD.FlyBehave();
            MallarD.Swim();
            MallarD.SetSoundability(new QuackVoice());
            MallarD.DiffQuck();
            

            Duck RedhetD = new RedhetDuck();
            RedhetD.Display();
            RedhetD.SetFlyability(new FlyDucks());
            RedhetD.FlyBehave();
            RedhetD.Swim();
            RedhetD.SetSoundability(new QuackVoice());
            RedhetD.DiffQuck();
            

            Duck RubberD = new RubberDuck();
            RubberD.Display();
            RubberD.Swim();
            RubberD.SetFlyability(new NonFlyDucks());
            RubberD.FlyBehave();
            RubberD.SetSoundability(new SqueakVoice());
            RubberD.DiffQuck();
            

            Duck WoodenD = new WoodenDuck();
            WoodenD.Display();
            WoodenD.Swim();
            WoodenD.SetFlyability(new NonFlyDucks());
            WoodenD.FlyBehave();
            WoodenD.SetSoundability(new Silent());
            WoodenD.DiffQuck();


        }
    }
}



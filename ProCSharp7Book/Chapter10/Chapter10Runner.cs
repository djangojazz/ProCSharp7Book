using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter10
{
    internal static class Runner
    {
        //This delegate can point to any method, taking two integers and returning an integer
        public delegate int BinaryOp(int x, int y);

        public delegate void MyGenericDelegate<T>(T arg);

        internal static void SimpleDelegate()
        {
            Console.WriteLine("****** Simple Delegate Example *****");

            //Create a BinaryOp delegate object that "points to" SimpleMath.Add().
            BinaryOp b = new BinaryOp(new SimpleMath().Add);

            DisplayDelegateInfo(b);

            //Invoke Add() method indirectly using delegate object.
            Console.WriteLine($"10 + 10 is {b(10,10)}");
        }

        //internal static void CarRunner()
        //{
        //    Console.WriteLine("****** Delegates as event enablers *****\n");

        //    //First make a car
        //    Car c1 = new Car("SlugBug", 100, 10);

        //    //Now tell the car which method to call when it wants to send messages.
        //    c1.RegisterWithCarEngineHandler(new Car.CarEngineHandler(OnCarEngineEvent));

        //    //Hold onto the delegate object so we can unregister later.
        //    var handler2 = new Car.CarEngineHandler(OnCarEngineEvent2);
        //    c1.RegisterWithCarEngineHandler(handler2);

        //    //Unregister from the second handler.
        //    c1.UnRegisterWithCarEngineHandler(handler2);

        //    //Speed up (this will trigger events).
        //    Console.WriteLine("***** Speeding up ******");
        //    for (int i = 0; i < 6; i++)
        //        c1.Accelerate(20);
        //}

        //internal static void CarRunnerMethodGroup()
        //{
        //    Console.WriteLine("****** Method Group Conversion *****\n");
            
        //    Car c1 = new Car("SlugBug", 100, 10);

        //    //Register with the simple method name
        //    c1.RegisterWithCarEngineHandler(CallMeHere);
            
        //    //Speed up (this will trigger events).
        //    Console.WriteLine("***** Speeding up ******");
        //    for (int i = 0; i < 6; i++)
        //        c1.Accelerate(20);

        //    //Unregister the simple method name.
        //    c1.UnRegisterWithCarEngineHandler(CallMeHere);

        //    //No more notifications!
        //    for (int i = 0; i < 6; i++)
        //        c1.Accelerate(20);
        //}
        
        internal static void GenericDelegate()
        {
            Console.WriteLine("****** Generic Delegates *****\n");

            //register targets
            MyGenericDelegate<string> strTarget = new MyGenericDelegate<string>(StringTarget);
            strTarget("Some string data");

            MyGenericDelegate<int> intTarget = new MyGenericDelegate<int>(IntTarget);
            intTarget(2);
        }

        internal static void GenericFuncAndAction()
        {
            Console.WriteLine("****** Fun with Action and Func *******");

            //Use the Action<> delegate to point to DisplayMessage.
            Action<string, ConsoleColor, int> actionTarget = new Action<string, ConsoleColor, int>(DisplayMessage);
            actionTarget("Action Message!", ConsoleColor.Cyan, 5);

            Func<int, int, int> funcTarget = Add;
            int result = funcTarget.Invoke(40, 40);
            Console.WriteLine($"40 + 40 = {result}");

            Func<int, int, string> functTarget2 = SumToString;
            string sum = functTarget2(90, 300);
            Console.WriteLine(sum);
        }
        
        //internal static void GenericWithCar()
        //{
        //    Console.WriteLine("***** No encapsultion ******\n");
        //    //First make a car
        //    Car c1 = new Car();

        //    c1.listOfHandlers = new Car.CarEngineHandler(CallWhenExploded);
        //    c1.Accelerate(10);

        //    c1.listOfHandlers = new Car.CarEngineHandler(CallHereToo);
        //    c1.Accelerate(10);

        //    c1.listOfHandlers.Invoke("hee, hee, hee...");
        //}

        //internal static void EventSubscribing()
        //{
        //    Console.WriteLine("**** Fun with Events *****\n");
        //    Car c1 = new Car("SlugBug", 100, 10);

        //    //Register event handlers.
        //    c1.AboutToBlow += new Car.CarEngineHandler(CarIsAlmostDoomed);
        //    c1.AboutToBlow += new Car.CarEngineHandler(CarAboutToBlow);

        //    Car.CarEngineHandler d = new Car.CarEngineHandler(CarExploded);
        //    c1.Exploded += d;

        //    Console.WriteLine("******* Speeding up *******");
        //    for (int i = 0; i < 6; i++)
        //        c1.Accelerate(20);

        //    //Remove CarExploded method from invocation list.
        //    c1.Exploded -= d;

        //    Console.WriteLine("\n******* Speeding up *******");
        //    for (int i = 0; i < 6; i++)
        //        c1.Accelerate(20);
        //}

        internal static void EventSubscribing()
        {
            Console.WriteLine("**** Prim and Proper with Events *****\n");
            Car c1 = new Car("SlugBug", 100, 10);

            //Register event handlers.
            c1.AboutToBlow += CarIsAlmostDoomed;
            c1.AboutToBlow += CarAboutToBlow;

            EventHandler<CarEventArgs> d = new EventHandler<CarEventArgs>(CarExploded);
            c1.Exploded += d;

            Console.WriteLine("\n******* Speeding up *******");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
        }

        internal static void AnonymousSubscribing()
        {
            Console.WriteLine("**** Anonymouse Methods *****\n");
            Car c1 = new Car("SlugBug", 100, 10);
            int aboutToBlowCounter = 0;

            //Register event handlers.
            c1.AboutToBlow += delegate
            {
                aboutToBlowCounter++;
                Console.WriteLine("Eek! Going too fast!");
            };

            c1.AboutToBlow += delegate(object sender, CarEventArgs e)
            {
                aboutToBlowCounter++;
                Console.WriteLine($"Message from Car: {e.msg}");
            };

            c1.Exploded += delegate (object sender, CarEventArgs e)
            {
                Console.WriteLine($"Fatal message from Car: {e.msg}");
            };

            Console.WriteLine("\n******* Speeding up *******");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            Console.WriteLine($"About to blow counter was fired {aboutToBlowCounter} times");
        }

        internal static void LambdaSubscribing()
        {
            Console.WriteLine("**** Lambda Subscribing Methods *****\n");
            Car c1 = new Car("SlugBug", 100, 10);
            

            //Register event handlers.
            c1.AboutToBlow += (sender, e) => { Console.WriteLine(e.msg);};
            c1.Exploded += (sender, e) => { Console.WriteLine(e.msg); };
            
            Console.WriteLine("\n******* Speeding up *******");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
        }

        internal static void TraditionalDelegateSyntax()
        {
            //Make a list of integers.
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            //Call FindAll() using traditional delegate syntax.
            Predicate<int> callback = IsEvenNumber;
            List<int> evenNumbers = list.FindAll(callback);

            Console.WriteLine("Here are your evenNumbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write($"{evenNumber}\t");
            }
        }

        internal static void AnnonymousMethodSyntax()
        {
            //Make a list of integers.
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            //Now do an anonymous method.
            List<int> evenNumbers = list.FindAll(i => (i % 2) == 0);

            Console.WriteLine("Here are your evenNumbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write($"{evenNumber}\t");
            }
        }

        #region Private Methods
        private static void DisplayDelegateInfo(Delegate delObj)
        {
            //Print the names of each memeber in the delegate's invocation list.
            foreach (Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine($"Method Name: {d.Method}");
                Console.WriteLine($"Type Name: {d.Target}");
            }
        }

        private static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n***** Message from Car Object ******");
            Console.WriteLine($" => {msg}");
            Console.WriteLine("*********************************\n");
        }

        private static void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine($"=> {msg.ToUpper()}");
        }

        private static void CallMeHere(string msg) => Console.WriteLine($"Message from the car: {msg}");

        private static void StringTarget(string arg) => Console.WriteLine($"arg in uppercase is: {arg.ToUpper()}");
        private static void IntTarget(int arg) => Console.WriteLine($"++arg is: {++arg}");

        private static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
        {
            //Set color of console text.
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;

            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
            }

            //Restore color.
            Console.ForegroundColor = previous;
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }

        private static string SumToString(int x, int y)
        {
            return (x + y).ToString();
        }

        private static void CallWhenExploded(string arg)
        {
            Console.WriteLine(arg);
        }

        private static void CallHereToo(string msg)
        {
            Console.WriteLine(msg);
        }

        private static void CarIsAlmostDoomed(object sender, CarEventArgs e) => Console.WriteLine($"=> Critical Message from Car: {e.msg}");

        private static void CarExploded(object sender, CarEventArgs e) => Console.WriteLine($"{sender} says: {e.msg}");
        private static void CarAboutToBlow(object sender, CarEventArgs e) => Console.WriteLine($"{sender} says: {e.msg}");


        private static bool IsEvenNumber(int i)
        {
            //Is it an even number?
            return (i % 2) == 0;
        }
        #endregion
    }
}

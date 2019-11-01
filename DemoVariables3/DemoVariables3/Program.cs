using static System.Console;
class DemoVariable3
{ 
   static void Main()
    {
        int value = 7;
        bool isSixMore = 9 > value;

        WriteLine("When value is {0} isSixMore is {1}", value, isSixMore);
        value = 45;
        WriteLine("WHne value is {0} isSixMore is {1}", value, isSixMore);
    }
}
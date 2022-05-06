//Console.WriteLine("Please enter number to divide by 2");


// var denom = 1;
//try
//    {
//    denom = Convert.ToInt32(Console.ReadLine());
//    }
//catch (Exception a)
//    { 
//    Console.WriteLine(a.Message);
//    }



//var num = 2;

//if (denom == 0)
//    {
//    var ex = new Exception("Denom is zero, can't be dividing by that number G");
//    throw ex;
//    }

//try
//    {
//    var ans = denom / num;
//    Console.WriteLine($" {num} / {denom} = {ans}");
//    throw new Exception("yikes");
//    }

//catch (DivideByZeroException exception)
//    {
//    Console.WriteLine($"{exception.Message} try a number that isn't zero");
//    }


//catch (Exception ex) //this should be last
//    {
//    Console.WriteLine("Exception inception");
//    }
//finally
//    {
//    Console.WriteLine("Finally");
//    }

A();
Console.WriteLine("Done. . . ");


void A()
    {
    try
        {
        B();
        }
    catch (Exception e)
        {
        Console.WriteLine(e.Message);
        }
    void B()
        {
        Console.WriteLine("Please enter number to divide by 2");
        var denom = Convert.ToInt32(Console.ReadLine());

               var num = 2;

        var c = num / denom;

        Console.WriteLine($" {num} / {denom} = {c}");
        }

    }
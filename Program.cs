Console.WriteLine("Hello, World!");

long bigNum = 90000000;

Console.WriteLine(bigNum);
if(bigNum == 0){
    Console.WriteLine("The number is zero.");
}else{
    Console.WriteLine("The number is not zero.");
}

switch (bigNum){
    case 90000000:
        Console.WriteLine("The number is 90 million.");
        break;
    default:
        Console.WriteLine("The number is something else.");
        break;
}


// Model m = new Model();
// Console.WriteLine("Enter your name:");
//  string Name=Console.ReadLine();
//  Console.Write("hi" + Name);
// m.SetName(Name);
// m.SayHellow();
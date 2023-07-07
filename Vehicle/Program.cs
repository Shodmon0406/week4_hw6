using Vehicle.Classes;

var car = new Car();
car.Start(60);
//Console.WriteLine(car.IsRunning);
//Console.WriteLine(car.Speed);
car.Drive();
car.Stop();
//Console.WriteLine(car.IsRunning);

var motoccycle = new Motorcycle();
motoccycle.Start(60);
//Console.WriteLine(motoccycle.IsRunning);
//Console.WriteLine(motoccycle.Speed);
motoccycle.Drive();
motoccycle.Stop();
//Console.WriteLine(motoccycle.IsRunning);
// Array definition.
String[] cars = {"BMW", "Mustang", "Corvette"};
// Array of objects.
Car[] garage = new Car[3];
Car car1 = new Car("Mustang");
Car car2 = new Car("Corvette");
Car car3 = new Car("Lambo");
garage[0] = car1; 
garage[1] = car2;
garage[2] = car3;
Car[] garage2 = { new Car("Mustang"), new Car("Corvette"), new Car("Lambo") };
// Multi dimensional arrays.
String[] ford = {"Mustang", "F-150", "Explorer"};
String[] chevy = {"Corvette", "Camaro", "Silverado"};
String[] toyota = {"Corolla", "Camry", "Rav4"};

String[,] parkingLot = {{"Mustang", "F-150", "Explorer"}, 
                        {"Corvette", "Camaro", "Silverado"}, 
                        {"Corolla", "Camry", "Rav4"}
                        }; 
parkingLot[0,2] = "Fusion"; // Explorer will change to Fusion
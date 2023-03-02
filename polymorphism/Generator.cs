class AnimalGenerator {
    public static List<Animal> CreateAnimalList() {
        var classes = new List<Type> { 
            typeof(Dog), 
            typeof(Cat), 
            typeof(Chicken), 
            typeof(Pig),
            typeof(Horse),
            typeof(Panda) };

        var animals = new List<Animal>();
        var generator = new Random();

        foreach (var i in Enumerable.Range(1, 100)) {
            var rdm = generator.Next(classes.Count);
            var k = classes[rdm];
            var animal = Activator.CreateInstance(k);
            if (animal != null) {
                animals.Add((Animal)animal);
            }
        }

        return animals;
    }
}

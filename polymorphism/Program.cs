class Program {
    static void Main(string[] args) {
        List<Animal animals = AnimalGenerator.CreateAnimalList();
        
        foreach (var animal in animals) {
            if (animal is Dog) {
                ((Dog)animal).Bark();
            } else if (animal is Cat) {
                ((Cat)animal).Meow();
            } else if (animal is Chicken) {
                ((Chicken)animal).Cluck();
            } else if (animal is Pig) {
                ((Pig)animal).Oink();
            } else if (animal is Horse) {
                ((Horse)animal).Neigh();
            } else if (animal is Panda) {
                ((Panda)animal).Bleat();
            }
        }
    }
}

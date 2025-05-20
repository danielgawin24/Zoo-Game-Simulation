class Animal:
    def __init__(self, name, species):
        self.name = name
        self.species = species
        self.is_fed = False

    def feed(self):
        self.is_fed = True
        print(f"{self.species} {self.name} has been given food.")


class Enclosure:
    def __init__(self, name):
        self.name = name
        self.animals = []

    def addAnimal(self, animal):
        self.animals.append(animal)
        print(f"{animal.name} added to {self.name} enclosure.")


class ZooKeeper:
    def __init__(self, firstName, lastName):
        self.firstName = firstName
        self.lastName = lastName
        self.animals = []

    def assignAnimal(self, animal):
        self.animals.append(animal)
        print(f"{animal.name} assigned to zookeeper: {self.firstName} {self.lastName}.")

    def feedAnimals(self):
        for animal in self.animals:
            animal.feed()


monkey = Animal("Daniel", "Monkey")
bear = Animal("Stanley", "Bear")

forest = Enclosure("Dark Oak Forest")
forest.addAnimal(monkey)
forest.addAnimal(bear)

keeperLewis = ZooKeeper("Lewis", "Hamilton")
keeperLewis.assignAnimal(monkey)
keeperLewis.assignAnimal(bear)

keeperLewis.feedAnimals()

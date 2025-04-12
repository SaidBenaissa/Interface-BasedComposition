IEngine engine = new PetrolEngine();
Car petrolCar = new Car(engine); // PetrolEngine is injected into Car
petrolCar.StartCar();

IEngine hydrogenEngine = new HydrogenEngine();
Car hydrogenCar = new Car(hydrogenEngine); // HydrogenEngine is injected into Car
hydrogenCar.StartCar();
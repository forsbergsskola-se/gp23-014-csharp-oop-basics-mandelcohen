
using P5_2Harvest;

Plant plant = new Plant();
Grain grain = new Grain();
Wheat wheat = new Wheat();

// Grain inherits from Plant
// Wheat inherits from Grain

plant.CanGrow();
grain.CanGrow();
wheat.CanGrow();
//plant.canBeHarvesed
grain.CanBeHarvested();
wheat.CanBeHarvested();
//plant.CanBeProcessedToBread
//grain.CanBeProcessedToBread    
wheat.CanBeProcessedToBread();

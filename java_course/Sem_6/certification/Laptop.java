package Sem_6.certification;

public class Laptop {
    String brand;
    int ram;
    HardDisk hardDisk;
    String os;
    String color;
    int price;

    


    @Override
    public String toString() {
        return "brand: " + brand + ", RAM: " + ram + "Gb, HDD capacity: " + hardDisk.hardDiskCapacity + hardDisk.capacityType + ", OS: " + os + ", color: " + color + ",    price: " + price + "p";
    }
    
}

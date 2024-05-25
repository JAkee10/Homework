package Sem_6.certification;
/*
 * Подумать над структурой класса Ноутбук для магазина техники - выделить поля и методы. Реализовать в java.
Создать множество ноутбуков.
Написать метод, который будет запрашивать у пользователя критерий (или критерии) фильтрации и выведет ноутбуки, отвечающие фильтру. Критерии фильтрации можно хранить в Map.
Например:
“Введите цифру, соответствующую необходимому критерию:
1 - ОЗУ
2 - Объем ЖД
3 - Операционная система
4 - Цвет …
Далее нужно запросить минимальные значения для указанных критериев - сохранить параметры фильтрации можно также в Map.
Отфильтровать ноутбуки из первоначального множества и вывести проходящие по условиям.
 */

import java.util.HashSet;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Random;
import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;

public class Main {
    public static void main(String[] args) {
        String[] brand = {"Macbook", "Lenovo", "MSI", "Asus", "Acer", "HP"};
        int[] ram = {2, 4, 8, 16, 32, 64};
        String[] capacityType = {"Gb", "Tb"};
        int[][] hardDiskCapacity = {{128, 256, 512}, {1, 2, 4}};
        String[] os = {"MacOS", "Windows", "Linux"};
        String[] color = {"White", "Black", "Green", "Red", "Titanium", "Blue Ocean", "Brilliant"};
        
        Set<Laptop> laptops = getRandomSet(100, brand, ram, capacityType, hardDiskCapacity, os, color);

        TreeSet<Integer> prices = new TreeSet<>();
        for (Laptop laptop : laptops) {
            prices.add(laptop.price);
        }
        getSetByFilter(laptops, brand, ram, capacityType, hardDiskCapacity, os, color, prices);
    }
    
    static Set<Laptop> getRandomSet(int count, String[] brand, int[] ram, String[] capacityType, int[][] hardDiskCapacity, String[] os, String[] color) {
        Set<Laptop> laptops = new HashSet<>();
        Random rand = new Random();
        
        for (int i = 0; i < count; i++) { // FillSet
            int capacityTypeID = rand.nextInt(hardDiskCapacity.length); // 0/1 gigabyte/terabyte
            int[] nums = {rand.nextInt(brand.length),                   // [0] brand
                rand.nextInt(ram.length),                               // [1] RAM
                rand.nextInt(hardDiskCapacity[capacityTypeID].length),  // [2] hard disk capacity
                rand.nextInt(os.length),                                // [3] os
                rand.nextInt(color.length),                             // [4] color
                rand.nextInt(200000 - 70000) + 70000};                  // [5] price

                // Macbook <=> MacOS
            if (nums[0] == 0) {
                nums[3] = 0;
            }
            if (nums[3] == 0 && nums[0] != 0) {
                nums[3] = rand.nextInt(os.length - 1) + 1;
            }
            
            Laptop laptop = new Laptop();
            laptop.brand = brand[nums[0]];
            laptop.ram = ram[nums[1]];
            laptop.os = os[nums[3]];
            laptop.color = color[nums[4]];
            laptop.price = nums[5];
            
            HardDisk hd = new HardDisk();
            hd.capacityType = capacityType[capacityTypeID];
            hd.hardDiskCapacity = hardDiskCapacity[capacityTypeID][nums[2]];
            laptop.hardDisk = hd;
            
            laptops.add(laptop);
        }
        return laptops;
    }

    static void getSetByFilter(Set<Laptop> laptops, String[] brand, int[] ram, String[] capacityType, int[][] hardDiskCapacity, String[] os, String[] color, TreeSet<Integer> prices) {
        Set<Laptop> result = new HashSet<>();
        Map<Integer, Integer> filter = new LinkedHashMap<>();
        filter.put(1, null);
        filter.put(2, null);
        filter.put(3, null);
        filter.put(4, null);
        filter.put(5, null);
        filter.put(6, null);
        Scanner scanner = new Scanner(System.in);

        
        boolean work = true;
        boolean isMacOS = false;
        boolean isMacbook = false;
        String[] criteria = {"", "Brand", "RAM", "HDD capacity", "OS", "Color", "Price"};
        
        while (work) {

            System.out.println("Enter the number that meets the required criterion:");
            for (int i = 1; i < criteria.length; i++) {
                System.out.println(String.valueOf(i) + " - " + criteria[i]);
            }
            System.out.println("11 - Reset filter");
            System.out.print("0 - Search and print result \n  -> ");
            int key = scanner.nextInt();
            int value;
            scanner.nextLine();

            switch (key) {
                case 1: // BRAND equal
                    if (isMacOS) {
                        System.out.println("Cannot be selected due to filter");
                        System.out.println("Change OS to filter by brand");
                        break;
                    }

                    System.out.println("Enter the number that meets the required brand:");
                    for (int i = 0; i < brand.length; i++) {
                        System.out.println(String.valueOf(i + 1) + " - " + brand[i]);
                    }
                    System.out.print("  -> ");
                    value = scanner.nextInt() - 1;
                    scanner.nextLine();
                    
                    if (value == 0) {
                        filter.put(4, 0);
                        criteria[4] = "OS -> (MacOS only)";
                        isMacbook = true;
                    } else if (value >= brand.length || value < 0) {
                        break;
                    } else if (isMacbook) {
                        filter.remove(4);
                        criteria[4] = "OS";
                        isMacbook = false;
                    }

                    filter.put(key, value);
                    criteria[key] = "Brand -> " + brand[value];
                    break;
                case 2: // RAM minimum
                    System.out.println("Enter the number that meets the required minimum RAM capacity:");
                    for (int i = 0; i < ram.length; i++) {
                        System.out.println(String.valueOf(i + 1) + " - " + ram[i]);
                    }
                    System.out.print("  -> ");
                    value = scanner.nextInt() - 1;
                    scanner.nextLine();

                    if (value >= ram.length || value < 0) {
                        break;
                    }
                    
                    filter.put(key, value);
                    criteria[key] = "RAM -> " + ram[value];
                    break;
                case 3: // HDD minimum
                    System.out.println("Enter the number that meets the required HDD capacity type:");
                    for (int i = 0; i < capacityType.length; i++) {
                        System.out.println(String.valueOf(i + 1) + " - " + capacityType[i]);
                    }
                    System.out.print("  -> ");
                    int typeID = scanner.nextInt() - 1; // 0
                    scanner.nextLine();
                    if (typeID > hardDiskCapacity.length || typeID < 0) {
                        break;
                    }

                    filter.put(0, typeID);
                    System.out.println("Enter the number that meets the required minimum HDD capacity:");
                    for (int i = 0; i < hardDiskCapacity[typeID].length; i++) {
                        System.out.println(String.valueOf(i + 1) + " - " + hardDiskCapacity[typeID][i]);
                    }
                    System.out.print("  -> ");
                    value = scanner.nextInt() - 1; // 2
                    scanner.nextLine();
                    if (value >= hardDiskCapacity[typeID].length || value < 0) {
                        break;
                    }

                    filter.put(key, value);
                    criteria[key] = "HDD capacity -> " + hardDiskCapacity[typeID][value] + capacityType[typeID];
                    break;
                case 4: // OS equal
                    if (isMacbook) {
                        System.out.println("WARNING: Cannot be selected due to filter");
                        System.out.println("Change brand to filter by OS");
                        break;
                    }

                    System.out.println("Enter the number that meets the required OS:");
                    for (int i = 0; i < os.length; i++) {
                        System.out.println(String.valueOf(i + 1) + " - " + os[i]);
                    }
                    System.out.print("  -> ");
                    value = scanner.nextInt() - 1;
                    scanner.nextLine();

                    if (value == 0) {
                        filter.put(1, 0);
                        criteria[1] = "Brand -> (Macbook only)";
                        isMacOS = true;
                    } else if (value >= os.length || value < 0) {
                        break;
                    } else if (isMacOS){
                        filter.remove(0);
                        criteria[1] = "Brand";
                        isMacOS = false;
                    }
                    
                    criteria[key] = "OS -> " + os[value];
                    filter.put(key, value);
                    break;
                case 5: // COLOR equal
                    System.out.println("Enter the number that meets the required minimum color:");
                    for (int i = 0; i < color.length; i++) {
                        System.out.println(String.valueOf(i + 1) + " - " + color[i]);
                    }
                    System.out.print("  -> ");
                    value = scanner.nextInt() - 1;
                    scanner.nextLine();
                    if (value >= color.length || value < 0) {
                        break;
                    }

                    filter.put(key, value);
                    criteria[key] = "Color -> " + color[value];
                    break;
                case 6: // PRICE minimum
                    System.out.println("Laptops available price: " + prices.first() + " - " + prices.last());
                    System.out.println("Enter the minimum price of a laptop:");
                    value = scanner.nextInt();
                    scanner.nextLine();

                    if (value < 0) {
                        break;
                    }

                    filter.put(key, value);
                    criteria[key] = "Price -> " + value;
                    break;
                case 11:
                    criteria = Reset(filter);
                    break;
                case 0:
                    result = Search(laptops, filter, brand, ram, capacityType, hardDiskCapacity, os, color);
                    for (Laptop laptop : result) {
                        System.out.println(laptop);
                    }
                    criteria = Reset(filter);
                    break;
                default:
                    break;
            }
        }
    }

    static Set<Laptop> Search(Set<Laptop> laptops, Map<Integer, Integer> filter, String[] brand, int[] ram, String[] capacityType, int[][] hardDiskCapacity, String[] os, String[] color) {
        Set<Laptop> result = new HashSet<>();
    
        if (filter.get(1) != null) {
            for (Laptop laptop : laptops) {
                if (laptop.brand.equals(brand[filter.get(1)])) {
                    result.add(laptop);
                }
            }
            filter.put(1, null);
        } else if (filter.get(2) != null) {
            for (Laptop laptop : laptops) {
                if (laptop.ram >= (ram[filter.get(2)])) {
                    result.add(laptop);
                }
            }
            filter.put(2, null);
        } else if (filter.get(3) != null) {
            for (Laptop laptop : laptops) {
                if (laptop.hardDisk.hardDiskCapacity >= (hardDiskCapacity[filter.get(0)][filter.get(3)])) {
                    result.add(laptop);
                }
            }
            filter.put(3, null);
        } else if (filter.get(4) != null) {
            for (Laptop laptop : laptops) {
                if (laptop.os.equals(os[filter.get(4)])) {
                    result.add(laptop);
                }
            }
            filter.put(4, null);
        } else if (filter.get(5) != null) {
            for (Laptop laptop : laptops) {
                if (laptop.color.equals(color[filter.get(5)])) {
                    result.add(laptop);
                }
            }
            filter.put(5, null);
        } else if (filter.get(6) != null) {
            for (Laptop laptop : laptops) {
                if (laptop.price >= filter.get(6)) {
                    result.add(laptop);
                }
            }
            filter.put(6, null);
        } else {
            result = laptops;
        }

        for (Laptop laptop : laptops) {
            if (filter.get(1) != null && !laptop.brand.equals(brand[filter.get(1)])) {
                result.remove(laptop);
            } else if (filter.get(2) != null && laptop.ram <= ram[filter.get(2)]) {
                result.remove(laptop);
            } else if (filter.get(3) != null && laptop.hardDisk.hardDiskCapacity <= hardDiskCapacity[filter.get(0)][filter.get(3)]) {
                result.remove(laptop);
            } else if (filter.get(4) != null && !laptop.os.equals(os[filter.get(4)])) {
                result.remove(laptop);
            } else if (filter.get(5) != null && !laptop.color.equals(color[filter.get(5)])) {
                result.remove(laptop);
            } else if (filter.get(6) != null && laptop.price <= filter.get(6)) {
                result.remove(laptop);
            }
        }

        return result;
    }

    static String[] Reset(Map<Integer, Integer> map) {
        for (int i = 0; i < map.size(); i++) {
            map.put(i, null);
        }
        return new String[] {"", "Brand", "RAM", "HDD capacity", "OS", "Color", "Price"};
    }

}

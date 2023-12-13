package Sem_1.Task_2;

class Answer {
    public void printPrimeNums(){
        // Напишите свое решение ниже
        int[] primeNums = {2};
        int hitCount = 0;
        
        for (int i = 3; i < 1000; i++) {
            for (int j = 0; j < primeNums.length; j++) {
                if (!(i % primeNums[j] == 0)) {
                    hitCount++;
                } else if (hitCount == primeNums.length) {
                    primeNums = addElement(primeNums, i - 1);
                    hitCount = 0;
                    break;
                } else {
                    hitCount = 0;
                    break;
                }
                
            }
        }
        for (int el : primeNums) {
            System.out.println(el);
        }
    }

    static int[] addElement(int[] array, int element) {
        int[] newArray = new int[array.length + 1];
        System.arraycopy(array, 0, newArray, 0, array.length);
        newArray[array.length] = element;
        return newArray;
    }
}

// Не удаляйте этот класс - он нужен для вывода результатов на экран и проверки
public class Printer{ 
    public static void main(String[] args) { 
      
      Answer ans = new Answer();      
      ans.printPrimeNums();
    }
}
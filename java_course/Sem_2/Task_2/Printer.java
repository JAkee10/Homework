package Sem_2.Task_2;

import java.io.File;
import java.io.FileWriter;
import java.io.FileReader;
import java.io.BufferedReader;
import java.io.IOException;
import java.util.Arrays;
import java.text.SimpleDateFormat;
import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.LocalTime;
import java.util.Date;

/*
 * Реализуйте алгоритм сортировки пузырьком числового массива, результат после каждой итерации запишите в лог-файл.

Напишите свой код в методе sort класса BubbleSort. Метод sort принимает на вход один параметр:

int[] arr - числовой массив

После каждого прохода по массиву ваш код должен делать запись в лог-файл 'log.txt' в формате год-месяц-день час:минуты {массив на данной итерации}. 
Для логирования использовать логгер logger класса BubbleSort.
 */
class BubbleSort {
    private static File log;
    private static FileWriter fileWriter;
    static String logPath = "Sem_2/Task_2/log.txt";
    
    public static void sort(int[] mas) {
        for (int i = 0; i < mas.length; i++) {
            int counter = 1;
            boolean isLog = true;
            for (int j = 1; j < mas.length; j++) {
                if (mas[j-1] > mas[j]) {
                    int temp = mas[j-1];
                    mas[j-1] = mas[j];
                    mas[j] = temp;
                } else if (counter == mas.length - 1) {
                    isLog = false;
                } else {
                    counter++;
                }
            }
            writeLog(mas);
            if (isLog) {
                i = mas.length - 2;
            }
        }
    }
    
    static void writeLog(int[] mas) {
        StringBuilder str = new StringBuilder(LocalDateTime.now().toString());
        str = str.delete(16, str.length())
                 .replace(10, 11, " ")
                 .append(" ")
                 .append(Arrays.toString(mas))
                 .append("\n");
        String log = str.toString();
    
        try {
            fileWriter = new FileWriter(logPath, true);
            fileWriter.append(log);
            fileWriter.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
        
    }

    static void clearLog() {
        try {
            fileWriter = new FileWriter(logPath);
            fileWriter.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

}

// Не удаляйте этот класс - он нужен для вывода результатов на экран и проверки
public class Printer{ 
    public static void main(String[] args) { 
        int[] arr = {};
        
        if (args.length == 0) {
          // При отправке кода на Выполнение, вы можете варьировать эти параметры
          arr = new int[]{9, 3, 4, 8, 2, 5, 7, 1, 6, 10};
        }
        else{
          arr = Arrays.stream(args[0].split(", "))
                          .mapToInt(Integer::parseInt)
                          .toArray();
        }     

        BubbleSort ans = new BubbleSort();      
        BubbleSort.clearLog();
        ans.sort(arr);

        try (BufferedReader br = new BufferedReader(new FileReader(BubbleSort.logPath))) {
            String line;
            while ((line = br.readLine()) != null) {
                System.out.println(line);
            }
        }catch (IOException e) {
            e.printStackTrace();
        }
    }
}

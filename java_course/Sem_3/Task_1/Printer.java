package Sem_3.Task_1;
/*
 * Внутри класса MergeSort напишите метод mergeSort, который принимает массив целых чисел, 
 * реализует алгоритм сортировки слиянием. Метод должен возвращать отсортированный массив.
Пример:
a = {5, 1, 6, 2, 3, 4} -> [1, 2, 3, 4, 5, 6]
 */
import java.util.Arrays;

class MergeSort {
    public static int[] mergeSort(int[] a) {
        // Напишите свое решение ниже
        int half = a.length/2;
        int[] leftHalf;
        int[] rightHalf;
        if (a.length <= 1) {
            return a;
        }
        else {
            leftHalf = mergeSort(Arrays.copyOfRange(a, 0, half));
            rightHalf = mergeSort(Arrays.copyOfRange(a, half, a.length));
        }
        return merge(leftHalf, rightHalf);
        // System.out.println(Arrays.toString(a1) + Arrays.toString(a2));
    }

    static int[] merge(int[] leftHalf, int[] rightHalf) {
        int[] result = new int[leftHalf.length + rightHalf.length];
        int indexLeft = 0;
        int indexRight = 0;
        int indexResult = 0;
        while (indexLeft < leftHalf.length && indexRight < rightHalf.length) {
            if (leftHalf[indexLeft] <= rightHalf[indexRight]) {
                result[indexResult++] = leftHalf[indexLeft++];
            } else {
                result[indexResult++] = rightHalf[indexRight++];
            }
        }
        while (indexLeft < leftHalf.length) {
            result[indexResult++] = leftHalf[indexLeft++];
        }

        while (indexRight < rightHalf.length) {
            result[indexResult++] = rightHalf[indexRight++];
        }
        // System.out.println(Arrays.toString(leftHalf) + Arrays.toString(rightHalf));
        return result;
    }
}

// Не удаляйте этот класс - он нужен для вывода результатов на экран и проверки
public class Printer{ 
    public static void main(String[] args) { 
        int[] a;

        if (args.length == 0) {
        // При отправке кода на Выполнение, вы можете варьировать эти параметры
            a = new int[]{5, 1, 6, 2, 3, 7, 1, 4};
        } else {
            a = Arrays.stream(args[0].split(", ")).mapToInt(Integer::parseInt).toArray();
        }

        MergeSort answer = new MergeSort();
        String itresume_res = Arrays.toString(answer.mergeSort(a));
        System.out.println(itresume_res);
    }
}